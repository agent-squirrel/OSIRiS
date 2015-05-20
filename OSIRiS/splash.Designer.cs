namespace OSIRiS
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.splashimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashimage)).BeginInit();
            this.SuspendLayout();
            // 
            // splashimage
            // 
            this.splashimage.BackColor = System.Drawing.SystemColors.Window;
            this.splashimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splashimage.Image = global::OSIRiS.Properties.Resources.logo;
            this.splashimage.Location = new System.Drawing.Point(0, 0);
            this.splashimage.Name = "splashimage";
            this.splashimage.Size = new System.Drawing.Size(235, 157);
            this.splashimage.TabIndex = 0;
            this.splashimage.TabStop = false;
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 157);
            this.Controls.Add(this.splashimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashimage;
    }
}