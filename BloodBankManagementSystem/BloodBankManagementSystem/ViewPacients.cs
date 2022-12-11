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
    public partial class ViewPacients : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Nicoleta\Desktop\UPT\S5\DB\Proiect Merge\BloodBankManagementSystem\BloodBankManagementSystem\BloodBankDatabase.mdf"";Integrated Security=True");
        public ViewPacients()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            conn.Open();
            string query;
            query = "select PatientTable.PNum, PatientTable.PName, PatientTable.PAge, PatientTable.PPhone, PatientTable.PGender,PatientTable.PGroup from PatientTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewPatients.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewDonors();
            f.Show();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
