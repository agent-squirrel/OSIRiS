using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;



namespace OSIRiS
{

    public partial class updater : Form


    {
        WebClient webClient;               // Our WebClient that will be doing the downloading for us
        Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed
        public updater()
        {
            InitializeComponent();
            

        }

        public void DownloadFile(string urlAddress, string location)

        {
            
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with https://)
                Uri URL = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("https://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs ex)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (ex.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                //Call the update powershell script and decompress the new build. (If it exists)

                if (File.Exists(@"resources\update\update.ps1"))
                {
                    string command = @"/c powershell -executionpolicy bypass resources\update\update.ps1";
                    ProcessStartInfo start = new ProcessStartInfo("cmd.exe", command);
                    Process.Start(start).WaitForExit();
                }
                else
                {
                    File.Move("OSIRiS.exe", "OSIRiS.exe.bak");
                }


                ZipFile.ExtractToDirectory("latest.zip", ".");
                DialogResult complete = MessageBox.Show("Update complete, press OK to restart OSIRiS.", "Complete", MessageBoxButtons.OK);
                if (complete == DialogResult.OK)
                {
                    Process.Start("OSIRiS.exe");
                    Application.Exit();
                }


            }
        }

        private void updater_Shown(object sender, EventArgs e)

            {
                DownloadFile("https://gnuplusadam.com/OSIRiS/latest.zip", "latest.zip");

            }
                }

            }
            
        






        
    

