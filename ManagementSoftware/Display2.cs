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
    public partial class Display2 : Form
    {
        public Display2()
        {
            InitializeComponent();
        }

        private void back_1_Click(object sender, EventArgs e)
        {
            Display1 display1 = new Display1();
            display1.Show();
            this.Hide();
           
        }

        private void X_dis2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
