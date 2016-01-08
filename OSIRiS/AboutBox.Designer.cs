namespace OSIRiS
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.ok_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updatecompletelabel = new MaterialSkin.Controls.MaterialLabel();
            this.versionlabel = new MaterialSkin.Controls.MaterialLabel();
            this.manual_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.websitelink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Depth = 0;
            this.ok_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(163, 159);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4);
            this.ok_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_button.Name = "ok_button";
            this.ok_button.Primary = true;
            this.ok_button.Size = new System.Drawing.Size(112, 32);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // updatecompletelabel
            // 
            this.updatecompletelabel.AutoSize = true;
            this.updatecompletelabel.BackColor = System.Drawing.SystemColors.Window;
            this.updatecompletelabel.Depth = 0;
            this.updatecompletelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.updatecompletelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updatecompletelabel.Location = new System.Drawing.Point(21, 68);
            this.updatecompletelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updatecompletelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.updatecompletelabel.Name = "updatecompletelabel";
            this.updatecompletelabel.Size = new System.Drawing.Size(276, 38);
            this.updatecompletelabel.TabIndex = 1;
            this.updatecompletelabel.Text = "OSIRiS \r\nRapid Display Deployment and Recovery";
            this.updatecompletelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionlabel
            // 
            this.versionlabel.BackColor = System.Drawing.SystemColors.Window;
            this.versionlabel.Depth = 0;
            this.versionlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.versionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionlabel.Location = new System.Drawing.Point(43, 133);
            this.versionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(232, 19);
            this.versionlabel.TabIndex = 2;
            this.versionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manual_button
            // 
            this.manual_button.Depth = 0;
            this.manual_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_button.Location = new System.Drawing.Point(43, 159);
            this.manual_button.Margin = new System.Windows.Forms.Padding(4);
            this.manual_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.manual_button.Name = "manual_button";
            this.manual_button.Primary = true;
            this.manual_button.Size = new System.Drawing.Size(112, 32);
            this.manual_button.TabIndex = 3;
            this.manual_button.Text = "Manual";
            this.manual_button.UseVisualStyleBackColor = true;
            this.manual_button.Click += new System.EventHandler(this.manual_button_Click);
            // 
            // websitelink
            // 
            this.websitelink.AutoSize = true;
            this.websitelink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websitelink.Location = new System.Drawing.Point(128, 110);
            this.websitelink.Name = "websitelink";
            this.websitelink.Size = new System.Drawing.Size(62, 20);
            this.websitelink.TabIndex = 4;
            this.websitelink.TabStop = true;
            this.websitelink.Text = "Website";
            this.websitelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websitelink_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(319, 204);
            this.ControlBox = false;
            this.Controls.Add(this.websitelink);
            this.Controls.Add(this.manual_button);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.updatecompletelabel);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton ok_button;
        private MaterialSkin.Controls.MaterialLabel updatecompletelabel;
        private MaterialSkin.Controls.MaterialLabel versionlabel;
        private MaterialSkin.Controls.MaterialRaisedButton manual_button;
        private System.Windows.Forms.LinkLabel websitelink;
    }
}