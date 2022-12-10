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
    public partial class ViewDonors : Form
    {
        public ViewDonors()
        {
            InitializeComponent();
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
    }
}
