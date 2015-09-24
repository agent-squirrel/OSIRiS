namespace OSIRiS
{
    partial class updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updater));
            this.labelDownloaded = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.info = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totaldownloadedlabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.Depth = 0;
            this.labelDownloaded.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDownloaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDownloaded.Location = new System.Drawing.Point(12, 194);
            this.labelDownloaded.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(484, 21);
            this.labelDownloaded.TabIndex = 3;
            this.labelDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // info
            // 
            this.info.Depth = 0;
            this.info.Font = new System.Drawing.Font("Roboto", 11F);
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.info.Location = new System.Drawing.Point(133, 220);
            this.info.MouseState = MaterialSkin.MouseState.HOVER;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(242, 31);
            this.info.TabIndex = 7;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::OSIRiS.Properties.Resources.logocropped_with_gear;
            this.pictureBox1.Location = new System.Drawing.Point(133, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // totaldownloadedlabel
            // 
            this.totaldownloadedlabel.AutoSize = true;
            this.totaldownloadedlabel.Depth = 0;
            this.totaldownloadedlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totaldownloadedlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totaldownloadedlabel.Location = new System.Drawing.Point(187, 171);
            this.totaldownloadedlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totaldownloadedlabel.Name = "totaldownloadedlabel";
            this.totaldownloadedlabel.Size = new System.Drawing.Size(135, 19);
            this.totaldownloadedlabel.TabIndex = 8;
            this.totaldownloadedlabel.Text = "Total Downloaded:";
            this.totaldownloadedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 267);
            this.ControlBox = false;
            this.Controls.Add(this.totaldownloadedlabel);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDownloaded);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Shown += new System.EventHandler(this.updater_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelDownloaded;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel info;
        private MaterialSkin.Controls.MaterialLabel totaldownloadedlabel;
    }
}