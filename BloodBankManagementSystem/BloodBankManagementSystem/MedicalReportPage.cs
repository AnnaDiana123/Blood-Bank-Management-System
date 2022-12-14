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
    public partial class MedicalReportPage : Form
    {
        private int currentID;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public MedicalReportPage(int id)
        {
            InitializeComponent();
            currentID = id;
            populate();
        }
        private void populate()
        {
            conn.Open();
            string query;
            query = "select Date, RResult1,RResult2, RResult3,RResult4 from ReportTable join TransactionTable on TransactionTable.TNum=ReportTable.TNum join DonorTable on DonorTable.DNum=TransactionTable.DNum where DonorTable.DNum='"+currentID.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new InfoDonor(currentID);
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DonatePage(currentID);
            f.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewHistoryPage(currentID);
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void bloodlogo_Click(object sender, EventArgs e)
        {

        }
    }
}
