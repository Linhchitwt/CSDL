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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            time.Value = startpoint;
            if (time.Value == 100)
            {
                time.Value = 0;
                timer1.Stop();
                Display1 display1 = new Display1();
                display1.Show();
                this.Hide();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
