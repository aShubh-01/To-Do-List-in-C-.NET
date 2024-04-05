using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMS
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string userName, passCode;

            if (username.Text != "")
            {
                userName = username.Text;
                if (password.Text != "" && cpassword.Text == password.Text)
                {
                    passCode = cpassword.Text;

                    String Query = "INSERT INTO LoginIDs(Username, Passcode) VALUES('" + userName + "', '" + passCode + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully!");
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Please check your password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username!");
            }
            con.Close();
        }
    }
}
