using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class MainFormDonor : Form
    {
        private string currentUsername;
        public MainFormDonor(string username)
        {
            InitializeComponent();
            currentUsername = username;
            label6.Text = currentUsername;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new InfoDonor(currentUsername);
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DonatePage(currentUsername);
            f.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewHistoryPage(currentUsername);
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MedicalReportPage(currentUsername);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            label6.Text = currentUsername;
        }
    }
}
