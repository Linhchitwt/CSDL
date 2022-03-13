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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void back_TC_Click(object sender, EventArgs e)
        {
            Display1 display1 = new Display1();
            display1.Show();
            this.Hide();
        }

        private void X_TC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
