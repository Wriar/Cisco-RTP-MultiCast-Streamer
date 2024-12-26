using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace libCiscoRTPStreamer
{
    public class streamUtils
    {
        private Process ffmpegProcess;

        //Constructor
        public streamUtils()
        {
            ffmpegProcess = null;
        }


        /// <summary>
        /// This method sends a request to the Cisco endpoint to start or stop listening to a multicast media stream.
        /// An endpoint must be listening to a multicast address before it can receive any data.
        /// 
        /// A media ID is generated if the subscription request is successful. This ID is used to stop the stream.
        /// If there is an error, an exception is thrown.
        /// 
        /// To request a mediastream subscription, set typeBeginEnd to 1. MediaID should be null.
        /// To request mediastream unsubscribe, set typeBeginEnd to 0. MediaID should be the ID of the stream to stop.
        /// </summary>
        /// <param name="typeBeginEnd">Subscribe = 1, Unsubscribe = 0</param>
        /// <param name="ip">IP address of the endpoint</param>
        /// <param name="uid">Authorization Username</param>
        /// <param name="pwd">Authorization Password</param>
        /// <param name="volume">Volume (1~100) Optional.</param>
        /// <param name="sourceAddress">Multicast Address to Listen To. Leave null for unsubscribe task.</param>
        /// <param name="port">Multicast Port to Listen To. Leave null for unsubscribe task.</param>
        /// <param name="mediaID">(Optional) If stopping a stream, the dynamically-generated MediaStream ID to request. Typically 'receive:-1'</param>
        /// <returns>MediaID</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<string> REQUEST_MULTICAST_SUBSCRIBE(int typeBeginEnd, string ip, string uid, string pwd, int volume = 50, string sourceAddress = null, string port = null, string mediaID = "receive:-1")
        {
            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{uid}:{pwd}"));

            //This needs to be in one line or else the request payload is allegedly "JOE SIZED".
            string xml = "";
            if (typeBeginEnd == 1)
            {
                xml = $@"<startMedia><mediaStream receiveVolume=""{volume}""><type>audio</type><codec>G.711</codec><mode>receive</mode><address>{sourceAddress}</address><port>{port}</port></mediaStream></startMedia>";

            }
            else
            {
                xml = $@"<stopMedia><mediaStream id=""{mediaID}""/></stopMedia>";
            }

            string xmlEncoded = "XML=" + Uri.EscapeDataString(xml);

            using (var client = new HttpClient())
            {
                //Set authorization values.
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", auth);

                var content = new StringContent(xmlEncoded, Encoding.UTF8, "application/x-www-form-urlencoded");
                var response = await client.PostAsync($"http://{ip}/CGI/Execute", content);

                //Free up resources
                content.Dispose();
                client.Dispose();



                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Request successful");
                    //The Response is XML with a <mediaStream id=”abc123”/>. Get the ID and return it.

                    string responseString = await response.Content.ReadAsStringAsync();

                    //We need the MediaStream ID if we are starting a stream. How else would we end it?
                    if (typeBeginEnd == 1)
                    {
                        string id = responseString.Split(new string[] { "<mediaStream id=\"" }, StringSplitOptions.None)[1].Split('"')[0];
                        return id;
                    }

                    //Assuming we are ending the stream, we don't need the ID.
                    return responseString;
                }
                else
                {
                    //If unauthorized:
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                        throw new Exception($"Unauthorized! Please check the logon credentials.");
                    }

                    //If bad request:
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                        throw new Exception($"Bad Request! Verify the device is connected to the network, the IP address is correct, and no external streams are already started/stopped.");
                    }
                    throw new Exception($"Error {response.StatusCode}. Verify the device is functioning properly.");
                }
            }


        }


        public void StopFFmpegProcess()
        {
            if (ffmpegProcess != null && !ffmpegProcess.HasExited)
            {
                try
                {
                    ffmpegProcess.Kill();
                    ffmpegProcess.Dispose();
                    ffmpegProcess = null;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error starting stream {ex.Message}");
                }
            }
        }

        public void StartFFmpegProcess(String inputFilePath, String sourceAddress, String sourcePort, String volume)
        {
            //Verify no FFMPEGs are running
            StopFFmpegProcess();
            try
            {
                String ISourceAddress = $"rtp://{sourceAddress}:{sourcePort}";

                int sampleRate = 8000;
                int numSamples = 160;

                //Make inputFilePath more friendly
                inputFilePath = inputFilePath.Replace(@"\", @"/");

                Console.WriteLine("Running command: " + $"-re -i \"{inputFilePath}\" -filter_complex \"aresample={sampleRate},asetnsamples=n={sampleRate}\" -acodec pcm_mulaw -ac 1 -f rtp {ISourceAddress}");

                ffmpegProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg.exe",
                        Arguments = $"-re -i \"{inputFilePath}\" -filter_complex \"aresample={sampleRate},asetnsamples=n={numSamples}\" -acodec pcm_mulaw -ac 1 -f rtp {ISourceAddress}",
                        WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                ffmpegProcess.OutputDataReceived += (s, args) => HandleFFmpegOutput(s, args);
                ffmpegProcess.ErrorDataReceived += (s, args) => HandleFFmpegError(s, args);

                ffmpegProcess.Start();
                ffmpegProcess.BeginOutputReadLine();
                ffmpegProcess.BeginErrorReadLine();


                //MessageBox.Show("Start");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error starting stream: {ex.Message}");
            }
        }

        public void HandleFFmpegOutput(object sender, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                //INIT OUTPUT.


            }
            else
            {
                Console.WriteLine("No data: " + args.Data);
            }
        }

        //These aren't errors, just status updates.
        public void HandleFFmpegError(object sender, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                string sizePattern = @"size=\s*(\S+)";
                string timePattern = @"time=(\S+)";
                string bitratePattern = @"bitrate=\s*(\S+)";

                Console.WriteLine("Incoming Data: " + args.Data);

                //Check if all three exist.
                if (Regex.IsMatch(args.Data, sizePattern) && Regex.IsMatch(args.Data, timePattern) && Regex.IsMatch(args.Data, bitratePattern))
                {
                    string size = Regex.Match(args.Data, sizePattern).Groups[1].Value;
                    string time = Regex.Match(args.Data, timePattern).Groups[1].Value;
                    string bitrate = Regex.Match(args.Data, bitratePattern).Groups[1].Value;
                    string speed = Regex.Match(args.Data, @"speed=\s*(\S+)").Groups[1].Value;
                    Console.WriteLine($"Size: {size}, Time: {time}, Bitrate: {bitrate}");

                   

                }
            }
        }


    }
}
