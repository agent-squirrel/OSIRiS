namespace OSIRiS
{
    partial class update_complete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_complete));
            this.ok_button = new System.Windows.Forms.Button();
            this.updatecompletelabel = new System.Windows.Forms.Label();
            this.releasenotescheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(103, 101);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok_button.Name = "ok_button";
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
            this.updatecompletelabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecompletelabel.Location = new System.Drawing.Point(60, 12);
            this.updatecompletelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updatecompletelabel.Name = "updatecompletelabel";
            this.updatecompletelabel.Size = new System.Drawing.Size(198, 36);
            this.updatecompletelabel.TabIndex = 1;
            this.updatecompletelabel.Text = "Update complete!\r\nPress Ok to restart OSIRiS.";
            this.updatecompletelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // releasenotescheckbox
            // 
            this.releasenotescheckbox.AutoSize = true;
            this.releasenotescheckbox.Location = new System.Drawing.Point(79, 62);
            this.releasenotescheckbox.Name = "releasenotescheckbox";
            this.releasenotescheckbox.Size = new System.Drawing.Size(160, 22);
            this.releasenotescheckbox.TabIndex = 2;
            this.releasenotescheckbox.Text = "View release notes";
            this.releasenotescheckbox.UseVisualStyleBackColor = true;
            // 
            // update_complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(319, 146);
            this.ControlBox = false;
            this.Controls.Add(this.releasenotescheckbox);
            this.Controls.Add(this.updatecompletelabel);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "update_complete";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Complete";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label updatecompletelabel;
        private System.Windows.Forms.CheckBox releasenotescheckbox;
    }
}