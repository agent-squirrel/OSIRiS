namespace OSIRiS
{
    partial class OSIRiSmainwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.setuppage = new System.Windows.Forms.TabPage();
            this.consolecheck = new System.Windows.Forms.CheckBox();
            this.richTextBoxstream = new System.Windows.Forms.RichTextBox();
            this.maskedshutdown = new System.Windows.Forms.MaskedTextBox();
            this.maskedtime24 = new System.Windows.Forms.MaskedTextBox();
            this.timelable = new System.Windows.Forms.Label();
            this.quitbutton = new System.Windows.Forms.Button();
            this.runbutton = new System.Windows.Forms.Button();
            this.statedropdown = new System.Windows.Forms.ComboBox();
            this.statelabel = new System.Windows.Forms.Label();
            this.userpwlabel = new System.Windows.Forms.Label();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.shutdownlabel = new System.Windows.Forms.Label();
            this.sellpage = new System.Windows.Forms.TabPage();
            this.sellconsolecheck = new System.Windows.Forms.CheckBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.restartradio = new System.Windows.Forms.RadioButton();
            this.shutdownradio = new System.Windows.Forms.RadioButton();
            this.sellquitbutton = new System.Windows.Forms.Button();
            this.sellrunbutton = new System.Windows.Forms.Button();
            this.richTextBoxsellstream = new System.Windows.Forms.RichTextBox();
            this.sellradiogroup = new System.Windows.Forms.GroupBox();
            this.formattab = new System.Windows.Forms.TabPage();
            this.formatbuttonquit = new System.Windows.Forms.Button();
            this.formatbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drivenamelabel = new System.Windows.Forms.Label();
            this.exFATradio = new System.Windows.Forms.RadioButton();
            this.NTFSradio = new System.Windows.Forms.RadioButton();
            this.fat32radio = new System.Windows.Forms.RadioButton();
            this.fslabel = new System.Windows.Forms.Label();
            this.drivelabel = new System.Windows.Forms.Label();
            this.driveselector = new System.Windows.Forms.ComboBox();
            this.driveselected = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltipcontrol = new System.Windows.Forms.ToolTip(this.components);
            this.helpbuttonsetup = new System.Windows.Forms.Button();
            this.helpbuttonsell = new System.Windows.Forms.Button();
            this.helpbuttonformat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.setuppage.SuspendLayout();
            this.sellpage.SuspendLayout();
            this.formattab.SuspendLayout();
            this.driveselected.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.setuppage);
            this.tabControl1.Controls.Add(this.sellpage);
            this.tabControl1.Controls.Add(this.formattab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(430, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // setuppage
            // 
            this.setuppage.BackColor = System.Drawing.Color.White;
            this.setuppage.Controls.Add(this.helpbuttonsetup);
            this.setuppage.Controls.Add(this.consolecheck);
            this.setuppage.Controls.Add(this.richTextBoxstream);
            this.setuppage.Controls.Add(this.maskedshutdown);
            this.setuppage.Controls.Add(this.maskedtime24);
            this.setuppage.Controls.Add(this.timelable);
            this.setuppage.Controls.Add(this.quitbutton);
            this.setuppage.Controls.Add(this.runbutton);
            this.setuppage.Controls.Add(this.statedropdown);
            this.setuppage.Controls.Add(this.statelabel);
            this.setuppage.Controls.Add(this.userpwlabel);
            this.setuppage.Controls.Add(this.pwbox);
            this.setuppage.Controls.Add(this.shutdownlabel);
            this.setuppage.Location = new System.Drawing.Point(4, 27);
            this.setuppage.Name = "setuppage";
            this.setuppage.Padding = new System.Windows.Forms.Padding(3);
            this.setuppage.Size = new System.Drawing.Size(422, 472);
            this.setuppage.TabIndex = 0;
            this.setuppage.Text = "Setup";
            this.setuppage.ToolTipText = "Use this tab to setup a new display computer.";
            // 
            // consolecheck
            // 
            this.consolecheck.AutoSize = true;
            this.consolecheck.Location = new System.Drawing.Point(8, 444);
            this.consolecheck.Name = "consolecheck";
            this.consolecheck.Size = new System.Drawing.Size(177, 22);
            this.consolecheck.TabIndex = 5;
            this.consolecheck.Text = "Show Console Output";
            this.tooltipcontrol.SetToolTip(this.consolecheck, "Check this box if you want to see the setup messages.");
            this.consolecheck.UseVisualStyleBackColor = true;
            // 
            // richTextBoxstream
            // 
            this.richTextBoxstream.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxstream.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxstream.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxstream.HideSelection = false;
            this.richTextBoxstream.Location = new System.Drawing.Point(0, 162);
            this.richTextBoxstream.Name = "richTextBoxstream";
            this.richTextBoxstream.ReadOnly = true;
            this.richTextBoxstream.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxstream.Size = new System.Drawing.Size(419, 277);
            this.richTextBoxstream.TabIndex = 15;
            this.richTextBoxstream.Text = "";
            this.tooltipcontrol.SetToolTip(this.richTextBoxstream, "Console output box.");
            // 
            // maskedshutdown
            // 
            this.maskedshutdown.Location = new System.Drawing.Point(244, 62);
            this.maskedshutdown.Mask = "00:00";
            this.maskedshutdown.Name = "maskedshutdown";
            this.maskedshutdown.PromptChar = ' ';
            this.maskedshutdown.RejectInputOnFirstFailure = true;
            this.maskedshutdown.Size = new System.Drawing.Size(46, 26);
            this.maskedshutdown.TabIndex = 2;
            this.maskedshutdown.Text = "2100";
            this.tooltipcontrol.SetToolTip(this.maskedshutdown, "Input your desired automatic shutdown time here in 24 hour format.");
            this.maskedshutdown.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtime24
            // 
            this.maskedtime24.Location = new System.Drawing.Point(244, 28);
            this.maskedtime24.Mask = "00:00";
            this.maskedtime24.Name = "maskedtime24";
            this.maskedtime24.PromptChar = ' ';
            this.maskedtime24.RejectInputOnFirstFailure = true;
            this.maskedtime24.Size = new System.Drawing.Size(46, 26);
            this.maskedtime24.TabIndex = 1;
            this.maskedtime24.Text = "0000";
            this.tooltipcontrol.SetToolTip(this.maskedtime24, "Input the current time here in 24 hour format.");
            this.maskedtime24.ValidatingType = typeof(System.DateTime);
            // 
            // timelable
            // 
            this.timelable.AutoSize = true;
            this.timelable.Location = new System.Drawing.Point(92, 31);
            this.timelable.Name = "timelable";
            this.timelable.Size = new System.Drawing.Size(146, 18);
            this.timelable.TabIndex = 12;
            this.timelable.Text = "Current Time (24hr):";
            this.tooltipcontrol.SetToolTip(this.timelable, "Input the current time here in 24 hour format.");
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(344, 445);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(75, 23);
            this.quitbutton.TabIndex = 7;
            this.quitbutton.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.quitbutton, "Click here to close OSIRiS.");
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // runbutton
            // 
            this.runbutton.Location = new System.Drawing.Point(263, 445);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(75, 23);
            this.runbutton.TabIndex = 6;
            this.runbutton.Text = "Run";
            this.tooltipcontrol.SetToolTip(this.runbutton, "Click here when ready.");
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // statedropdown
            // 
            this.statedropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statedropdown.FormattingEnabled = true;
            this.statedropdown.Items.AddRange(new object[] {
            "VIC",
            "TAS",
            "QLD",
            "ACT",
            "SA",
            "WA",
            "NT"});
            this.statedropdown.Location = new System.Drawing.Point(147, 128);
            this.statedropdown.Name = "statedropdown";
            this.statedropdown.Size = new System.Drawing.Size(121, 26);
            this.statedropdown.TabIndex = 4;
            this.tooltipcontrol.SetToolTip(this.statedropdown, "Choose the state your store resides in here. ");
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(92, 131);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(49, 18);
            this.statelabel.TabIndex = 4;
            this.statelabel.Text = "State:\r\n";
            this.tooltipcontrol.SetToolTip(this.statelabel, "Choose the state your store resides in here. ");
            // 
            // userpwlabel
            // 
            this.userpwlabel.AutoSize = true;
            this.userpwlabel.Location = new System.Drawing.Point(92, 99);
            this.userpwlabel.Name = "userpwlabel";
            this.userpwlabel.Size = new System.Drawing.Size(150, 18);
            this.userpwlabel.TabIndex = 3;
            this.userpwlabel.Text = "OW User Password:";
            this.tooltipcontrol.SetToolTip(this.userpwlabel, "Input your stores display password here.");
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(248, 96);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(100, 26);
            this.pwbox.TabIndex = 3;
            this.pwbox.Text = "happy456";
            this.tooltipcontrol.SetToolTip(this.pwbox, "Input your stores display password here.");
            // 
            // shutdownlabel
            // 
            this.shutdownlabel.AutoSize = true;
            this.shutdownlabel.Location = new System.Drawing.Point(92, 65);
            this.shutdownlabel.Name = "shutdownlabel";
            this.shutdownlabel.Size = new System.Drawing.Size(143, 18);
            this.shutdownlabel.TabIndex = 0;
            this.shutdownlabel.Text = "Shutdown At (24hr):";
            this.tooltipcontrol.SetToolTip(this.shutdownlabel, "Input your desired automatic shutdown time here in 24 hour format.");
            // 
            // sellpage
            // 
            this.sellpage.BackColor = System.Drawing.Color.White;
            this.sellpage.Controls.Add(this.helpbuttonsell);
            this.sellpage.Controls.Add(this.sellconsolecheck);
            this.sellpage.Controls.Add(this.userlabel);
            this.sellpage.Controls.Add(this.usernamebox);
            this.sellpage.Controls.Add(this.restartradio);
            this.sellpage.Controls.Add(this.shutdownradio);
            this.sellpage.Controls.Add(this.sellquitbutton);
            this.sellpage.Controls.Add(this.sellrunbutton);
            this.sellpage.Controls.Add(this.richTextBoxsellstream);
            this.sellpage.Controls.Add(this.sellradiogroup);
            this.sellpage.Location = new System.Drawing.Point(4, 27);
            this.sellpage.Name = "sellpage";
            this.sellpage.Padding = new System.Windows.Forms.Padding(3);
            this.sellpage.Size = new System.Drawing.Size(422, 472);
            this.sellpage.TabIndex = 1;
            this.sellpage.Text = "Sell";
            this.sellpage.ToolTipText = "Use this tab to sell a display computer.";
            // 
            // sellconsolecheck
            // 
            this.sellconsolecheck.AutoSize = true;
            this.sellconsolecheck.Location = new System.Drawing.Point(8, 444);
            this.sellconsolecheck.Name = "sellconsolecheck";
            this.sellconsolecheck.Size = new System.Drawing.Size(177, 22);
            this.sellconsolecheck.TabIndex = 6;
            this.sellconsolecheck.Text = "Show Console Output";
            this.tooltipcontrol.SetToolTip(this.sellconsolecheck, "Check this box if you want to see the sell messages.");
            this.sellconsolecheck.UseVisualStyleBackColor = true;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(129, 95);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(126, 18);
            this.userlabel.TabIndex = 25;
            this.userlabel.Text = "New User Name:";
            this.tooltipcontrol.SetToolTip(this.userlabel, "Input the new user account name for the customer.");
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(132, 119);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 26);
            this.usernamebox.TabIndex = 24;
            this.usernamebox.Text = "User";
            this.tooltipcontrol.SetToolTip(this.usernamebox, "w user account name for the customer.");
            // 
            // restartradio
            // 
            this.restartradio.AutoSize = true;
            this.restartradio.Checked = true;
            this.restartradio.Location = new System.Drawing.Point(132, 62);
            this.restartradio.Name = "restartradio";
            this.restartradio.Size = new System.Drawing.Size(76, 22);
            this.restartradio.TabIndex = 23;
            this.restartradio.TabStop = true;
            this.restartradio.Text = "Restart";
            this.tooltipcontrol.SetToolTip(this.restartradio, "Choose what the computer will do once the sell routine is complete.");
            this.restartradio.UseVisualStyleBackColor = true;
            // 
            // shutdownradio
            // 
            this.shutdownradio.AutoSize = true;
            this.shutdownradio.Location = new System.Drawing.Point(132, 34);
            this.shutdownradio.Name = "shutdownradio";
            this.shutdownradio.Size = new System.Drawing.Size(94, 22);
            this.shutdownradio.TabIndex = 22;
            this.shutdownradio.TabStop = true;
            this.shutdownradio.Text = "Shutdown";
            this.tooltipcontrol.SetToolTip(this.shutdownradio, "Choose what the computer will do once the sell routine is complete.");
            this.shutdownradio.UseVisualStyleBackColor = true;
            // 
            // sellquitbutton
            // 
            this.sellquitbutton.Location = new System.Drawing.Point(344, 445);
            this.sellquitbutton.Name = "sellquitbutton";
            this.sellquitbutton.Size = new System.Drawing.Size(75, 23);
            this.sellquitbutton.TabIndex = 18;
            this.sellquitbutton.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.sellquitbutton, "Click here to close OSIRiS.");
            this.sellquitbutton.UseVisualStyleBackColor = true;
            this.sellquitbutton.Click += new System.EventHandler(this.sellquitbutton_Click);
            // 
            // sellrunbutton
            // 
            this.sellrunbutton.Location = new System.Drawing.Point(263, 445);
            this.sellrunbutton.Name = "sellrunbutton";
            this.sellrunbutton.Size = new System.Drawing.Size(75, 23);
            this.sellrunbutton.TabIndex = 17;
            this.sellrunbutton.Text = "Run";
            this.tooltipcontrol.SetToolTip(this.sellrunbutton, "Click here when ready.");
            this.sellrunbutton.UseVisualStyleBackColor = true;
            this.sellrunbutton.Click += new System.EventHandler(this.sellrunbutton_Click);
            // 
            // richTextBoxsellstream
            // 
            this.richTextBoxsellstream.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxsellstream.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxsellstream.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxsellstream.HideSelection = false;
            this.richTextBoxsellstream.Location = new System.Drawing.Point(0, 162);
            this.richTextBoxsellstream.Name = "richTextBoxsellstream";
            this.richTextBoxsellstream.ReadOnly = true;
            this.richTextBoxsellstream.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxsellstream.Size = new System.Drawing.Size(419, 277);
            this.richTextBoxsellstream.TabIndex = 16;
            this.richTextBoxsellstream.Text = "";
            this.tooltipcontrol.SetToolTip(this.richTextBoxsellstream, "Console output box.");
            // 
            // sellradiogroup
            // 
            this.sellradiogroup.Location = new System.Drawing.Point(87, 6);
            this.sellradiogroup.Name = "sellradiogroup";
            this.sellradiogroup.Size = new System.Drawing.Size(200, 86);
            this.sellradiogroup.TabIndex = 26;
            this.sellradiogroup.TabStop = false;
            this.sellradiogroup.Text = "Upon Completion";
            this.tooltipcontrol.SetToolTip(this.sellradiogroup, "Choose what the computer will do once the sell routine is complete.");
            // 
            // formattab
            // 
            this.formattab.Controls.Add(this.helpbuttonformat);
            this.formattab.Controls.Add(this.formatbuttonquit);
            this.formattab.Controls.Add(this.formatbutton);
            this.formattab.Controls.Add(this.textBox1);
            this.formattab.Controls.Add(this.drivenamelabel);
            this.formattab.Controls.Add(this.exFATradio);
            this.formattab.Controls.Add(this.NTFSradio);
            this.formattab.Controls.Add(this.fat32radio);
            this.formattab.Controls.Add(this.fslabel);
            this.formattab.Controls.Add(this.drivelabel);
            this.formattab.Controls.Add(this.driveselector);
            this.formattab.Controls.Add(this.driveselected);
            this.formattab.Location = new System.Drawing.Point(4, 27);
            this.formattab.Name = "formattab";
            this.formattab.Padding = new System.Windows.Forms.Padding(3);
            this.formattab.Size = new System.Drawing.Size(422, 472);
            this.formattab.TabIndex = 2;
            this.formattab.Text = "Formatter";
            this.formattab.ToolTipText = "Use this tab to format an external drive for a customer.";
            this.formattab.UseVisualStyleBackColor = true;
            // 
            // formatbuttonquit
            // 
            this.formatbuttonquit.Location = new System.Drawing.Point(344, 445);
            this.formatbuttonquit.Name = "formatbuttonquit";
            this.formatbuttonquit.Size = new System.Drawing.Size(75, 23);
            this.formatbuttonquit.TabIndex = 15;
            this.formatbuttonquit.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.formatbuttonquit, "Click here to close OSIRiS.");
            this.formatbuttonquit.UseVisualStyleBackColor = true;
            this.formatbuttonquit.Click += new System.EventHandler(this.formatbuttonquit_Click);
            // 
            // formatbutton
            // 
            this.formatbutton.Location = new System.Drawing.Point(138, 287);
            this.formatbutton.Name = "formatbutton";
            this.formatbutton.Size = new System.Drawing.Size(75, 23);
            this.formatbutton.TabIndex = 8;
            this.formatbutton.Text = "Format";
            this.tooltipcontrol.SetToolTip(this.formatbutton, "Click here when ready.");
            this.formatbutton.UseVisualStyleBackColor = true;
            this.formatbutton.Click += new System.EventHandler(this.formatbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            this.tooltipcontrol.SetToolTip(this.textBox1, "Choose a name for the newly formatted drive here.");
            // 
            // drivenamelabel
            // 
            this.drivenamelabel.AutoSize = true;
            this.drivenamelabel.Location = new System.Drawing.Point(82, 244);
            this.drivenamelabel.Name = "drivenamelabel";
            this.drivenamelabel.Size = new System.Drawing.Size(89, 18);
            this.drivenamelabel.TabIndex = 6;
            this.drivenamelabel.Text = "New Name:";
            this.tooltipcontrol.SetToolTip(this.drivenamelabel, "Choose a name for the newly formatted drive here.");
            // 
            // exFATradio
            // 
            this.exFATradio.AutoSize = true;
            this.exFATradio.Location = new System.Drawing.Point(329, 211);
            this.exFATradio.Name = "exFATradio";
            this.exFATradio.Size = new System.Drawing.Size(70, 22);
            this.exFATradio.TabIndex = 5;
            this.exFATradio.Text = "exFAT";
            this.tooltipcontrol.SetToolTip(this.exFATradio, "exFAT. Read/Write on most systems, use in joint Windows/Mac environments.");
            this.exFATradio.UseVisualStyleBackColor = true;
            // 
            // NTFSradio
            // 
            this.NTFSradio.AutoSize = true;
            this.NTFSradio.Location = new System.Drawing.Point(256, 211);
            this.NTFSradio.Name = "NTFSradio";
            this.NTFSradio.Size = new System.Drawing.Size(67, 22);
            this.NTFSradio.TabIndex = 4;
            this.NTFSradio.Text = "NTFS";
            this.tooltipcontrol.SetToolTip(this.NTFSradio, "NTFS. Can only be read by Macs, not written to. Best used in Windows only environ" +
        "ments. ");
            this.NTFSradio.UseVisualStyleBackColor = true;
            // 
            // fat32radio
            // 
            this.fat32radio.AutoSize = true;
            this.fat32radio.Checked = true;
            this.fat32radio.Location = new System.Drawing.Point(178, 211);
            this.fat32radio.Name = "fat32radio";
            this.fat32radio.Size = new System.Drawing.Size(72, 22);
            this.fat32radio.TabIndex = 3;
            this.fat32radio.TabStop = true;
            this.fat32radio.Text = "FAT32";
            this.tooltipcontrol.SetToolTip(this.fat32radio, "FAT32. File size limitation of 4gb, use for games consoles and set-top boxes.");
            this.fat32radio.UseVisualStyleBackColor = true;
            // 
            // fslabel
            // 
            this.fslabel.AutoSize = true;
            this.fslabel.Location = new System.Drawing.Point(82, 213);
            this.fslabel.Name = "fslabel";
            this.fslabel.Size = new System.Drawing.Size(90, 18);
            this.fslabel.TabIndex = 2;
            this.fslabel.Text = "FileSystem:";
            this.tooltipcontrol.SetToolTip(this.fslabel, "Choose a file system here.");
            // 
            // drivelabel
            // 
            this.drivelabel.AutoSize = true;
            this.drivelabel.Location = new System.Drawing.Point(82, 178);
            this.drivelabel.Name = "drivelabel";
            this.drivelabel.Size = new System.Drawing.Size(49, 18);
            this.drivelabel.TabIndex = 1;
            this.drivelabel.Text = "Drive:";
            this.tooltipcontrol.SetToolTip(this.drivelabel, "Choose a drive to format here.");
            // 
            // driveselector
            // 
            this.driveselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveselector.FormattingEnabled = true;
            this.driveselector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.driveselector.Location = new System.Drawing.Point(138, 175);
            this.driveselector.Name = "driveselector";
            this.driveselector.Size = new System.Drawing.Size(121, 26);
            this.driveselector.TabIndex = 0;
            this.tooltipcontrol.SetToolTip(this.driveselector, "Choose a drive to format here.");
            this.driveselector.SelectedIndexChanged += new System.EventHandler(this.driveselector_SelectedIndexChanged);
            // 
            // driveselected
            // 
            this.driveselected.Controls.Add(this.label6);
            this.driveselected.Controls.Add(this.label4);
            this.driveselected.Location = new System.Drawing.Point(85, 10);
            this.driveselected.Name = "driveselected";
            this.driveselected.Size = new System.Drawing.Size(200, 151);
            this.driveselected.TabIndex = 14;
            this.driveselected.TabStop = false;
            this.driveselected.Text = "Selected Drive Info";
            this.tooltipcontrol.SetToolTip(this.driveselected, "Infomation about the selected drive.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 13;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(426, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(420, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.ToolTipText = "Working...";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // helpbuttonsetup
            // 
            this.helpbuttonsetup.Location = new System.Drawing.Point(362, 6);
            this.helpbuttonsetup.Name = "helpbuttonsetup";
            this.helpbuttonsetup.Size = new System.Drawing.Size(54, 26);
            this.helpbuttonsetup.TabIndex = 16;
            this.helpbuttonsetup.Text = "Help";
            this.helpbuttonsetup.UseVisualStyleBackColor = true;
            this.helpbuttonsetup.Click += new System.EventHandler(this.helpbuttonsetup_Click);
            // 
            // helpbuttonsell
            // 
            this.helpbuttonsell.Location = new System.Drawing.Point(362, 6);
            this.helpbuttonsell.Name = "helpbuttonsell";
            this.helpbuttonsell.Size = new System.Drawing.Size(54, 26);
            this.helpbuttonsell.TabIndex = 27;
            this.helpbuttonsell.Text = "Help";
            this.helpbuttonsell.UseVisualStyleBackColor = true;
            this.helpbuttonsell.Click += new System.EventHandler(this.helpbuttonsell_Click);
            // 
            // helpbuttonformat
            // 
            this.helpbuttonformat.Location = new System.Drawing.Point(362, 6);
            this.helpbuttonformat.Name = "helpbuttonformat";
            this.helpbuttonformat.Size = new System.Drawing.Size(54, 26);
            this.helpbuttonformat.TabIndex = 17;
            this.helpbuttonformat.Text = "Help";
            this.helpbuttonformat.UseVisualStyleBackColor = true;
            this.helpbuttonformat.Click += new System.EventHandler(this.helpbuttonformat_Click);
            // 
            // OSIRiSmainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OSIRiSmainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSIRiS";
            this.tabControl1.ResumeLayout(false);
            this.setuppage.ResumeLayout(false);
            this.setuppage.PerformLayout();
            this.sellpage.ResumeLayout(false);
            this.sellpage.PerformLayout();
            this.formattab.ResumeLayout(false);
            this.formattab.PerformLayout();
            this.driveselected.ResumeLayout(false);
            this.driveselected.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage setuppage;
        private System.Windows.Forms.TabPage sellpage;
        private System.Windows.Forms.Label userpwlabel;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.ComboBox statedropdown;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Button runbutton;
        private System.Windows.Forms.Label timelable;
        private System.Windows.Forms.MaskedTextBox maskedshutdown;
        private System.Windows.Forms.RichTextBox richTextBoxstream;
        private System.Windows.Forms.MaskedTextBox maskedtime24;
        private System.Windows.Forms.CheckBox consolecheck;
        private System.Windows.Forms.Label shutdownlabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button sellquitbutton;
        private System.Windows.Forms.Button sellrunbutton;
        private System.Windows.Forms.RichTextBox richTextBoxsellstream;
        private System.Windows.Forms.RadioButton restartradio;
        private System.Windows.Forms.RadioButton shutdownradio;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.GroupBox sellradiogroup;
        private System.Windows.Forms.CheckBox sellconsolecheck;
        private System.Windows.Forms.TabPage formattab;
        private System.Windows.Forms.ComboBox driveselector;
        private System.Windows.Forms.Label drivelabel;
        private System.Windows.Forms.Label fslabel;
        private System.Windows.Forms.RadioButton exFATradio;
        private System.Windows.Forms.RadioButton NTFSradio;
        private System.Windows.Forms.RadioButton fat32radio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label drivenamelabel;
        private System.Windows.Forms.Button formatbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox driveselected;
        private System.Windows.Forms.ToolTip tooltipcontrol;
        private System.Windows.Forms.Button formatbuttonquit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button helpbuttonsetup;
        private System.Windows.Forms.Button helpbuttonsell;
        private System.Windows.Forms.Button helpbuttonformat;
    }
}

