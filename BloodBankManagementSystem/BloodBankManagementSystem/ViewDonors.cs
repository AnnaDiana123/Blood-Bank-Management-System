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
    public partial class ViewDonors : Form
    {
        SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public ViewDonors()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            conn.Open();
            string query;
            query = "select DonorTable.DNum, DonorTable.DName, DonorTable.DAge, DonorTable.DPhone, DonorTable.DGender,DonorTable.DGroup from DonorTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewDonors.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ViewPacients();
            form.Show();
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

        private void ViewDonors_Load(object sender, EventArgs e)
        {

        }
    }
}
