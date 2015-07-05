using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OSIRiS
{
    //Declare the main form called OSIRiSmainwindow and run dinfo.
    //Sleep the form so that the splash screen can show while disks
    //are being polled.


    public partial class OSIRiSmainwindow : Form
    {
        public OSIRiSmainwindow()
        {
            InitializeComponent();
            dinfo();
            Thread.Sleep(2000);
        }

        //Compare the downloaded version file to the locally stored version.
        //If there are any differences, OSIRiS will download an updated version of itself.
        private void OSIRiSmainwindow_Shown(object sender, EventArgs e)
        {

            if (File.Exists(@"resources\version.remote.txt"))
            {
                var localver = File.ReadAllText(@"resources\version.local.txt");
                var remotever = File.ReadAllText(@"resources\version.remote.txt");

                if (localver != remotever)
                {
                    DialogResult update = MessageBox.Show("There is an update available." + Environment.NewLine + "Would you like to update now?", "Update?", MessageBoxButtons.YesNo);
                    if (update == DialogResult.Yes)
                    {
                        File.Delete(@"resources\version.remote.txt");
                        var form = new updater();
                        form.Show(this);
                        this.Hide();

                    }
                }
                else
                {
                    return;

                }
            }
            else
            { 
                return; 
            }
        }
        
        //Declare dinfo and have it poll for disks
        //so we can show them on the formatter.
        //Spawn a message box if polling fails.

        public void dinfo()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady == true)
                    {
                        string ko = d.VolumeLabel;
                        string dt = System.Convert.ToString(d.DriveType);
                        driveselector.Items.Add(d.Name.Remove(2));
                    }

                }
            }
            catch { MessageBox.Show("Error Fetching Drive Info", "Error"); }
        }



        //Import ProcessCaller for calling external programs
        //as seperate threads. This way we can process things
        //and still have a responsive UI.

        private ProcessCaller processCaller;

        //#########################################
        //Below is the content for the setup tab.
        //#########################################

        //On press of the run button display a dialog with 
        //yes/no options.

        private void runbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Setup this machine?", "Machine Setup", MessageBoxButtons.YesNo);

            //If we get a 'yes' then disable the run buttons on all pages
            //to prevent 'spamming' of the button and creating a 'Zerg Rush'
            //of active asynchronous processes. 
            //Check to see if the console checkbox is checked and if so
            //make the console output richtextbox visible.

            if (dialogResult == DialogResult.Yes)
            {
                sellrunbutton.Enabled = false;
                runbutton.Enabled = false;
                richTextBoxstream.Visible = consolecheck.Checked;

                //Set some strings from the various user input controls.

                string currenttime = maskedtime24.Text;
                if (maskedtime24.Text == "00:00")
                {
                    MessageBox.Show("You forgot to enter the current time.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runbutton.Enabled = true;
                    return;
                }
                string shutdowntime = maskedshutdown.Text;
                string owuserpw = pwbox.Text;
                string state = statedropdown.Text;

                //Perform some checks for invalid inputs.
                //If invalid, spawn a dialog box and bring the
                //run button back alive.
                //Return to the main form performing no further action. 

                maskedtime24.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (maskedtime24.Text == "")
                {
                    MessageBox.Show("You forgot to enter the current time.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runbutton.Enabled = true;
                    return;
                }

                maskedshutdown.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (maskedshutdown.Text == "")
                {
                    MessageBox.Show("You forgot to enter a shutdown time.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runbutton.Enabled = true;
                    return;
                }
                if (string.IsNullOrWhiteSpace(pwbox.Text))
                {
                    MessageBox.Show("You did not enter a password.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runbutton.Enabled = true;
                    return;
                }
                if (string.IsNullOrWhiteSpace(statedropdown.Text))
                {
                    MessageBox.Show("You did not select a state.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runbutton.Enabled = true;
                    return;
                }

                //If all checks pass then use ProcessCaller to call our batch file.
                //Pass the batch file four arguments based upon the strings created earlier.
                //Route the Standard Output and Standard Error of the batch file to the
                //console output richtextbox.

                this.Cursor = Cursors.AppStarting;
                processCaller = new ProcessCaller(this);
                processCaller.FileName = @"resources\setup_display\setup.bat";
                processCaller.Arguments = string.Format("{0} {1} {2} \"{3}\"", currenttime, shutdowntime, state, owuserpw);
                processCaller.StdErrReceived += new DataReceivedHandler(writeStreamInfo);
                processCaller.StdOutReceived += new DataReceivedHandler(writeStreamInfo);
                processCaller.Completed += new EventHandler(processCompletedOrCanceled);
                processCaller.Cancelled += new EventHandler(processCompletedOrCanceled);
                this.richTextBoxstream.Text = "Begin." + Environment.NewLine;

                //The following function starts a process and returns immediately,
                //thus allowing the form to stay responsive.
                //Also start the marquee progress bar.

                processCaller.Start();
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            }

            //If we get a no back from the dialog box,
            //re-enable the run button and then return to the form.

            else if (dialogResult == DialogResult.No)
            {
                runbutton.Enabled = true;
                return;
            }

        }

        //Append the incoming standard output stream from the batch file
        //onto the end of the rich text box.

        private void writeStreamInfo(object sender, DataReceivedEventArgs e)
        {
            this.richTextBoxstream.AppendText(e.Text + Environment.NewLine);
        }
        private void processCompletedOrCanceled(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        //Exit the application and all threads gracefully if
        //the Quit button is pressed.

        private void quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //#########################################
        //Below is the content for the sell tab.
        //#########################################

        //On press of the sellrun button display a dialog with 
        //yes/no options.

        private void sellrunbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sell this machine?", "Machine Sell", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)

            //If we get a 'yes' then disable the run buttons on all pages
            //to prevent 'spamming' of the button and creating a 'Zerg Rush'
            //of active asynchronous processes. 
            //Check to see if the console checkbox is checked and if so
            //make the console output richtextbox visible.
            //Perform some checks for invalid inputs.
            //If invalid, spawn a dialog box and bring the
            //run button back alive.
            //Return to the main form performing no further action.

            {
                sellrunbutton.Enabled = false;
                runbutton.Enabled = false;
                richTextBoxsellstream.Visible = sellconsolecheck.Checked;
                if (string.IsNullOrWhiteSpace(usernamebox.Text))
                {
                    MessageBox.Show("You did not input a username.",
                    "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sellrunbutton.Enabled = true;
                    return;
                }
                sellrunbutton.Enabled = false;
                runbutton.Enabled = false;

                //Set some strings from the various user input controls.
                //Check to see which radio control is active and store it's
                //text as a string value called "powerchoice".

                string username = usernamebox.Text;
                string powerchoice = "";
                if (restartradio.Checked)
                {

                    powerchoice = powerchoice + restartradio.Text;

                }
                else
                if (shutdownradio.Checked)
                {

                    powerchoice = powerchoice + shutdownradio.Text;

                }

                //If all checks pass then use ProcessCaller to call our batch file.
                //Pass the batch file four arguments based upon the strings created earlier.
                //Route the Standard Output and Standard Error of the batch file to the
                //console output richtextbox.

                this.Cursor = Cursors.AppStarting;
                processCaller = new ProcessCaller(this);
                processCaller.FileName = @"resources\sell_display\sell.bat";
                processCaller.Arguments = string.Format("{0} \"{1}\"", powerchoice, username);
                processCaller.StdErrReceived += new DataReceivedHandler(writeStreamInfosell);
                processCaller.StdOutReceived += new DataReceivedHandler(writeStreamInfosell);
                processCaller.Completed += new EventHandler(processCompletedOrCanceledsell);
                processCaller.Cancelled += new EventHandler(processCompletedOrCanceledsell);
                this.richTextBoxsellstream.Text = "Begin." + Environment.NewLine;

                //The following function starts a process and returns immediately,
                //thus allowing the form to stay responsive.
                //Also start the marquee progress bar.

                processCaller.Start();
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            }

            //If we get a no back from the dialog box,
            //re-enable the run button and then return to the form.

            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        //Append the incoming standard output stream from the batch file
        //onto the end of the rich text box.

        private void writeStreamInfosell(object sender, DataReceivedEventArgs e)
        {
            this.richTextBoxsellstream.AppendText(e.Text + Environment.NewLine);
        }
        private void processCompletedOrCanceledsell(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        //Exit the application and all threads gracefully if
        //the Quit button is pressed.

        private void sellquitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //############################################
        //Format tab content below this point.
        //############################################

        //On state change of the drive selector drop down combobox
        //grab the driveinfo we polled for at the start of the program
        //and print it to the labels 4 and 6.

        private void driveselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady == true)
                    {
                        if (driveselector.Text == d.Name.Remove(2))
                        {
                            label4.Text = d.VolumeLabel;
                            label6.Text = "Total Size: " + d.TotalSize / (1024 * 1024) + " MB\nDrive Format: " + d.DriveFormat + " \nAvailable: " + d.AvailableFreeSpace / (1024 * 1024) + " MB\n" + d.DriveType;
                        }
                    }
                }
            }
            catch { }
        }

        //Declare format and generate some strings for use within.

        private void format(string filesystem, string labelofdisk, string name)
        {

            //If the user selects the C: drive as the drive to be formatted,
            //throw an error and return to the form with no action taken.
            //Windows can handle this kind of error by itself as the C: drive
            //would obviously be locked by the OS. However, this way we can
            //display a custom error message that's maybe not quite so technical.

            if (name == "C:")
            {
                MessageBox.Show("You selected the C: Drive, bad idea.",
                    "Woa There!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formatbutton.Enabled = true;
                return;
            }

            //If the user does not select a drive letter we throw and error.

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("You did not select a drive.",
                "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formatbutton.Enabled = true;
                return;
            }

            //If the user does not input a drive label we throw a error.
            //Windows supports null drive lables but if we leave it blank
            //the batch file we build later will prompt for confirmation.
            //This will hang the batch file and parent OSIRiS process unless
            //we feed it an answer. (Coming in a future version)

            if (string.IsNullOrWhiteSpace(labelofdisk))
            {
                MessageBox.Show("You did not enter a drive name.",
                "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formatbutton.Enabled = true;
                return;
            }

            //Because of the way Windows handles formatting large FAT32 disks,
            //we call fat32formatter from RidgeCrop Consultants.
            //Because fat32formatter wants user input and provides no way to
            //override the y/n question requirment, we have to redirect it's
            //standard output to a stringbuilder. 
            //We then read the string and inject a "y" character back to the 
            //program as if a user had typed it.

            if (fat32radio.Checked == true)
            {
                System.Diagnostics.Process fat32proc = new System.Diagnostics.Process();
                fat32proc.StartInfo.FileName = @"resources\format\fat32format.exe";
                fat32proc.StartInfo.Arguments = " " + name;
                fat32proc.StartInfo.UseShellExecute = false;
                fat32proc.StartInfo.RedirectStandardOutput = true;
                fat32proc.StartInfo.RedirectStandardInput = true;
                fat32proc.StartInfo.CreateNoWindow = true;
                fat32proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                fat32proc.Start();

                //Use a StringBuilder to hold the program's output

                StringBuilder procOutput = new StringBuilder();

                //Send "y" to fat32format.exe

                fat32proc.StandardInput.WriteLine("y");
                fat32proc.WaitForExit();

                //Build a batch file for labeling the disk.

                StreamWriter r_w;
                r_w = File.CreateText(@"resources\format\format.bat");
                r_w.WriteLine("label" + " " + name + " " + labelofdisk);
                r_w.Close();

                //Call the batch file.

                System.Diagnostics.Process Proc1 = new System.Diagnostics.Process();
                Proc1.StartInfo.FileName = @"resources\format\format.bat";
                Proc1.StartInfo.UseShellExecute = false;
                Proc1.StartInfo.CreateNoWindow = true;
                Proc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Proc1.Start();
                Proc1.WaitForExit();

                //Delete the Batch File.
                //Recall the polled drive info so we can display
                //updated filesystem and name information of label 4 and 6.

                File.Delete(@"resources\format\format.bat");
                MessageBox.Show("Format Complete.",
                        "Finished.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    try
                    {
                        DriveInfo[] allDrives = DriveInfo.GetDrives();

                        foreach (DriveInfo d in allDrives)
                        {
                            if (d.IsReady == true)
                            {
                                if (driveselector.Text == d.Name.Remove(2))
                                {
                                    label4.Text = d.VolumeLabel;
                                    label6.Text = "Total Size: " + d.TotalSize / (1024 * 1024) + " MB\nDrive Format: " + d.DriveFormat + " \nAvailable: " + d.AvailableFreeSpace / (1024 * 1024) + " MB\n" + d.DriveType;
                                }
                            }
                        }
                    }
                    catch { }
                }
                formatbutton.Enabled = true;
                return;
            }

            //Standard routine for non-FAT32 disks.
            //Build a batch file to format disks.

            StreamWriter w_r;
            w_r = File.CreateText(@"resources\format\format.bat");
            w_r.WriteLine("format /y" + "/q" + "/fs:" + filesystem + " " + name);
            w_r.WriteLine("label" + " " + name + " " + labelofdisk);
            w_r.Close();

            //Call the batch file.

            System.Diagnostics.Process Proc2 = new System.Diagnostics.Process();
            Proc2.StartInfo.FileName = @"resources\format\format.bat";
            Proc2.StartInfo.UseShellExecute = false;
            Proc2.StartInfo.CreateNoWindow = true;
            Proc2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Proc2.Start();
            Proc2.WaitForExit();

            //Delete Batch File
            //Recall the polled drive info so we can display
            //updated filesystem and name information on label 4 and 6.

            File.Delete(@"resources\format\format.bat");
            MessageBox.Show("Format Complete.",
                    "Finished.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                try
                {
                    DriveInfo[] allDrives = DriveInfo.GetDrives();

                    foreach (DriveInfo d in allDrives)
                    {
                        if (d.IsReady == true)
                        {
                            if (driveselector.Text == d.Name.Remove(2))
                            {
                                label4.Text = d.VolumeLabel;
                                label6.Text = "Total Size: " + d.TotalSize / (1024 * 1024) + " MB\nDrive Format: " + d.DriveFormat + " \nAvailable: " + d.AvailableFreeSpace / (1024 * 1024) + " MB\n" + d.DriveType;
                            }
                        }
                    }
                }
                catch { }
            }
            formatbutton.Enabled = true;
            return;
        }

        //Set string values based upon radio buttons.

        private void formatbutton_Click(object sender, EventArgs e)
        {
            formatbutton.Enabled = false;
            {
                string ui = System.Environment.GetFolderPath(Environment.SpecialFolder.System);
                {
                    string fs = "NTFS";
                    string iop = label6.Text;
                    if (fat32radio.Checked == true) { fs = "FAT32"; }
                    if (exFATradio.Checked == true) { fs = "exFAT"; }
                    format(fs, textBox1.Text, driveselector.Text);
                }
            }
        }

        //Exit the application and all threads gracefully if
        //the Quit button is pressed.

        private void formatbuttonquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Open the default browser to the on-disk help files.

        private void helpbuttonsell_Click(object sender, EventArgs e)
        {
            string appPath = Assembly.GetEntryAssembly().Location;
            string filename = Path.Combine(Path.GetDirectoryName(appPath), @"resources\help\OSIRiS Help.html");
            Process.Start(filename);
        }

        private void helpbuttonformat_Click(object sender, EventArgs e)
        {
            string appPath = Assembly.GetEntryAssembly().Location;
            string filename = Path.Combine(Path.GetDirectoryName(appPath), @"resources\help\OSIRiS Help.html");
            Process.Start(filename);
        }

        private void helpbuttonsetup_Click(object sender, EventArgs e)
        {
            string appPath = Assembly.GetEntryAssembly().Location;
            string filename = Path.Combine(Path.GetDirectoryName(appPath), @"resources\help\OSIRiS Help.html");
            Process.Start(filename);
        }

       

        

                }
            }

    

