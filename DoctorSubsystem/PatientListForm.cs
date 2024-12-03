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
    public partial class PatientListForm : Form
    {
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        MySqlConnection conn;
        int[] patIDs;
        public PatientListForm()
        {
            InitializeComponent();

            //get count of patients for IDs later, and list patients in the list view
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string countPatientsStr = "SELECT COUNT(*) FROM 340_rrdc_patients";
                MySqlCommand countPatientsCmd = new MySqlCommand(countPatientsStr, conn);

                MySqlDataReader patientCount = countPatientsCmd.ExecuteReader();

                if (patientCount.Read())
                {
                    patIDs = new int[patientCount.GetInt32(0)];
                }

                patientCount.Close();

                string getPatientsStr = "SELECT * FROM 340_rrdc_patients ORDER BY LastName";
                MySqlCommand getPatientsCmd = new MySqlCommand(getPatientsStr, conn);

                MySqlDataReader patientData = getPatientsCmd.ExecuteReader();

                displayPatients(patientData);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //take input in the text box to search patients by last name
        private void button1_Click(object sender, EventArgs e)
        {
            //search by last name
            string searchQuery = searchBox.Text;

            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string getPatientsStr = "SELECT * FROM 340_rrdc_patients WHERE LastName = @search ORDER BY LastName";
                MySqlCommand getPatientsCmd = new MySqlCommand(getPatientsStr, conn);

                getPatientsCmd.Parameters.AddWithValue("@search", searchQuery);

                MySqlDataReader patientData = getPatientsCmd.ExecuteReader();

                displayPatients(patientData);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //opens the record of the patient selected in the list view
        private void OpenRecordButton_Click(object sender, EventArgs e)
        {
            int selectedID = patIDs[patientListView.SelectedIndices[0]];
            Form patientRecord = new PatientRecordForm(selectedID);
            patientRecord.Show();
        }

        //display read patients
        private void displayPatients(MySqlDataReader reader)
        {
            patientListView.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                string[] newItem = { reader.GetString(reader.GetOrdinal("LastName")), reader.GetString(reader.GetOrdinal("FirstName")).ToString(),
                    reader.GetDateTime(reader.GetOrdinal("DOB")).ToString("MM/dd/yyyy"), reader.GetString(reader.GetOrdinal("InsuranceCardNumber")),
                    reader.GetString(reader.GetOrdinal("Sex")) };
                patIDs[i++] = reader.GetInt32(reader.GetOrdinal("ID"));
                ListViewItem lvi = new ListViewItem(newItem);
                patientListView.Items.Add(lvi);
            }
        }

        //go back to showing all patients (used to get back from a search)
        private void showAllButton_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string getPatientsStr = "SELECT * FROM 340_rrdc_patients ORDER BY LastName";
                MySqlCommand getPatientsCmd = new MySqlCommand(getPatientsStr, conn);

                MySqlDataReader patientData = getPatientsCmd.ExecuteReader();

                displayPatients(patientData);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
