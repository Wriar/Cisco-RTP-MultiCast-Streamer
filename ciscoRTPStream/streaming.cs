using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ciscoRTPStream
{
    public class streaming
    {
        /**
        * <Summary>
        * This method sends a POST request to the Cisco endpoint to begin/end listening to the audio stream.
        * 
        * When ending the media stream (first parameter is 0), the mediaID is required.
        * If starting the stream is successful, the mediaID is returned.
        * If starting the stream has failed, an exception is thrown.
        * 
        * Ensure the payload is not too big or the request will fail.
        * 
        * </Summary>
        * 
        * <param name="typeBeginEnd">1 to begin listening, 0 to end listening</param>
        * <param name="ip">The IP address of the Cisco endpoint</param>
        * <param name="uid">The username to log in to the Cisco endpoint</param>
        * <param name="pwd">The password to log in to the Cisco endpoint</param>
        * <param name="volume">The volume to listen to the stream at. Default is 50. Not required if end listening is the type.</param>
        * <param name="sourceAddress">The source address of the stream. Required if beginning listening.</param>
        * <param name="port">The multicast RTP streaming port.</param>
        * <param name="mediaID">The media ID of the stream. Default is "receive:-1". Not required if beginning listening is the type.</param>
        **/
        public static async Task<string> PUSH_BEGINEND_LISTENING_MEDIASTREAM(int typeBeginEnd, string ip, string uid, string pwd, string volume = "50", string sourceAddress = null, string port = null, string mediaID = "receive:-1")
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

    }
        
}
