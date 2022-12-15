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

namespace BloodBankManagementSystem
{
    public partial class AddPacients : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public AddPacients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ViewDonors();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BloodTransfer();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewPacients();
            f.Show();
        }

        private void labelAddReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddMedicalReports();
            f.Show();
        }

        private void AddPacients_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text=="" || textBoxAge.Text=="" || textBoxName.Text=="" ||textBoxPhone.Text==""||comboBoxBloodGroup.Text==""||comboBoxGender.Text=="")
                labelStatus.Text = "Please fill in all info";
            else
            {
                try
                {
                    string query = "insert into PatientTable values('" + textBoxName.Text + "','" + textBoxAge.Text + "','" + textBoxPhone.Text + "','" + comboBoxGender.Text + "','" + comboBoxBloodGroup.Text + "','" + textBoxAddress.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    labelStatus.Text = "Pacient profile successfully created";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    labelStatus.Text = ex.Message;
                    Console.WriteLine(ex.Message);
                    conn.Close();
                }
            }
        }
    }
}
