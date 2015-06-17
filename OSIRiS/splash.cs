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
            if (File.Exists(@"OSIRiS.backup.exe"))
            {
                File.Delete(@"OSIRiS.backup.exe");
            }
            if (File.Exists(@"latest.zip"))
            {
                File.Delete(@"latest.zip");
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

    }
}


