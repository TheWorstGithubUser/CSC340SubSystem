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
        int patID;
        int[] prescripIDs;
        public PatientRecordForm(int patID)
        {
            InitializeComponent();
            this.patID = patID;

            conn = new MySqlConnection(connStr);

            //fill record and pending prescriptions (ones that haven't been added to record yet) in their respective list views
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

                patientName.Close();

                fillRecordsTable(conn);

                string getPendingStr = "SELECT ID, Pending FROM 340_rrdc_prescriptions WHERE PatientID = @id AND Received = 0 ORDER BY LastModified DESC";
                MySqlCommand getPendingCmd = new MySqlCommand(getPendingStr, conn);

                getPendingCmd.Parameters.AddWithValue("@id", patID);

                MySqlDataReader patientPendings = getPendingCmd.ExecuteReader();

                while (patientPendings.Read())
                {
                    pendingView.Items.Clear();

                    string pendingAlpha;

                    if(patientPendings.GetInt16(1) == 1)
                    {
                        pendingAlpha = "Y";
                    }
                    else
                    {
                        pendingAlpha = "N";
                    }

                    string[] newItem = { "Prescription #" + patientPendings.GetInt32(0), pendingAlpha };
                    ListViewItem lvi = new ListViewItem(newItem);
                    pendingView.Items.Add(lvi);
                }

                patientPendings.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //open record details from record list view
        private void button2_Click(object sender, EventArgs e)
        {
            Form recordItemDetailsForm = new RecordItemDetailsForm(patID, prescripIDs[recordView.SelectedIndices[0]]);
            recordItemDetailsForm.Show();
        }

        //move a pending prescription to the record
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem prescription = pendingView.SelectedItems[0];
            pendingView.SelectedItems[0].Remove();

            conn.Open();

            string changePendingStr = "UPDATE 340_rrdc_prescriptions SET LastModified = CURRENT_TIMESTAMP, Received = 1, Pending = 0 WHERE ID = @id";
            MySqlCommand changePendingCmd = new MySqlCommand(changePendingStr, conn);

            changePendingCmd.Parameters.AddWithValue("@id", Int32.Parse(prescription.Text.Substring(prescription.Text.IndexOf('#') + 1)));

            changePendingCmd.ExecuteNonQuery();

            fillRecordsTable(conn);

            moveToRecordButton.Enabled = false;
        }

        //open the details of a pending prescription
        private void button3_Click(object sender, EventArgs e)
        {
            Form recordItemDetailsForm = new RecordItemDetailsForm(patID, prescripIDs[recordView.SelectedIndices[0]]);
            recordItemDetailsForm.Show();
        }
        
        //input validation for moving pending to record
        private void pendingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveToRecordButton.Enabled = true;
        }

        //add members of the patients record to the list view
        private void fillRecordsTable(MySqlConnection conn)
        {
            string initIDArrayStr = "SELECT COUNT(*) FROM 340_rrdc_prescriptions WHERE PatientID = @id AND Received = 1 ORDER BY LastModified DESC";
            MySqlCommand initIDArrayCmd = new MySqlCommand(initIDArrayStr, conn);
            initIDArrayCmd.Parameters.AddWithValue("@id", patID);
            MySqlDataReader countRelevant = initIDArrayCmd.ExecuteReader();
            if (countRelevant.Read())
            {
                prescripIDs = new int[countRelevant.GetInt32(0)];
            }
            countRelevant.Close();

            recordView.Items.Clear();
            string getRecordStr = "SELECT LastModified, ID FROM 340_rrdc_prescriptions WHERE PatientID = @id AND Received = 1 ORDER BY LastModified DESC";
            MySqlCommand getRecordCmd = new MySqlCommand(getRecordStr, conn);

            getRecordCmd.Parameters.AddWithValue("@id", patID);

            MySqlDataReader patientRecords = getRecordCmd.ExecuteReader();

            int i = 0;
            while (patientRecords.Read())
            {
                string[] newItem = { patientRecords.GetDateTime(0).ToString("MM/dd/yyyy"), "Prescription" };
                ListViewItem lvi = new ListViewItem(newItem);
                recordView.Items.Add(lvi);
                prescripIDs[i++] = patientRecords.GetInt32(patientRecords.GetOrdinal("ID"));
            }

            patientRecords.Close();
        }

    }
}
