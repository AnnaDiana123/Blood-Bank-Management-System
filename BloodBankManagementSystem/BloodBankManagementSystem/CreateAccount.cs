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
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class CreateAccount : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public CreateAccount()
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
            if (textBoxUsername.Text == "" || textBoxPhone.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "" || textBoxAge.Text == "" || textBoxAddress.Text == "" || comboBoxBlood.Text == "" || comboBoxGender.Text == "")
                labelStatus.Text = "Please fill in all info";
            else
            {
                try
                {
                    string query = "insert into DonorTable values('"+ textBoxName.Text + "','" + textBoxAge.Text + "','" + textBoxPhone.Text + "','" + comboBoxGender.Text + "','" + comboBoxBlood.Text + "','" + textBoxAddress.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    labelStatus.Text = "Account successfully created";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    labelStatus.Text = ex.Message;
                    conn.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainFormAdmin();
            form.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.Show();
        }

        private void comboBoxBlood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
