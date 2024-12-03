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
    public partial class RecordItemDetailsForm : Form
    {
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        MySqlConnection conn;
        int patID, prescripID;
        string currentRefill;
        public RecordItemDetailsForm(int patID, int prescripID)
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);

            this.patID = patID;
            this.prescripID = prescripID;

            fillInfo(conn);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            refillsTextBox.Enabled = true;
            saveButton.Enabled = true;
            editButton.Enabled = false;
            currentRefill = refillsTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            refillsTextBox.Enabled = false;
            saveButton.Enabled = false;
            editButton.Enabled = true;

            bool changed = false;

            if (!refillsTextBox.Text.Equals(currentRefill))
            {
                changed = true;
                detailsTextBox.Clear();
                conn.Open();

                string updateRefillsStr = "UPDATE 340_rrdc_prescriptions SET Refills = @amt, LastModified = CURRENT_TIMESTAMP()";
                MySqlCommand updateRefillsCmd = new MySqlCommand(updateRefillsStr, conn);

                updateRefillsCmd.Parameters.AddWithValue("@amt", Int16.Parse(refillsTextBox.Text));

                updateRefillsCmd.ExecuteNonQuery();

                conn.Close();
            }

            if (changed)
            {
                fillInfo(conn);
            }
        }

        private void fillInfo(MySqlConnection conn)
        {
            conn.Open();

            string prescripInfoStr = "SELECT 340_rrdc_patients.FirstName, 340_rrdc_patients.LastName, LastModified, Refills FROM 340_rrdc_prescriptions " +
                "INNER JOIN 340_rrdc_patients ON PatientID = 340_rrdc_patients.ID WHERE PatientID = @id";
            MySqlCommand prescripInfoCmd = new MySqlCommand(prescripInfoStr, conn);

            prescripInfoCmd.Parameters.AddWithValue("@id", patID);

            MySqlDataReader prescripInfo = prescripInfoCmd.ExecuteReader();

            if (prescripInfo.Read())
            {
                recordInfoLabel.Text = "Prescription for " + prescripInfo.GetString(prescripInfo.GetOrdinal("FirstName")) + " " +
                    prescripInfo.GetString(prescripInfo.GetOrdinal("LastName")) + "; Last modified " +
                    prescripInfo.GetDateTime(prescripInfo.GetOrdinal("LastModified")).ToString();

                refillsTextBox.Text = prescripInfo.GetInt16(prescripInfo.GetOrdinal("Refills")).ToString();
            }

            prescripInfo.Close();

            string prescripDetailsStr = "SELECT amount, 340_rrdc_medicine.name, dosage, instructions FROM 340_rrdc_medicine INNER JOIN 340_rrdc_prescriptions ON " +
                "PrescriptionID = 340_rrdc_prescriptions.ID WHERE PrescriptionID = @preID";
            MySqlCommand prescripDetailsCmd = new MySqlCommand(prescripDetailsStr, conn);

            prescripDetailsCmd.Parameters.AddWithValue("@preID", prescripID);

            MySqlDataReader prescripDetails = prescripDetailsCmd.ExecuteReader();

            while (prescripDetails.Read())
            {
                detailsTextBox.Text += prescripDetails.GetInt16(prescripDetails.GetOrdinal("amount")) + " " +
                    prescripDetails.GetString(prescripDetails.GetOrdinal("name")) + ", " + prescripDetails.GetInt16(prescripDetails.GetOrdinal("dosage")) +
                    "mg. \n" + prescripDetails.GetString(prescripDetails.GetOrdinal("instructions")) + ".\n";
            }

            conn.Close();
        }
    }
}
