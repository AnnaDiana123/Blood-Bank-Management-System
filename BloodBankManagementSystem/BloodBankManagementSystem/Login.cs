using System;
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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bloodlogo_Click(object sender, EventArgs e)
        {

        }

        private void FormBank_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query;
            query = "select DonorTable.DPassword, DonorTable.DNum from DonorTable where DUsername=@DUsername";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("DUsername", textBoxUsername.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string psw = reader["DPassword"].ToString();
                int id= Int32.Parse(reader["DNum"].ToString());
                if (psw.Equals(textBoxPassword.Text))
                {
                    this.Hide();
                    Form f1 = new MainFormDonor(id);
                    f1.Show();
                }
                else
                {
                    labelStatus.Text = "Incorrect password";
                }
            }
            else
            {
                labelStatus.Text = "Username not found";
            }

            conn.Close();
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainFormAdmin();
            form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CreateAccount();
            form.Show();
        }
    }
}
