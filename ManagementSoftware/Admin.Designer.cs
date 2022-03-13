
namespace ManagementSoftware
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Age_ST = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Class = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X_4 = new Guna.UI2.WinForms.Guna2Button();
            this.AD_ST = new Guna.UI2.WinForms.Guna2Button();
            this.AD_emp = new Guna.UI2.WinForms.Guna2Button();
            this.AD_teach = new Guna.UI2.WinForms.Guna2Button();
            this.Manage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age_ST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            this.SuspendLayout();
            // 
            // Age_ST
            // 
            this.Age_ST.AccessibleName = "Age_ST";
            this.Age_ST.BackColor = System.Drawing.Color.Transparent;
            this.Age_ST.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Age_ST.BorderlineColor = System.Drawing.Color.Firebrick;
            chartArea1.Name = "ChartArea1";
            this.Age_ST.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_ST.Legends.Add(legend1);
            this.Age_ST.Location = new System.Drawing.Point(543, 103);
            this.Age_ST.Name = "Age_ST";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Yellow;
            series1.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            this.Age_ST.Series.Add(series1);
            this.Age_ST.Size = new System.Drawing.Size(366, 205);
            this.Age_ST.TabIndex = 0;
            this.Age_ST.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Firebrick;
            title1.Name = "Age_ST";
            title1.Text = "Age";
            this.Age_ST.Titles.Add(title1);
            // 
            // Class
            // 
            this.Class.AccessibleName = "Class";
            this.Class.BackColor = System.Drawing.Color.Transparent;
            this.Class.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Class.BorderlineColor = System.Drawing.Color.Firebrick;
            chartArea2.Name = "ChartArea1";
            this.Class.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend2.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Legends.Add(legend2);
            this.Class.Location = new System.Drawing.Point(543, 350);
            this.Class.Name = "Class";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Red;
            series2.MarkerColor = System.Drawing.Color.Yellow;
            series2.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Name = "Series1";
            this.Class.Series.Add(series2);
            this.Class.Size = new System.Drawing.Size(366, 205);
            this.Class.TabIndex = 1;
            this.Class.Text = "chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Firebrick;
            title2.Name = "Class";
            title2.Text = "Class";
            this.Class.Titles.Add(title2);
            // 
            // X_4
            // 
            this.X_4.AccessibleName = "X_4";
            this.X_4.BackColor = System.Drawing.Color.Transparent;
            this.X_4.BorderColor = System.Drawing.Color.Transparent;
            this.X_4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.X_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.X_4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.X_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.X_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.X_4.FillColor = System.Drawing.Color.Transparent;
            this.X_4.FocusedColor = System.Drawing.Color.White;
            this.X_4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.X_4.ForeColor = System.Drawing.Color.Transparent;
            this.X_4.Location = new System.Drawing.Point(388, 31);
            this.X_4.Name = "X_4";
            this.X_4.Size = new System.Drawing.Size(28, 31);
            this.X_4.TabIndex = 24;
            this.X_4.UseTransparentBackground = true;
            // 
            // AD_ST
            // 
            this.AD_ST.AccessibleName = "Admin_ST";
            this.AD_ST.BackColor = System.Drawing.Color.Transparent;
            this.AD_ST.BorderColor = System.Drawing.Color.Transparent;
            this.AD_ST.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.AD_ST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AD_ST.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AD_ST.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AD_ST.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AD_ST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AD_ST.FillColor = System.Drawing.Color.Transparent;
            this.AD_ST.FocusedColor = System.Drawing.Color.White;
            this.AD_ST.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AD_ST.ForeColor = System.Drawing.Color.Transparent;
            this.AD_ST.Location = new System.Drawing.Point(653, 583);
            this.AD_ST.Name = "AD_ST";
            this.AD_ST.Size = new System.Drawing.Size(120, 50);
            this.AD_ST.TabIndex = 25;
            this.AD_ST.UseTransparentBackground = true;
            this.AD_ST.Click += new System.EventHandler(this.AD_ST_Click);
            // 
            // AD_emp
            // 
            this.AD_emp.AccessibleName = "AD_emp";
            this.AD_emp.BackColor = System.Drawing.Color.Transparent;
            this.AD_emp.BorderColor = System.Drawing.Color.Transparent;
            this.AD_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.AD_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AD_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AD_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AD_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AD_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AD_emp.FillColor = System.Drawing.Color.Transparent;
            this.AD_emp.FocusedColor = System.Drawing.Color.White;
            this.AD_emp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AD_emp.ForeColor = System.Drawing.Color.Transparent;
            this.AD_emp.Location = new System.Drawing.Point(512, 582);
            this.AD_emp.Name = "AD_emp";
            this.AD_emp.Size = new System.Drawing.Size(120, 50);
            this.AD_emp.TabIndex = 26;
            this.AD_emp.UseTransparentBackground = true;
            this.AD_emp.Click += new System.EventHandler(this.AD_emp_Click);
            // 
            // AD_teach
            // 
            this.AD_teach.AccessibleName = "AD_teach";
            this.AD_teach.BackColor = System.Drawing.Color.Transparent;
            this.AD_teach.BorderColor = System.Drawing.Color.Transparent;
            this.AD_teach.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.AD_teach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AD_teach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AD_teach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AD_teach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AD_teach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AD_teach.FillColor = System.Drawing.Color.Transparent;
            this.AD_teach.FocusedColor = System.Drawing.Color.White;
            this.AD_teach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AD_teach.ForeColor = System.Drawing.Color.Transparent;
            this.AD_teach.Location = new System.Drawing.Point(363, 582);
            this.AD_teach.Name = "AD_teach";
            this.AD_teach.Size = new System.Drawing.Size(120, 50);
            this.AD_teach.TabIndex = 27;
            this.AD_teach.UseTransparentBackground = true;
            this.AD_teach.Click += new System.EventHandler(this.AD_teach_Click);
            // 
            // Manage
            // 
            this.Manage.AccessibleName = "Manage";
            this.Manage.BackColor = System.Drawing.Color.Transparent;
            this.Manage.BorderColor = System.Drawing.Color.Transparent;
            this.Manage.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Manage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Manage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Manage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Manage.FillColor = System.Drawing.Color.Transparent;
            this.Manage.FocusedColor = System.Drawing.Color.White;
            this.Manage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Manage.ForeColor = System.Drawing.Color.Transparent;
            this.Manage.Location = new System.Drawing.Point(219, 582);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(120, 50);
            this.Manage.TabIndex = 28;
            this.Manage.UseTransparentBackground = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Location = new System.Drawing.Point(835, 586);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(44, 45);
            this.guna2Button5.TabIndex = 29;
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.Manage);
            this.Controls.Add(this.AD_teach);
            this.Controls.Add(this.AD_emp);
            this.Controls.Add(this.AD_ST);
            this.Controls.Add(this.X_4);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Age_ST);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.Age_ST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Age_ST;
        private System.Windows.Forms.DataVisualization.Charting.Chart Class;
        private Guna.UI2.WinForms.Guna2Button X_4;
        private Guna.UI2.WinForms.Guna2Button AD_ST;
        private Guna.UI2.WinForms.Guna2Button AD_emp;
        private Guna.UI2.WinForms.Guna2Button AD_teach;
        private Guna.UI2.WinForms.Guna2Button Manage;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}