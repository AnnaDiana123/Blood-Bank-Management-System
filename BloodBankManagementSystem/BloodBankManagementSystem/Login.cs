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
    public partial class Login : Form
    {
        public Login()
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
            this.Hide();
            Form f1 = new MainFormDonor(textBox1.Text);
            f1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainFormAdmin();
            form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CreateAccount();
            form.Show();
        }
    }
}
