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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string FirstName, LastName, EmailID, ContactNo;
            FirstName = firstname.Text;
            LastName = lastname.Text;
            EmailID = email.Text;
            ContactNo = contact.Text;
            if (firstname.Text != "" && lastname.Text != "" && email.Text != "" && contact.Text != "")
            {
                string Query = "INSERT INTO Accounts(FirstName, LastName, EmailID, DOB, ContactNo) VALUES('" + FirstName + "', '" + LastName + "', '" + EmailID + "', '" + dob.Value.ToString("yyyy-MM-dd") + "', '" + ContactNo + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registered Succesfully");
                Form4 f4 = new Form4();
                f4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstname.Clear();
            lastname.Clear();
            email.Clear();
            contact.Clear();
            dob.ResetText();
        }
    }
}
