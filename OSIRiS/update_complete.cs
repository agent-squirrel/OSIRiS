using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace OSIRiS
{
    public partial class update_complete : Form
    {
        public update_complete()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (releasenotescheckbox.Checked == true)
            {
                if (releasenotescheckbox.Checked == true)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://gnuplusadam.com/OSIRiS/releasenotes.txt", Path.GetTempPath() + "OSIRiS Release Notes.txt");
                    }
                    Process.Start(Path.GetTempPath() + "OSIRiS Release Notes.txt");
                }
                Process.Start("OSIRiS.exe");
                Application.Exit();
            }
            else
            {
                Process.Start("OSIRiS.exe");
                Application.Exit();
            }

        }
    }
}
