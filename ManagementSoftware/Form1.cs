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
    public partial class Display1 : Form
    {
        public Display1()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
            Display3 display3 = new Display3();
            display3.Show();
            this.Hide();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Display4 display4 = new Display4();
            display4.Show();
            this.Hide();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Display2 display2 = new Display2();
            display2.Show();
            this.Hide();
        }
    }
}
