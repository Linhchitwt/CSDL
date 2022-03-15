using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware
{
    public partial class Admin_TC : Form
    {
        public Admin_TC()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            manage mng = new manage();
            mng.Show();
            this.Hide();
        }

        private void AD_emp_Click(object sender, EventArgs e)
        {
            Admin_Employee ep = new Admin_Employee();
            ep.Show();
            this.Hide();
        }

        private void AD_ST_Click(object sender, EventArgs e)
        {
            Admin_ST st = new Admin_ST();
            st.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Display3 display3 = new Display3();
            display3.Show();
            this.Hide();
        }
    }
}
