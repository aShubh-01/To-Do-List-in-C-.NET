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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            try
            {
                string query = "SELECT * FROM loginIDs WHERE Username = '" + txtUser.Text + "' AND Passcode = '" + txtPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    user = txtUser.Text;
                    pass = txtPass.Text;

                    MessageBox.Show("Login Successful!");
                    txtUser.Clear();
                    txtPass.Clear();
                    Form2 f2 = new Form2();
                    f2.TopLevel = false;
                    panel4.Controls.Add(f2);
                    f2.BringToFront();
                    f2.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid login details!");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
