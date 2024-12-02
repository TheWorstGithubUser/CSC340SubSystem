using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DoctorSubsystem_VS
{
    public partial class PatientRecordForm : Form
    {
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        MySqlConnection conn;
        public PatientRecordForm(int patID)
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string getNameStr = "SELECT FirstName, LastName FROM 340_rrdc_patients WHERE ID = @id";
                MySqlCommand getNameCmd = new MySqlCommand(getNameStr, conn);

                getNameCmd.Parameters.AddWithValue("@id", patID);

                MySqlDataReader patientName = getNameCmd.ExecuteReader();

                if (patientName.Read())
                {
                    nameLabel.Text = patientName.GetString(0) + " " + patientName.GetString(1) + "'s Record";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem prescription = listView2.SelectedItems[0];
            listView2.SelectedItems[0].Remove();
            listView1.Items.Add(prescription);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form recordItemDetailsForm = new RecordItemDetailsForm();
            recordItemDetailsForm.Show();
        }

        private void displayRecords(MySqlDataReader reader)
        {

        }
    }
}
