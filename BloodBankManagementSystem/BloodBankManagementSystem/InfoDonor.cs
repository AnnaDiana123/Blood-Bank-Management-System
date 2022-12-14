using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class InfoDonor : Form
    {
        private int currentID;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public InfoDonor( int id)
        {
            InitializeComponent();
            currentID = id;
            populate();
        }

        private void populate()
        {
            conn.Open();
            string query;
            query = "select * from DonorTable where DNum=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", currentID);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBoxName.Text = reader["DName"].ToString();
                textBoxAddress.Text = reader["DAddress"].ToString();
                textBoxAge.Text= reader["DAge"].ToString();
                textBoxPhone.Text= reader["DPhone"].ToString();
                textBoxBlood.Text= reader["DGroup"].ToString();
                textBoxGender.Text= reader["DGender"].ToString();
            }

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DonatePage(currentID);
            f.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewHistoryPage(currentID);
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MedicalReportPage(currentID);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxAge.Text == "" || textBoxBlood.Text == "" || textBoxGender.Text == "" || textBoxPhone.Text == "")
            {
                labelStatus.Text = "There can't be empty fields";
            }
            else
            {
                conn.Open();
                string query = "update DonorTable set DName=@name, DAge=@age, DAddress=@address,DPhone=@phone";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("name", textBoxName.Text);
                cmd.Parameters.AddWithValue("age", textBoxAge.Text);
                cmd.Parameters.AddWithValue("address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("phone", textBoxPhone.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                labelStatus.Text = "Info successfully updated!";
            }
        
        }
    }
}
