using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace OSIRiS
{
    public partial class AboutBox : MaterialForm
    {
        public AboutBox()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey400, Primary.Indigo100, Accent.Amber700, TextShade.WHITE);
            this.versionlabel.Text = String.Format("Version {0}", AssemblyVersion);
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void manual_button_Click(object sender, EventArgs e)
        {
            string appPath = Assembly.GetEntryAssembly().Location;
            string filename = Path.Combine(Path.GetDirectoryName(appPath), @"OSIRiS_Manual.pdf");
            Process.Start(filename);
            this.Hide();
        }

        private void websitelink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            Process.Start("https://gnuplusadam.com/OSIRiS/");
            this.Hide();
        }
    }
}
