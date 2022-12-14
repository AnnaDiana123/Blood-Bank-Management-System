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
    public partial class AddMedicalReports : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public AddMedicalReports()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TransactionTable", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxTransferID.Items.Add(reader["TNum"].ToString());
            }
            conn.Close();
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddPacients();
            f.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTransferID.Text == "" || textBoxResult1.Text == "" || textBoxResult2.Text == "" || textBoxResult3.Text == "" || textBoxResult4.Text == "")
            {
                labelStatus.Text = "You must add all the results!";
            }
            else
            {
                try
                {
                    string query = "insert into ReportTable values('" + textBoxResult1.Text + "','" + textBoxResult2.Text + "','" + textBoxResult3.Text + "','" + textBoxResult4.Text + "','" +  comboBoxTransferID.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    labelStatus.Text = "Results added successfully";
                }
                catch (Exception ex)
                {
                    labelStatus.Text = ex.Message;
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
