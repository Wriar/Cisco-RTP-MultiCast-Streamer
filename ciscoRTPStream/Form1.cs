using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Diagnostics;
using System.Net;

namespace ciscoRTPStream
{
    public partial class rtpStreamMain : Form
    {
        public rtpStreamMain()
        {
            InitializeComponent();

            // Handle application exit to clean up resources
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            Application.ApplicationExit += OnApplicationExit;
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            StopFFmpegProcess();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            StopFFmpegProcess();
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            StopFFmpegProcess();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopFFmpegProcess();
        }


        private void rtpStreamMain_Load(object sender, EventArgs e)
        {
            //Enable scaling for high DPI displays.
            this.AutoScaleMode = AutoScaleMode.Dpi;

            //Check for FFMPEG
            if (!System.IO.File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg.exe was not found in this application's directory. Please place ffmpeg.exe in the same directory as this application then restart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            //Check if the user has an 'OPT-OUT.flag' file in the same directory as the application.
            //If they do not, send a ping to the analytics server in order to determine active users of this program.

            if (!System.IO.File.Exists("OPT-OUT.flag"))
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://app-analytic.wriar.org/");
                        var response = client.GetAsync("ping?app=ciscoRTPStream").Result;
                    }
                }
                catch (Exception)
                {
                    //Do Nothing.
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Show the About Box Window, if one is not already visible.
            if (Application.OpenForms["AboutBox"] == null)
            {
                AboutBox aboutBox = new AboutBox();
                aboutBox.Show();
            }
            else
            {
                Application.OpenForms["AboutBox"].BringToFront();
            }
        }

        private void groupAddEndpoints_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtfClientDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            txtVolume.Text = tbVolume.Value.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {


                //Use the OpenFileDialog to select a CSV or Text file to import.

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Select a CSV or Text file to import. (Hint: One IP Per Line)";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    //Read the file and add each line to the list box.
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);

                    //Use regex to validate each line as an IP address.
                    //If the line is not a valid IP address, skip it.

                    //If the line is a valid IP address, add it to the list box.
                    string[] invalidLines = new string[0];

                    foreach (string line in lines)
                    {
                        if (IsValidIP(line))
                        {
                            txtClients.Text += line + Environment.NewLine;
                        }
                        else
                        {
                            invalidLines = invalidLines.Concat(new string[] { line }).ToArray();
                        }
                    }

                    if (invalidLines.Length > 0)
                    {
                        MessageBox.Show(invalidLines.Length + " lines could not be added. Ensure each line contains a single IPv4 address in format XXX.XXX.XXX.XXX.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("All IPs were added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while importing the file. Please try again.\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean IsValidIP(string ip)
        {
            string pattern = @"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)(\.(?!$)|$)){4}$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(ip);
            return match.Success;

        }

        private void btnValidateAndSave_Click(object sender, EventArgs e)
        {
            try
            {


                //Loop through each line in the list box and validate it as an IP address. Remove any invalid lines.
                string[] lines = txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string[] invalidLines = new string[0];
                foreach (string line in lines)
                {
                    if (!IsValidIP(line))
                    {
                        invalidLines = invalidLines.Concat(new string[] { line }).ToArray();
                    }
                }

                if (invalidLines.Length > 0)
                {
                    //Prompt the number of invalid lines and ask if the user would like to remove them.
                    DialogResult dialogResult = MessageBox.Show(invalidLines.Length + " lines were invalid and could not be saved. Would you like to remove them?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtClients.Text = string.Join(Environment.NewLine, lines.Except(invalidLines));
                        MessageBox.Show("All valid IPs are now validated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No IPs were validated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("All IPs were validated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating the IPs. Please try again.\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //Select the audio .wav file to stream.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV Files (*.wav)|*.wav|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select an audio .wav file to stream.";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                txtFile.Text = openFileDialog.FileName;
            }


        }

        private void btnAdvReqMS_Click(object sender, EventArgs e)
        {
            enableDisableControlState(false);
            //Verify Client IPs are not null
            if (txtClients.Text == "")
            {
                MessageBox.Show("No client IP addresses were provided. Please provide at least one IPv4 address before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableDisableControlState(true);
                return;
            }

            //Validate IPs
            foreach (string ip in txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (!IsValidIP(ip))
                {
                    MessageBox.Show("One or more IP addresses are invalid. Please correct them before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    enableDisableControlState(true);
                    return;
                }
            }
            createMediaStreamRequest(true, txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None), txtVolume.Text, txtCodec.Text, txtSourceAddress.Text, txtSourcePort.Text, txtUsername.Text, txtPassword.Text);
            enableDisableControlState(true); //Debug Button.
        }
        private static readonly HttpClient client = new HttpClient();


        //Map of IP to MediaStreamID
        private Dictionary<String, String> mediaStreamIDs = new Dictionary<String, String>();

        private async void createMediaStreamRequest(Boolean doSuccessNotify, String[] devices, String volume, String codec, String sourceAddr, String port, String httpUsername, String httpPassword)
        {
            //Send a CGI Request to the phones to listen in on the audio stream.
            string[] failedDevices = new string[0];
            int deviceCount = 0;

            lblStreamStatus.BackColor = Color.Orange;
            lblStreamStatus.Text = $"Requesting MediaStream Reservations ({deviceCount}/{devices.Length})";

            //For each device, try to start the media stream. If the media stream fails, add it to a list of failed devices.
            foreach (String device in devices)
            {
                //Update status indicator props
                deviceCount++;
                lblStreamStatus.Text = $"Requesting MediaStream Reservations ({deviceCount}/{devices.Length})";
                try
                {
                    //do the thing
                    String mediaStreamID = await streaming.PUSH_BEGINEND_LISTENING_MEDIASTREAM(1,device, httpUsername, httpPassword, volume, sourceAddr, port);
                    mediaStreamIDs.Add(device, mediaStreamID);

                }
                catch (Exception ex)
                {
                    //the thing didn't work. Add the device to a list of failed devices.
                    failedDevices = failedDevices.Concat(new string[] { device + ": " + ex.Message }).ToArray();

                }
            }

            //If there are failed devices, show a message box with the failed devices.
            if (failedDevices.Length > 0)
            {
                MessageBox.Show("The following devices failed to receive the audio stream request:\n\n" + string.Join(Environment.NewLine, failedDevices) + $"\n\n Streaming has been successfully reserved on {devices.Length - failedDevices.Length} devices." + "\nClick OK to Continue", $"RTP Stream Partial Reservation: ({devices.Length - failedDevices.Length}/{devices.Length})", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //If there are no failed devices, show a success message box, if the user wants to be notified.
            else if (doSuccessNotify)
            {
                MessageBox.Show($"All devices received the audio stream request successfully ({devices.Length}/{devices.Length}).", "RTP Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Update status indicator
            lblStreamStatus.BackColor = Color.Gold;
            lblStreamStatus.Text = "(Reserved Streams)";
        }

        private async void createMediaStreamStopRequest(Boolean doSuccessNotify, String[] devices, String httpUsername, String httpPassword)
        {
            //Send a CGI Request to the phones to stop listening in on the audio stream.
            string[] failedDevices = new string[0];
            int deviceCount = 0;
            lblStreamStatus.BackColor = Color.Orange;
            lblStreamStatus.Text = $"Releasing MediaStream ({deviceCount}/{devices.Length})";
            //For each device, try to stop the media stream. If the media stream fails, add it to a list of failed devices.
            foreach (String device in devices)
            {
                //Update status indicator props
                deviceCount++;
                lblStreamStatus.Text = $"Releasing MediaStream ({deviceCount}/{devices.Length})";
                try
                {
                    //do the thing

                    //Use the mediaStreamID in the dictionary. If one does not exist, use default "receive:-1".
                    string mediaID = "receive:-1";
                    if (mediaStreamIDs.ContainsKey(device))
                    {
                        mediaID = mediaStreamIDs[device];
                    }
                    await streaming.PUSH_BEGINEND_LISTENING_MEDIASTREAM(0, device, httpUsername, httpPassword, null, null, null, mediaID);
                    mediaStreamIDs.Remove(device);
                }
                catch (Exception ex)
                {
                    //the thing didn't work. Add the device to a list of failed devices.
                    failedDevices = failedDevices.Concat(new string[] { device + ": " + ex.Message }).ToArray();
                }
            }
            //If there are failed devices, show a message box with the failed devices.
            if (failedDevices.Length > 0)
            {
                MessageBox.Show("The following devices failed to stop the audio stream:\n\n" + string.Join(Environment.NewLine, failedDevices) + $"\n\n Streaming has been successfully stopped on {devices.Length - failedDevices.Length} devices." + "\nClick OK to Continue", $"RTP Stream Partial Stop: ({devices.Length - failedDevices.Length}/{devices.Length})", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //If there are no failed devices, show a success message box, if the user wants to be notified.
            else if (doSuccessNotify)
            {
                MessageBox.Show($"All devices stopped the audio stream successfully ({devices.Length}/{devices.Length}).", "RTP Stop Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Update status indicator
            //lblStreamStatus.BackColor = Color.Gold;
            //lblStreamStatus.Text = "(Released Streams)";
        }
       
        private void btnAdvReqEnd_Click(object sender, EventArgs e)
        {
            //Verify Client IPs are not null
            if (txtClients.Text == "")
            {
                MessageBox.Show("No client IP addresses were provided. Please provide at least one IPv4 address before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableDisableControlState(true);
                return;
            }
            //Validate IPs
            foreach (string ip in txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (!IsValidIP(ip))
                {
                    MessageBox.Show("One or more IP addresses are invalid. Please correct them before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            createMediaStreamStopRequest(true, txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None), txtUsername.Text, txtPassword.Text);
            enableDisableControlState(true);
        }

        //Enable or disable controls in the form when actions are being performed.
        private void enableDisableControlState(Boolean enabled)
        {
            //Enable or disable all controls on the form.
            txtFile.Enabled = enabled;
            btnSelectFile.Enabled = enabled;
            txtSourceAddress.Enabled = enabled;
            //txtSourcePort.Enabled = enabled;
            tbVolume.Enabled = enabled;
            txtUsername.Enabled = enabled;
            txtPassword.Enabled = enabled;
            //txtClients.Enabled = enabled;
            btnImport.Enabled = enabled;
            btnValidateAndSave.Enabled = enabled;
        }


        private Process ffmpegProcess;

        private void btnAdvStrGo_Click(object sender, EventArgs e)
        {

            enableDisableControlState(false);
            //Verify Client IPs are not null
            if (txtClients.Text == "")
            {
                MessageBox.Show("No client IP addresses were provided. Please provide at least one IPv4 address before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableDisableControlState(true);
                return;
            }
            //Verify inputs are valid
            if (!IsValidIP(txtSourceAddress.Text))
            {
                MessageBox.Show("The source address is invalid. Please correct it before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableDisableControlState(true);
                return;
            }

            //Ensure the file in txtFile exists.
            if (!System.IO.File.Exists(txtFile.Text))
            {
                MessageBox.Show("The file selected does not exist. Please select a valid file before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableDisableControlState(true);
                return;
            }



            StartFFmpegProcess(txtFile.Text, txtSourceAddress.Text, txtSourcePort.Text, tbVolume.Value.ToString());


        }

        private void groupMediaSetup_Enter(object sender, EventArgs e)
        {

        }

        private void StopFFmpegProcess()
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
                    MessageBox.Show($"Error stopping streaming: {ex.Message}");
                }
            }
        }

        private void StartFFmpegProcess(String inputFilePath, String sourceAddress, String sourcePort, String volume)
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

                lblStreamStatus.BackColor = Color.Green;
                lblStreamStatus.Text = "Starting Stream...";

                //MessageBox.Show("Start");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting streaming: {ex.Message}");
            }
        }

        private void HandleFFmpegOutput(object sender, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                //INIT OUTPUT.


            } else
            {
                Console.WriteLine("No data: " + args.Data); 
            }
        }

        //These aren't errors, just status updates.
        private void HandleFFmpegError(object sender, DataReceivedEventArgs args)
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

                    //Update the UI from outside the UI thread.
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblStreamStatus.Text = $"Streaming {size} @ {bitrate}kbps ({speed})";
                        lblStreamStatus.BackColor = Color.Green;
                    });

                }
            }
        }

        private void btnAdvStrEnd_Click(object sender, EventArgs e)
        {
            

            enableDisableControlState(true);
            StopFFmpegProcess();
            lblStreamStatus.BackColor = Color.Red;
            lblStreamStatus.Text = "(NOT STREAMING)";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            enableDisableControlState(false);

            //Validate IPs
            foreach (string ip in txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (!IsValidIP(ip))
                {
                    MessageBox.Show("One or more IP addresses are invalid. Please correct them before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    enableDisableControlState(true);
                    return;
                }
            }
            try
            {
                createMediaStreamRequest(true, txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None), txtVolume.Text, txtCodec.Text, txtSourceAddress.Text, txtSourcePort.Text, txtUsername.Text, txtPassword.Text);
                StartFFmpegProcess(txtFile.Text, txtSourceAddress.Text, txtSourcePort.Text, tbVolume.Value.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show($"An error occurred when starting the stream. Verify all devices are enabled or try again later. Use advanced (ADV) troubleshooting buttons to determine the root cause of the exception.\n\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopFFmpegProcess();
            //Validate IPs
            foreach (string ip in txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (!IsValidIP(ip))
                {
                    MessageBox.Show("One or more IP addresses are invalid. Please correct them before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                createMediaStreamStopRequest(true, txtClients.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None), txtUsername.Text, txtPassword.Text);
                lblStreamStatus.BackColor = Color.Red;
                lblStreamStatus.Text = "(NOT STREAMING)";
                enableDisableControlState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred when stopping the stream. Verify all devices are enabled or try again later. Use advanced (ADV) troubleshooting buttons to determine the root cause of the exception.\n\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void linkSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Wriar/Cisco-RTP-MultiCast-Streamer");
        }
    }
}

