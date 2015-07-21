using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace OSIRiS
{
    public partial class splash : Form
    {

        public splash()
        {

            InitializeComponent();
            if (File.Exists(@"resources\version.remote.txt"))
            {
                File.Delete(@"resources\version.remote.txt");
            }
            if (File.Exists(@"OSIRiS.exe.bak"))
            {
                File.Delete(@"OSIRiS.exe.bak");
            }
            if (File.Exists(@"latest.zip"))
            {
                File.Delete(@"latest.zip");
            }
            if (Directory.Exists(@"backup"))
            {
                Directory.Delete(@"backup", true);
            }

                    using (var client = new WebClient())
                        try
                        {
                            client.DownloadFile("http://gnuplusadam.com/OSIRiS/version", @"resources\version.remote.txt");
                        }
                        catch (WebException ex)
                        {
                            if (ex.Status == WebExceptionStatus.ProtocolError)
                            {
                                if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                                {
                                    return;
                                }
                            }
                            else if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                            {
                                return;
                            }
                        }
                }
            
        

        private void splash_Load(object sender, EventArgs e)
        {

            // Interval of 0,1 seconds
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(this.Tick);
            timer1.Enabled = true;
            this.Opacity = 0;
        }
        private bool increase = true;
        private void Tick(object sender, EventArgs e)
        {
            if (increase)
                this.Opacity += 0.03D;

            if (this.Opacity == 1)
                increase = false;

        }
    }
}


