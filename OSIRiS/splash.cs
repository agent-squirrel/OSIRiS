using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            if (File.Exists(@"gpl.bak.txt"))
            {
                File.Delete(@"gpl.bak.txt");
            }
            if (File.Exists(@"OSIRiS_Manual.docx.bak"))
            {
                File.Delete(@"OSIRiS_Manual.docx.bak");
            }
            if (File.Exists(@"OSIRiS_Manual.pdf.bak"))
            {
                File.Delete(@"OSIRiS_Manual.pdf.bak");
            }
            if (File.Exists(@"latest.zip"))
            {
                File.Delete(@"latest.zip");
            }
            if (Directory.Exists(@"resources.bak"))
            {
                Directory.Delete(@"resources.bak", true);
            }
            if (Directory.Exists(@"backup"))
            {
                Directory.Delete(@"backup", true);
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




