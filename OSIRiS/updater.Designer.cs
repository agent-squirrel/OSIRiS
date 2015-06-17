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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updater));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.perccomplete = new System.Windows.Forms.Label();
            this.totaldownloaded = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 74);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(484, 23);
            this.progressBar.TabIndex = 0;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(244, 157);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(55, 18);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Location = new System.Drawing.Point(156, 53);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(62, 18);
            this.labelPerc.TabIndex = 2;
            this.labelPerc.Text = "Percent";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(156, 100);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(96, 18);
            this.labelDownloaded.TabIndex = 3;
            this.labelDownloaded.Text = "Downloaded";
            // 
            // perccomplete
            // 
            this.perccomplete.AutoSize = true;
            this.perccomplete.Location = new System.Drawing.Point(12, 53);
            this.perccomplete.Name = "perccomplete";
            this.perccomplete.Size = new System.Drawing.Size(138, 18);
            this.perccomplete.TabIndex = 4;
            this.perccomplete.Text = "Percent Complete:";
            // 
            // totaldownloaded
            // 
            this.totaldownloaded.AutoSize = true;
            this.totaldownloaded.Location = new System.Drawing.Point(12, 100);
            this.totaldownloaded.Name = "totaldownloaded";
            this.totaldownloaded.Size = new System.Drawing.Size(136, 18);
            this.totaldownloaded.TabIndex = 5;
            this.totaldownloaded.Text = "Total Downloaded:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(179, 157);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(59, 18);
            this.speed.TabIndex = 6;
            this.speed.Text = "Speed:";
            // 
            // updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 184);
            this.ControlBox = false;
            this.Controls.Add(this.speed);
            this.Controls.Add(this.totaldownloaded);
            this.Controls.Add(this.perccomplete);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "updater";
            this.Text = "Updater";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.updater_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Label perccomplete;
        private System.Windows.Forms.Label totaldownloaded;
        private System.Windows.Forms.Label speed;
    }
}