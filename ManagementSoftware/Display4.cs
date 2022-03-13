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
    public partial class Display4 : Form
    {
        public Display4()
        {
            InitializeComponent();
        }


        private void Confirm_Click(object sender, EventArgs e)
        {
            if ((Object.Text == "") || (Surname.Text == "") || (Name_Sig.Text == "") || (Phone.Text == "") || (Address.Text == "") || (Ethnic.Text == "") || (Username_sig.Text == "") || (Pass_sig.Text == "") || (RePass_sig.Text == "") || (Gender.Text == "") || (Calendar_Birth.Text == ""))
            {
                Error er = new Error();
                er.Show();
            }
            else
            {
                string birthday = Calendar_Birth.Value.Year.ToString() + "-" + Calendar_Birth.Value.Month.ToString() + "-" + Calendar_Birth.Value.Day.ToString();

                // phần này để thêm thông tin người mới vô sqls
            }
        }


        private void X_4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_4_Click(object sender, EventArgs e)
        {
            Display1 display1 = new Display1();
            display1.Show();
            this.Hide();
        }
    }
}
