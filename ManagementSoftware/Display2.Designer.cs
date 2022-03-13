
namespace ManagementSoftware
{
    partial class Display2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display2));
            this.back_1 = new Guna.UI2.WinForms.Guna2Button();
            this.X_dis2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // back_1
            // 
            this.back_1.AccessibleName = "back_1";
            this.back_1.AutoRoundedCorners = true;
            this.back_1.BackColor = System.Drawing.Color.Transparent;
            this.back_1.BorderColor = System.Drawing.Color.Transparent;
            this.back_1.BorderRadius = 14;
            this.back_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.back_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_1.FillColor = System.Drawing.Color.Transparent;
            this.back_1.FocusedColor = System.Drawing.Color.White;
            this.back_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_1.ForeColor = System.Drawing.Color.Transparent;
            this.back_1.Location = new System.Drawing.Point(880, 52);
            this.back_1.Name = "back_1";
            this.back_1.Size = new System.Drawing.Size(31, 30);
            this.back_1.TabIndex = 3;
            this.back_1.UseTransparentBackground = true;
            this.back_1.Click += new System.EventHandler(this.back_1_Click);
            // 
            // X_dis2
            // 
            this.X_dis2.AccessibleName = "X_dis2";
            this.X_dis2.AutoRoundedCorners = true;
            this.X_dis2.BackColor = System.Drawing.Color.Transparent;
            this.X_dis2.BorderColor = System.Drawing.Color.Transparent;
            this.X_dis2.BorderRadius = 14;
            this.X_dis2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.X_dis2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_dis2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.X_dis2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.X_dis2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.X_dis2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.X_dis2.FillColor = System.Drawing.Color.Transparent;
            this.X_dis2.FocusedColor = System.Drawing.Color.White;
            this.X_dis2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.X_dis2.ForeColor = System.Drawing.Color.Transparent;
            this.X_dis2.Location = new System.Drawing.Point(927, 51);
            this.X_dis2.Name = "X_dis2";
            this.X_dis2.Size = new System.Drawing.Size(31, 30);
            this.X_dis2.TabIndex = 4;
            this.X_dis2.UseTransparentBackground = true;
            this.X_dis2.Click += new System.EventHandler(this.X_dis2_Click);
            // 
            // Display2
            // 
            this.AccessibleName = "Display2";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.X_dis2);
            this.Controls.Add(this.back_1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Display2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display2";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button back_1;
        private Guna.UI2.WinForms.Guna2Button X_dis2;
    }
}