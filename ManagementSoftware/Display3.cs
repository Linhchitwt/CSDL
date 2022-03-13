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
    public partial class Display3 : Form
    {
        public Display3()
        {
            InitializeComponent();
        }

        private void back_3_Click(object sender, EventArgs e)
        {
            Display1 display1 = new Display1();
            display1.Show();
            this.Hide();
        }

        private void X_3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if ((Username.Text == "") || (Password.Text == ""))
            {
                Error er = new Error();
                er.Show();
            }
            else if ((Username.Text == "admin") && (Password.Text == "admin"))
            {
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            /* else if()
             {
                 // phần này để đăng nhập vào  teacher || student
             } */
            else
            {
                Error_log erlog = new Error_log();
                erlog.Show();
            }
        }

        private void Username_MouseEnter(object sender, EventArgs e)
        {
            if (Username.Text == "Type your Username...")
            {
                Username.Clear();
            }
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (Password.Text == "Type your Password...")
            {
                Password.Clear();
                Password.PasswordChar = '*';
            }
        }
    }
}
