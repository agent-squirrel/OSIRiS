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
                    info.Text = "Downloading";
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
            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

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
                extract();
            }
        }

        private void updater_Shown(object sender, EventArgs e)

            {
                // Start the progress bar.
                progressBar.Style = ProgressBarStyle.Marquee;
                BackgroundWorker bw = new BackgroundWorker();
                bw.WorkerSupportsCancellation = false;
                bw.WorkerReportsProgress = true;
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                bw.RunWorkerAsync();
            }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    info.Text = "Deleting Old Files";
                    //Delete all the old files and directories so we can replace them.

                    if (File.Exists(@"OSIRiS_Manual.docx"))
                    {
                        File.Delete("OSIRiS_Manual.docx");
                    }
                    if (File.Exists(@"OSIRiS_Manual.pdf"))
                    {
                        File.Delete("OSIRiS_Manual.pdf");
                    }
                    if (File.Exists(@"gpl.txt"))
                    {
                        File.Delete("gpl.txt");
                    }
                    if (Directory.Exists(@"resources"))
                    {
                        Directory.Delete(@"resources", true);
                    }

                    File.Move("OSIRiS.exe", "OSIRiS.exe.bak");
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    //Unpack to the USB.
                    progressBar.Style = ProgressBarStyle.Marquee;
                    info.Text = "Extracting";
                    ZipFile.ExtractToDirectory(Path.GetTempPath() + "latest.zip", ".");
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Download the new version of OSIRiS.
            // Start the progress bar.
            progressBar.Style = ProgressBarStyle.Blocks;
            DownloadFile("https://gnuplusadam.com/OSIRiS/latest.zip", Path.GetTempPath() + "latest.zip");
        }
        private void bw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            info.Text = "Done";
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.MarqueeAnimationSpeed = 0;
            DialogResult complete = MessageBox.Show("Update complete, press OK to restart OSIRiS.", "Complete", MessageBoxButtons.OK);
            if (complete == DialogResult.OK)
            {
                Process.Start("OSIRiS.exe");
                Application.Exit();
            }
        }
        private void extract()
        {
            // Start the progress bar.
            progressBar.Style = ProgressBarStyle.Marquee;
            BackgroundWorker bw2 = new BackgroundWorker();
            bw2.WorkerSupportsCancellation = false;
            bw2.WorkerReportsProgress = true;
            bw2.DoWork += new DoWorkEventHandler(bw2_DoWork);
            bw2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw2_RunWorkerCompleted);
            bw2.RunWorkerAsync();
        }

                }

            }
            
        






        
    

