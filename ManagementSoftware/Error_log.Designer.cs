
namespace ManagementSoftware
{
    partial class Error_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_log));
            this.X_er_log = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.X_er_log)).BeginInit();
            this.SuspendLayout();
            // 
            // X_er_log
            // 
            this.X_er_log.BackColor = System.Drawing.Color.Transparent;
            this.X_er_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_er_log.Image = global::ManagementSoftware.Properties.Resources.X_01;
            this.X_er_log.Location = new System.Drawing.Point(186, 0);
            this.X_er_log.Name = "X_er_log";
            this.X_er_log.Size = new System.Drawing.Size(35, 35);
            this.X_er_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_er_log.TabIndex = 0;
            this.X_er_log.TabStop = false;
            this.X_er_log.Click += new System.EventHandler(this.X_er_log_Click);
            // 
            // Error_log
            // 
            this.AccessibleName = "Error_log";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(222, 222);
            this.Controls.Add(this.X_er_log);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error_log";
            this.Load += new System.EventHandler(this.Error_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.X_er_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox X_er_log;
    }
}