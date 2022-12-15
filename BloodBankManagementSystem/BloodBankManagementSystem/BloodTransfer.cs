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
    public partial class BloodTransfer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public BloodTransfer()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            //transfusion
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TransactionTable where TransactionTable.PNum is null", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxTransfusionID.Items.Add(reader["TNum"].ToString());
            }
            conn.Close();
            
            //pacient
            conn.Open();
            command = new SqlCommand("SELECT * FROM PatientTable", conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPatientID.Items.Add(reader["PNum"].ToString());
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

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewPacients();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BloodTransfer();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddPacients();
            f.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddMedicalReports();
            f.Show();
        }

        private void comboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT PName, PGroup FROM PatientTable where PNum=@id", conn);
            command.Parameters.AddWithValue("id", comboBoxPatientID.Text);

            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBoxBloodPatient.Text = reader["PGroup"].ToString();
                textBoxPatientName.Text = reader["PName"].ToString();
            }
            conn.Close();

        }

        private void comboBoxTransfusionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT DName, DGroup FROM DonorTable join TransactionTable on DonorTable.DNum=TransactionTable.DNum where TNum=@id ", conn);
            command.Parameters.AddWithValue("id", comboBoxTransfusionID.Text);

            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBoxBloodDonor.Text = reader["DGroup"].ToString();
                textBoxDonorName.Text = reader["DName"].ToString();
            }
            conn.Close();

        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update TransactionTable set PNum=@id where TNum=@tid", conn);
            command.Parameters.AddWithValue("id", comboBoxPatientID.Text);
            command.Parameters.AddWithValue("tid", comboBoxTransfusionID.Text);

            if (comboBoxPatientID.Text==""||comboBoxTransfusionID.Text=="")
            {
                labelStatus.Text = "Please complete all data";
            }
            else if (textBoxBloodDonor.Text!=textBoxBloodPatient.Text)
            {
                labelStatus.Text = "Patient and Donor must have the same Blood Group";
            }
            else
            {
                command.ExecuteNonQuery();
                labelStatus.Text = "Transaction made successfully";
            }
            conn.Close();

        }
    }
}
