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
using Ionic.Zip;

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

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

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
                //Backup the OSIRiS binary and extract the newly downloaded zip file. 
                File.Move("OSIRiS.exe", "OSIRiS.backup.exe");
                using (ZipFile zip = ZipFile.Read("latest.zip"))
               {
                 foreach (ZipEntry e in zip)
                   {
                       e.Extract(@".", ExtractExistingFileAction.OverwriteSilently);
                   }
                    DialogResult restart = MessageBox.Show("Update Complete, press OK to restart OSIRiS.", "Restart" , MessageBoxButtons.OK);
                    if (restart == DialogResult.OK)
                    {
                        Process.Start("OSIRiS.exe");
                        Process.GetCurrentProcess().Kill();
                    }

                 
               }
            }
        }

        private void updater_Shown(object sender, EventArgs e)
        {
            DownloadFile("Http://gnuplusadam.com/OSIRiS/latest.zip", "latest.zip");
            
        }




        
    }
}
