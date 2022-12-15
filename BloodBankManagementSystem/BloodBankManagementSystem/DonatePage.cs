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
    public partial class DonatePage : Form
    {
        private int currentID;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BloodBankDatabase.mdf"";Integrated Security=True");
        public DonatePage(int id)
        {
            InitializeComponent();
            currentID = id;
            populate();
        }

        private void populate()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM CenterTable", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                centerComboBox.Items.Add(reader["CName"].ToString());
            }
            monthCalendarPicker.MaxSelectionCount = 1;

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new InfoDonor(currentID);
            f.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ViewHistoryPage(currentID);
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MedicalReportPage(currentID);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private int getSelectedCenterID()
        {
            conn.Open();
            String querry = "SELECT CNum FROM CenterTable WHERE CName='" + centerComboBox.Text + "'";
            SqlCommand command = new SqlCommand(querry, conn);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int Cnum = Int32.Parse(reader["CNum"].ToString());
                conn.Close();
                return Cnum;
            }


            return -1;

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            
        }

        private void DonatePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (centerComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = " Please select a center!!!!";
            }
            else if (monthCalendarPicker.SelectionRange.Start <= DateTime.Today)
            {
                errorLabel.Text = "Please select a valid date";
            }
            else if (HourComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select an hour";
            }
            else
            {

                try
                {
                    string query = "insert into TransactionTable (DNum,CNum,Date,Hour) " +
                    "values('" + currentID + "','" + getSelectedCenterID() + "','" + monthCalendarPicker.SelectionRange.Start.ToString() + "','" + HourComboBox.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    errorLabel.Text = "Appointemen succesfully made!";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                    Console.WriteLine(ex.Message);
                    conn.Close();
                }
            }

        }
    }
}
