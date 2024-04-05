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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
            FILLDGV();
        }
        private void FILLDGV()
        {
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM OtherTask", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO OtherTask VALUES('" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            String query1 = "INSERT INTO AllTask VALUES('" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
            FILLDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String query = "UPDATE OtherTask SET TaskDescription = '" + textBox1.Text + "',StartDate = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', EndDate = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' WHERE TaskDescription = '" + textBox2.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                String query1 = "UPDATE AllTask SET TaskDescription = '" + textBox1.Text + "',StartDate = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', EndDate = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' WHERE TaskDescription = '" + textBox2.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
                FILLDGV();
            }
            else
            {
                MessageBox.Show("Please fill the search box");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String query = "DELETE FROM OtherTask WHERE TaskDescription = '" + textBox2.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                String query1 = "DELETE FROM AllTask WHERE TaskDescription = '" + textBox2.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
                FILLDGV();
            }
            else
            {
                MessageBox.Show("Please fill the search box");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
