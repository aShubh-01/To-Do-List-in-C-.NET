using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.TopLevel = false;
            panel2.Controls.Add(f7);
            f7.BringToFront();
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.TopLevel = false;
            panel2.Controls.Add(f8);
            f8.BringToFront();
            f8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.TopLevel = false;
            panel2.Controls.Add(f9);
            f9.BringToFront();
            f9.Show();
        }
    }
}
