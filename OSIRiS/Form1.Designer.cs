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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSIRiSmainwindow));
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.setuppage = new System.Windows.Forms.TabPage();
            this.progresslabel = new System.Windows.Forms.Label();
            this.shutdowntime = new System.Windows.Forms.DateTimePicker();
            this.helpsetupbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.currenttime = new System.Windows.Forms.DateTimePicker();
            this.clearancecheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.timelabel = new MaterialSkin.Controls.MaterialLabel();
            this.quitbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.runbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statedropdown = new System.Windows.Forms.ComboBox();
            this.statelabel = new MaterialSkin.Controls.MaterialLabel();
            this.userpwlabel = new MaterialSkin.Controls.MaterialLabel();
            this.pwbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.shutdownlabel = new MaterialSkin.Controls.MaterialLabel();
            this.sellpage = new System.Windows.Forms.TabPage();
            this.progresslabelsell = new System.Windows.Forms.Label();
            this.helpsellbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.userlabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.restartradio = new MaterialSkin.Controls.MaterialRadioButton();
            this.shutdownradio = new MaterialSkin.Controls.MaterialRadioButton();
            this.sellquitbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sellrunbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sellradiogroup = new System.Windows.Forms.GroupBox();
            this.formattab = new System.Windows.Forms.TabPage();
            this.formatlabel = new MaterialSkin.Controls.MaterialLabel();
            this.refreshbutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.helpformatbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.formatbuttonquit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.formatbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drivenamelabel = new MaterialSkin.Controls.MaterialLabel();
            this.exFATradio = new MaterialSkin.Controls.MaterialRadioButton();
            this.NTFSradio = new MaterialSkin.Controls.MaterialRadioButton();
            this.fat32radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.fslabel = new MaterialSkin.Controls.MaterialLabel();
            this.drivelabel = new MaterialSkin.Controls.MaterialLabel();
            this.driveselector = new System.Windows.Forms.ComboBox();
            this.driveselected = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tooltipcontrol = new System.Windows.Forms.ToolTip(this.components);
            this.tabselector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl1.SuspendLayout();
            this.setuppage.SuspendLayout();
            this.sellpage.SuspendLayout();
            this.formattab.SuspendLayout();
            this.driveselected.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.setuppage);
            this.tabControl1.Controls.Add(this.sellpage);
            this.tabControl1.Controls.Add(this.formattab);
            this.tabControl1.Depth = 0;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 115);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(426, 388);
            this.tabControl1.TabIndex = 2;
            // 
            // setuppage
            // 
            this.setuppage.BackColor = System.Drawing.Color.White;
            this.setuppage.Controls.Add(this.progresslabel);
            this.setuppage.Controls.Add(this.shutdowntime);
            this.setuppage.Controls.Add(this.helpsetupbutton);
            this.setuppage.Controls.Add(this.currenttime);
            this.setuppage.Controls.Add(this.clearancecheckbox);
            this.setuppage.Controls.Add(this.timelabel);
            this.setuppage.Controls.Add(this.quitbutton);
            this.setuppage.Controls.Add(this.runbutton);
            this.setuppage.Controls.Add(this.statedropdown);
            this.setuppage.Controls.Add(this.statelabel);
            this.setuppage.Controls.Add(this.userpwlabel);
            this.setuppage.Controls.Add(this.pwbox);
            this.setuppage.Controls.Add(this.shutdownlabel);
            this.setuppage.Location = new System.Drawing.Point(4, 29);
            this.setuppage.Name = "setuppage";
            this.setuppage.Padding = new System.Windows.Forms.Padding(3);
            this.setuppage.Size = new System.Drawing.Size(418, 355);
            this.setuppage.TabIndex = 0;
            this.setuppage.Text = "Setup";
            this.setuppage.ToolTipText = "Use this tab to setup a new display computer.";
            // 
            // progresslabel
            // 
            this.progresslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresslabel.Location = new System.Drawing.Point(3, 226);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(412, 23);
            this.progresslabel.TabIndex = 20;
            this.progresslabel.Text = "Welcome To OSIRiS!";
            this.progresslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltipcontrol.SetToolTip(this.progresslabel, "Welcome!");
            // 
            // shutdowntime
            // 
            this.shutdowntime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.shutdowntime.Location = new System.Drawing.Point(240, 38);
            this.shutdowntime.Name = "shutdowntime";
            this.shutdowntime.ShowUpDown = true;
            this.shutdowntime.Size = new System.Drawing.Size(119, 27);
            this.shutdowntime.TabIndex = 4;
            this.tooltipcontrol.SetToolTip(this.shutdowntime, "Input your desired shutdown time here, take care with AM/PM.");
            this.shutdowntime.Value = new System.DateTime(2015, 9, 22, 1, 0, 0, 0);
            // 
            // helpsetupbutton
            // 
            this.helpsetupbutton.Depth = 0;
            this.helpsetupbutton.Location = new System.Drawing.Point(175, 352);
            this.helpsetupbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpsetupbutton.Name = "helpsetupbutton";
            this.helpsetupbutton.Primary = true;
            this.helpsetupbutton.Size = new System.Drawing.Size(75, 23);
            this.helpsetupbutton.TabIndex = 8;
            this.helpsetupbutton.Text = "Help";
            this.tooltipcontrol.SetToolTip(this.helpsetupbutton, "Click here to open the manual.");
            this.helpsetupbutton.UseVisualStyleBackColor = true;
            this.helpsetupbutton.Click += new System.EventHandler(this.helpsetupbutton_Click);
            // 
            // currenttime
            // 
            this.currenttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.currenttime.Location = new System.Drawing.Point(240, 7);
            this.currenttime.Name = "currenttime";
            this.currenttime.ShowUpDown = true;
            this.currenttime.Size = new System.Drawing.Size(119, 27);
            this.currenttime.TabIndex = 3;
            this.tooltipcontrol.SetToolTip(this.currenttime, "Input the current time here, take care with AM/PM.");
            this.currenttime.Value = new System.DateTime(2015, 9, 22, 1, 0, 0, 0);
            // 
            // clearancecheckbox
            // 
            this.clearancecheckbox.AutoSize = true;
            this.clearancecheckbox.Depth = 0;
            this.clearancecheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.clearancecheckbox.Location = new System.Drawing.Point(149, 139);
            this.clearancecheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.clearancecheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clearancecheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearancecheckbox.Name = "clearancecheckbox";
            this.clearancecheckbox.Ripple = true;
            this.clearancecheckbox.Size = new System.Drawing.Size(121, 30);
            this.clearancecheckbox.TabIndex = 7;
            this.clearancecheckbox.Text = "Clearance S&D";
            this.tooltipcontrol.SetToolTip(this.clearancecheckbox, "Check this box if this machine is a clearance model or Soiled and Damaged.");
            this.clearancecheckbox.UseVisualStyleBackColor = true;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Depth = 0;
            this.timelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timelabel.Location = new System.Drawing.Point(134, 13);
            this.timelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(100, 19);
            this.timelabel.TabIndex = 12;
            this.timelabel.Text = "Current Time:";
            this.tooltipcontrol.SetToolTip(this.timelabel, "Input the current time here, take care with AM/PM.");
            // 
            // quitbutton
            // 
            this.quitbutton.Depth = 0;
            this.quitbutton.Location = new System.Drawing.Point(337, 352);
            this.quitbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Primary = true;
            this.quitbutton.Size = new System.Drawing.Size(75, 23);
            this.quitbutton.TabIndex = 10;
            this.quitbutton.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.quitbutton, "Click here to close OSIRiS.");
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // runbutton
            // 
            this.runbutton.Depth = 0;
            this.runbutton.Location = new System.Drawing.Point(256, 352);
            this.runbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.runbutton.Name = "runbutton";
            this.runbutton.Primary = true;
            this.runbutton.Size = new System.Drawing.Size(75, 23);
            this.runbutton.TabIndex = 9;
            this.runbutton.Text = "Run";
            this.tooltipcontrol.SetToolTip(this.runbutton, "Click here when ready.");
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // statedropdown
            // 
            this.statedropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statedropdown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statedropdown.FormattingEnabled = true;
            this.statedropdown.Items.AddRange(new object[] {
            "VIC",
            "TAS",
            "QLD",
            "ACT",
            "SA",
            "WA",
            "NT"});
            this.statedropdown.Location = new System.Drawing.Point(240, 70);
            this.statedropdown.Name = "statedropdown";
            this.statedropdown.Size = new System.Drawing.Size(121, 28);
            this.statedropdown.TabIndex = 5;
            this.tooltipcontrol.SetToolTip(this.statedropdown, "Choose the state your store resides in here. ");
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Depth = 0;
            this.statelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.statelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statelabel.Location = new System.Drawing.Point(186, 73);
            this.statelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(48, 19);
            this.statelabel.TabIndex = 4;
            this.statelabel.Text = "State:\r\n";
            this.tooltipcontrol.SetToolTip(this.statelabel, "Choose the state your store resides in here. ");
            // 
            // userpwlabel
            // 
            this.userpwlabel.AutoSize = true;
            this.userpwlabel.Depth = 0;
            this.userpwlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.userpwlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userpwlabel.Location = new System.Drawing.Point(70, 102);
            this.userpwlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userpwlabel.Name = "userpwlabel";
            this.userpwlabel.Size = new System.Drawing.Size(164, 19);
            this.userpwlabel.TabIndex = 3;
            this.userpwlabel.Text = "Officeworks Password:";
            this.tooltipcontrol.SetToolTip(this.userpwlabel, "Input your stores display password here.");
            // 
            // pwbox
            // 
            this.pwbox.Depth = 0;
            this.pwbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwbox.Hint = "";
            this.pwbox.Location = new System.Drawing.Point(240, 102);
            this.pwbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '\0';
            this.pwbox.SelectedText = "";
            this.pwbox.SelectionLength = 0;
            this.pwbox.SelectionStart = 0;
            this.pwbox.Size = new System.Drawing.Size(100, 23);
            this.pwbox.TabIndex = 6;
            this.pwbox.Text = "happy456";
            this.tooltipcontrol.SetToolTip(this.pwbox, "Input your stores display password here.");
            this.pwbox.UseSystemPasswordChar = false;
            // 
            // shutdownlabel
            // 
            this.shutdownlabel.AutoSize = true;
            this.shutdownlabel.Depth = 0;
            this.shutdownlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.shutdownlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shutdownlabel.Location = new System.Drawing.Point(165, 44);
            this.shutdownlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.shutdownlabel.Name = "shutdownlabel";
            this.shutdownlabel.Size = new System.Drawing.Size(69, 19);
            this.shutdownlabel.TabIndex = 0;
            this.shutdownlabel.Text = "Sleep At:";
            this.tooltipcontrol.SetToolTip(this.shutdownlabel, "Input your desired shutdown time here, take care with AM/PM.");
            // 
            // sellpage
            // 
            this.sellpage.BackColor = System.Drawing.Color.White;
            this.sellpage.Controls.Add(this.progresslabelsell);
            this.sellpage.Controls.Add(this.helpsellbutton);
            this.sellpage.Controls.Add(this.userlabel);
            this.sellpage.Controls.Add(this.usernamebox);
            this.sellpage.Controls.Add(this.restartradio);
            this.sellpage.Controls.Add(this.shutdownradio);
            this.sellpage.Controls.Add(this.sellquitbutton);
            this.sellpage.Controls.Add(this.sellrunbutton);
            this.sellpage.Controls.Add(this.sellradiogroup);
            this.sellpage.Location = new System.Drawing.Point(4, 29);
            this.sellpage.Name = "sellpage";
            this.sellpage.Padding = new System.Windows.Forms.Padding(3);
            this.sellpage.Size = new System.Drawing.Size(418, 355);
            this.sellpage.TabIndex = 1;
            this.sellpage.Text = "Sell";
            this.sellpage.ToolTipText = "Use this tab to sell a display computer.";
            // 
            // progresslabelsell
            // 
            this.progresslabelsell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresslabelsell.Location = new System.Drawing.Point(3, 226);
            this.progresslabelsell.Name = "progresslabelsell";
            this.progresslabelsell.Size = new System.Drawing.Size(412, 23);
            this.progresslabelsell.TabIndex = 28;
            this.progresslabelsell.Text = "Welcome To OSIRiS!";
            this.progresslabelsell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltipcontrol.SetToolTip(this.progresslabelsell, "Welcome!");
            // 
            // helpsellbutton
            // 
            this.helpsellbutton.Depth = 0;
            this.helpsellbutton.Location = new System.Drawing.Point(175, 352);
            this.helpsellbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpsellbutton.Name = "helpsellbutton";
            this.helpsellbutton.Primary = true;
            this.helpsellbutton.Size = new System.Drawing.Size(75, 23);
            this.helpsellbutton.TabIndex = 4;
            this.helpsellbutton.Text = "Help";
            this.tooltipcontrol.SetToolTip(this.helpsellbutton, "Click here to open the manual.");
            this.helpsellbutton.UseVisualStyleBackColor = true;
            this.helpsellbutton.Click += new System.EventHandler(this.helpsellbutton_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Depth = 0;
            this.userlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userlabel.Location = new System.Drawing.Point(150, 99);
            this.userlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(122, 19);
            this.userlabel.TabIndex = 25;
            this.userlabel.Text = "New User Name:";
            this.tooltipcontrol.SetToolTip(this.userlabel, "Input the new user account name for the customer.");
            // 
            // usernamebox
            // 
            this.usernamebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.Location = new System.Drawing.Point(153, 123);
            this.usernamebox.MaxLength = 20;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 29);
            this.usernamebox.TabIndex = 3;
            this.usernamebox.Text = "User";
            this.tooltipcontrol.SetToolTip(this.usernamebox, "Input the new user account name for the customer.");
            // 
            // restartradio
            // 
            this.restartradio.AutoSize = true;
            this.restartradio.Checked = true;
            this.restartradio.Depth = 0;
            this.restartradio.Font = new System.Drawing.Font("Roboto", 10F);
            this.restartradio.Location = new System.Drawing.Point(132, 62);
            this.restartradio.Margin = new System.Windows.Forms.Padding(0);
            this.restartradio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.restartradio.MouseState = MaterialSkin.MouseState.HOVER;
            this.restartradio.Name = "restartradio";
            this.restartradio.Ripple = true;
            this.restartradio.Size = new System.Drawing.Size(73, 30);
            this.restartradio.TabIndex = 2;
            this.restartradio.TabStop = true;
            this.restartradio.Text = "Restart";
            this.tooltipcontrol.SetToolTip(this.restartradio, "Choose what the computer will do once the sell routine is complete.");
            this.restartradio.UseVisualStyleBackColor = true;
            // 
            // shutdownradio
            // 
            this.shutdownradio.AutoSize = true;
            this.shutdownradio.Depth = 0;
            this.shutdownradio.Font = new System.Drawing.Font("Roboto", 10F);
            this.shutdownradio.Location = new System.Drawing.Point(132, 34);
            this.shutdownradio.Margin = new System.Windows.Forms.Padding(0);
            this.shutdownradio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.shutdownradio.MouseState = MaterialSkin.MouseState.HOVER;
            this.shutdownradio.Name = "shutdownradio";
            this.shutdownradio.Ripple = true;
            this.shutdownradio.Size = new System.Drawing.Size(90, 30);
            this.shutdownradio.TabIndex = 1;
            this.shutdownradio.Text = "Shutdown";
            this.tooltipcontrol.SetToolTip(this.shutdownradio, "Choose what the computer will do once the sell routine is complete.");
            this.shutdownradio.UseVisualStyleBackColor = true;
            // 
            // sellquitbutton
            // 
            this.sellquitbutton.Depth = 0;
            this.sellquitbutton.Location = new System.Drawing.Point(337, 352);
            this.sellquitbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sellquitbutton.Name = "sellquitbutton";
            this.sellquitbutton.Primary = true;
            this.sellquitbutton.Size = new System.Drawing.Size(75, 23);
            this.sellquitbutton.TabIndex = 6;
            this.sellquitbutton.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.sellquitbutton, "Click here to close OSIRiS.");
            this.sellquitbutton.UseVisualStyleBackColor = true;
            this.sellquitbutton.Click += new System.EventHandler(this.sellquitbutton_Click);
            // 
            // sellrunbutton
            // 
            this.sellrunbutton.Depth = 0;
            this.sellrunbutton.Location = new System.Drawing.Point(256, 352);
            this.sellrunbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sellrunbutton.Name = "sellrunbutton";
            this.sellrunbutton.Primary = true;
            this.sellrunbutton.Size = new System.Drawing.Size(75, 23);
            this.sellrunbutton.TabIndex = 5;
            this.sellrunbutton.Text = "Run";
            this.tooltipcontrol.SetToolTip(this.sellrunbutton, "Click here when ready.");
            this.sellrunbutton.UseVisualStyleBackColor = true;
            this.sellrunbutton.Click += new System.EventHandler(this.sellrunbutton_Click);
            // 
            // sellradiogroup
            // 
            this.sellradiogroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellradiogroup.Location = new System.Drawing.Point(109, 6);
            this.sellradiogroup.Name = "sellradiogroup";
            this.sellradiogroup.Size = new System.Drawing.Size(200, 90);
            this.sellradiogroup.TabIndex = 26;
            this.sellradiogroup.TabStop = false;
            this.sellradiogroup.Text = "Upon Completion";
            this.tooltipcontrol.SetToolTip(this.sellradiogroup, "Choose what the computer will do once the sell routine is complete.");
            // 
            // formattab
            // 
            this.formattab.Controls.Add(this.formatlabel);
            this.formattab.Controls.Add(this.refreshbutton);
            this.formattab.Controls.Add(this.helpformatbutton);
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
            this.formattab.Location = new System.Drawing.Point(4, 29);
            this.formattab.Name = "formattab";
            this.formattab.Padding = new System.Windows.Forms.Padding(3);
            this.formattab.Size = new System.Drawing.Size(418, 355);
            this.formattab.TabIndex = 2;
            this.formattab.Text = "Formatter";
            this.formattab.ToolTipText = "Use this tab to format an external drive for a customer.";
            this.formattab.UseVisualStyleBackColor = true;
            // 
            // formatlabel
            // 
            this.formatlabel.Depth = 0;
            this.formatlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.formatlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formatlabel.Location = new System.Drawing.Point(74, 289);
            this.formatlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.formatlabel.Name = "formatlabel";
            this.formatlabel.Size = new System.Drawing.Size(271, 20);
            this.formatlabel.TabIndex = 11;
            this.formatlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshbutton
            // 
            this.refreshbutton.AutoSize = true;
            this.refreshbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshbutton.Depth = 0;
            this.refreshbutton.Location = new System.Drawing.Point(287, 170);
            this.refreshbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.refreshbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Primary = false;
            this.refreshbutton.Size = new System.Drawing.Size(70, 36);
            this.refreshbutton.TabIndex = 3;
            this.refreshbutton.Text = "Refresh";
            this.tooltipcontrol.SetToolTip(this.refreshbutton, "Click here to refresh the drive list.");
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // helpformatbutton
            // 
            this.helpformatbutton.Depth = 0;
            this.helpformatbutton.Location = new System.Drawing.Point(175, 352);
            this.helpformatbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpformatbutton.Name = "helpformatbutton";
            this.helpformatbutton.Primary = true;
            this.helpformatbutton.Size = new System.Drawing.Size(75, 23);
            this.helpformatbutton.TabIndex = 8;
            this.helpformatbutton.Text = "Help";
            this.tooltipcontrol.SetToolTip(this.helpformatbutton, "Click here to open the manual.");
            this.helpformatbutton.UseVisualStyleBackColor = true;
            this.helpformatbutton.Click += new System.EventHandler(this.helpformatbutton_Click);
            // 
            // formatbuttonquit
            // 
            this.formatbuttonquit.Depth = 0;
            this.formatbuttonquit.Location = new System.Drawing.Point(337, 352);
            this.formatbuttonquit.MouseState = MaterialSkin.MouseState.HOVER;
            this.formatbuttonquit.Name = "formatbuttonquit";
            this.formatbuttonquit.Primary = true;
            this.formatbuttonquit.Size = new System.Drawing.Size(75, 23);
            this.formatbuttonquit.TabIndex = 10;
            this.formatbuttonquit.Text = "Quit";
            this.tooltipcontrol.SetToolTip(this.formatbuttonquit, "Click here to close OSIRiS.");
            this.formatbuttonquit.UseVisualStyleBackColor = true;
            this.formatbuttonquit.Click += new System.EventHandler(this.formatbuttonquit_Click);
            // 
            // formatbutton
            // 
            this.formatbutton.Depth = 0;
            this.formatbutton.Location = new System.Drawing.Point(256, 352);
            this.formatbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.formatbutton.Name = "formatbutton";
            this.formatbutton.Primary = true;
            this.formatbutton.Size = new System.Drawing.Size(75, 23);
            this.formatbutton.TabIndex = 9;
            this.formatbutton.Text = "Format";
            this.tooltipcontrol.SetToolTip(this.formatbutton, "Click here when ready.");
            this.formatbutton.UseVisualStyleBackColor = true;
            this.formatbutton.Click += new System.EventHandler(this.formatbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 7;
            this.tooltipcontrol.SetToolTip(this.textBox1, "Choose a name for the newly formatted drive here.");
            // 
            // drivenamelabel
            // 
            this.drivenamelabel.AutoSize = true;
            this.drivenamelabel.Depth = 0;
            this.drivenamelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.drivenamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.drivenamelabel.Location = new System.Drawing.Point(112, 245);
            this.drivenamelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.drivenamelabel.Name = "drivenamelabel";
            this.drivenamelabel.Size = new System.Drawing.Size(87, 19);
            this.drivenamelabel.TabIndex = 6;
            this.drivenamelabel.Text = "New Name:";
            this.tooltipcontrol.SetToolTip(this.drivenamelabel, "Choose a name for the newly formatted drive here.");
            // 
            // exFATradio
            // 
            this.exFATradio.AutoSize = true;
            this.exFATradio.Depth = 0;
            this.exFATradio.Font = new System.Drawing.Font("Roboto", 10F);
            this.exFATradio.Location = new System.Drawing.Point(300, 211);
            this.exFATradio.Margin = new System.Windows.Forms.Padding(0);
            this.exFATradio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.exFATradio.MouseState = MaterialSkin.MouseState.HOVER;
            this.exFATradio.Name = "exFATradio";
            this.exFATradio.Ripple = true;
            this.exFATradio.Size = new System.Drawing.Size(68, 30);
            this.exFATradio.TabIndex = 6;
            this.exFATradio.Text = "exFAT";
            this.tooltipcontrol.SetToolTip(this.exFATradio, "exFAT. Read/Write on most systems, use in joint Windows/Mac environments.");
            this.exFATradio.UseVisualStyleBackColor = true;
            // 
            // NTFSradio
            // 
            this.NTFSradio.AutoSize = true;
            this.NTFSradio.Depth = 0;
            this.NTFSradio.Font = new System.Drawing.Font("Roboto", 10F);
            this.NTFSradio.Location = new System.Drawing.Point(227, 211);
            this.NTFSradio.Margin = new System.Windows.Forms.Padding(0);
            this.NTFSradio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NTFSradio.MouseState = MaterialSkin.MouseState.HOVER;
            this.NTFSradio.Name = "NTFSradio";
            this.NTFSradio.Ripple = true;
            this.NTFSradio.Size = new System.Drawing.Size(63, 30);
            this.NTFSradio.TabIndex = 5;
            this.NTFSradio.Text = "NTFS";
            this.tooltipcontrol.SetToolTip(this.NTFSradio, "NTFS. Best used in Windows only environments. Can only be read by Macs, not writt" +
        "en to.");
            this.NTFSradio.UseVisualStyleBackColor = true;
            // 
            // fat32radio
            // 
            this.fat32radio.AutoSize = true;
            this.fat32radio.Checked = true;
            this.fat32radio.Depth = 0;
            this.fat32radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.fat32radio.Location = new System.Drawing.Point(149, 211);
            this.fat32radio.Margin = new System.Windows.Forms.Padding(0);
            this.fat32radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fat32radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.fat32radio.Name = "fat32radio";
            this.fat32radio.Ripple = true;
            this.fat32radio.Size = new System.Drawing.Size(70, 30);
            this.fat32radio.TabIndex = 4;
            this.fat32radio.TabStop = true;
            this.fat32radio.Text = "FAT32";
            this.tooltipcontrol.SetToolTip(this.fat32radio, "FAT32. File size limitation of 4gb, use for games consoles and set-top boxes.");
            this.fat32radio.UseVisualStyleBackColor = true;
            // 
            // fslabel
            // 
            this.fslabel.AutoSize = true;
            this.fslabel.Depth = 0;
            this.fslabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fslabel.Location = new System.Drawing.Point(59, 216);
            this.fslabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fslabel.Name = "fslabel";
            this.fslabel.Size = new System.Drawing.Size(87, 19);
            this.fslabel.TabIndex = 2;
            this.fslabel.Text = "FileSystem:";
            this.tooltipcontrol.SetToolTip(this.fslabel, "Choose a file system here.");
            // 
            // drivelabel
            // 
            this.drivelabel.AutoSize = true;
            this.drivelabel.Depth = 0;
            this.drivelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.drivelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.drivelabel.Location = new System.Drawing.Point(106, 179);
            this.drivelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.drivelabel.Name = "drivelabel";
            this.drivelabel.Size = new System.Drawing.Size(47, 19);
            this.drivelabel.TabIndex = 1;
            this.drivelabel.Text = "Drive:";
            this.tooltipcontrol.SetToolTip(this.drivelabel, "Choose a drive to format here.");
            // 
            // driveselector
            // 
            this.driveselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveselector.FormattingEnabled = true;
            this.driveselector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.driveselector.Location = new System.Drawing.Point(159, 175);
            this.driveselector.Name = "driveselector";
            this.driveselector.Size = new System.Drawing.Size(121, 28);
            this.driveselector.TabIndex = 2;
            this.tooltipcontrol.SetToolTip(this.driveselector, "Choose a drive to format here.");
            this.driveselector.SelectedIndexChanged += new System.EventHandler(this.driveselector_SelectedIndexChanged);
            // 
            // driveselected
            // 
            this.driveselected.Controls.Add(this.label6);
            this.driveselected.Controls.Add(this.label4);
            this.driveselected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveselected.Location = new System.Drawing.Point(106, 10);
            this.driveselected.Name = "driveselected";
            this.driveselected.Size = new System.Drawing.Size(200, 151);
            this.driveselected.TabIndex = 1;
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
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 13;
            // 
            // tabselector
            // 
            this.tabselector.BaseTabControl = this.tabControl1;
            this.tabselector.Depth = 0;
            this.tabselector.Location = new System.Drawing.Point(0, 61);
            this.tabselector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselector.Name = "tabselector";
            this.tabselector.Size = new System.Drawing.Size(426, 48);
            this.tabselector.TabIndex = 1;
            this.tabselector.Text = "materialTabSelector1";
            this.tooltipcontrol.SetToolTip(this.tabselector, "Pick a task.");
            // 
            // OSIRiSmainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabselector);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OSIRiSmainwindow";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSIRiS";
            this.Load += new System.EventHandler(this.OSIRiSmainwindow_Load);
            this.Shown += new System.EventHandler(this.OSIRiSmainwindow_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OSIRiSmainwindow_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.setuppage.ResumeLayout(false);
            this.setuppage.PerformLayout();
            this.sellpage.ResumeLayout(false);
            this.sellpage.PerformLayout();
            this.formattab.ResumeLayout(false);
            this.formattab.PerformLayout();
            this.driveselected.ResumeLayout(false);
            this.driveselected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage setuppage;
        private System.Windows.Forms.TabPage sellpage;
        private MaterialSkin.Controls.MaterialLabel userpwlabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField pwbox;
        private System.Windows.Forms.ComboBox statedropdown;
        private MaterialSkin.Controls.MaterialLabel statelabel;
        private MaterialSkin.Controls.MaterialRaisedButton quitbutton;
        private MaterialSkin.Controls.MaterialRaisedButton runbutton;
        private MaterialSkin.Controls.MaterialLabel timelabel;
        private MaterialSkin.Controls.MaterialLabel shutdownlabel;
        private MaterialSkin.Controls.MaterialRadioButton restartradio;
        private MaterialSkin.Controls.MaterialRadioButton shutdownradio;
        private MaterialSkin.Controls.MaterialLabel userlabel;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.GroupBox sellradiogroup;
        private System.Windows.Forms.TabPage formattab;
        private System.Windows.Forms.ComboBox driveselector;
        private MaterialSkin.Controls.MaterialLabel drivelabel;
        private MaterialSkin.Controls.MaterialLabel fslabel;
        private MaterialSkin.Controls.MaterialRadioButton exFATradio;
        private MaterialSkin.Controls.MaterialRadioButton NTFSradio;
        private MaterialSkin.Controls.MaterialRadioButton fat32radio;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel drivenamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox driveselected;
        private System.Windows.Forms.ToolTip tooltipcontrol;
        private MaterialSkin.Controls.MaterialCheckBox clearancecheckbox;
        private MaterialSkin.Controls.MaterialTabSelector tabselector;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private MaterialSkin.Controls.MaterialRaisedButton sellquitbutton;
        private MaterialSkin.Controls.MaterialRaisedButton sellrunbutton;
        private MaterialSkin.Controls.MaterialRaisedButton formatbutton;
        private MaterialSkin.Controls.MaterialRaisedButton formatbuttonquit;
        private System.Windows.Forms.DateTimePicker currenttime;
        private MaterialSkin.Controls.MaterialRaisedButton helpsetupbutton;
        private MaterialSkin.Controls.MaterialRaisedButton helpsellbutton;
        private MaterialSkin.Controls.MaterialRaisedButton helpformatbutton;
        private System.Windows.Forms.DateTimePicker shutdowntime;
        private MaterialSkin.Controls.MaterialFlatButton refreshbutton;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Label progresslabelsell;
        private MaterialSkin.Controls.MaterialLabel formatlabel;
    }
}

