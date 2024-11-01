﻿using System;
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
    public partial class ViewHistoryPage : Form
    {
        private int currentId;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public ViewHistoryPage(int id)
        {
            InitializeComponent();
            currentId = id;
            populate();
        }

        private void populate()
        {
            conn.Open();
            string query;
            query = "select CenterTable.CName, TransactionTable.Date, TransactionTable.Hour from TransactionTable join CenterTable on TransactionTable.CNum=CenterTable.CNum where TransactionTable.DNum='" + currentId + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewHistory.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new InfoDonor(currentId);
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DonatePage(currentId);
            f.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MedicalReportPage(currentId);
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void ViewHistoryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
