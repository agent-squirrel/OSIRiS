using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OSIRiS
{
    public partial class update_complete : MaterialForm
    {
        public update_complete()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey400, Primary.Indigo100, Accent.Amber700, TextShade.WHITE);
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
