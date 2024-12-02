using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacySubsystem
{
    public partial class FillPatientPrescriptionForm : Form
    {
        private string connectionString = "server=157.89.24.3;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        private string selectedPatientName = "";
        private string selectedPrescriptionName = "";
        private int selectedPatientID = -1;
        private int selectedPrescriptionID = -1;
        private int selectedPrescriptionRefills = -1;
        public FillPatientPrescriptionForm()
        {
            InitializeComponent();
            populatePatientComboBox();
        }

        private void populatePatientComboBox()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string patientQuery = "SELECT ID, FirstName, MiddleName, LastName FROM 340_rrdc_patients";

                    using (var command = new MySqlCommand(patientQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Clear the ComboBox
                            fillPatientPrescriptionPatientsComboBox.Items.Clear();

                            while (reader.Read())
                            {
                                // Fetch patient details
                                int patientID = reader.GetInt32("ID");
                                string firstName = reader.GetString("FirstName");
                                string middleName = reader.GetString("MiddleName");
                                string lastName = reader.GetString("LastName");
                                string middleInitial = !string.IsNullOrEmpty(middleName)
                                    ? middleName[0].ToString() + "."
                                    : "";

                                string patientDisplayString = $"{firstName} {middleInitial} {lastName}";
                                selectedPatientName = $"{firstName} {lastName}";

                                // Add patient as a KeyValuePair
                                fillPatientPrescriptionPatientsComboBox.Items.Add(
                                    new KeyValuePair<int, string>(patientID, patientDisplayString));
                            }
                        }
                    }

                    // Set the ComboBox DisplayMember and ValueMember
                    fillPatientPrescriptionPatientsComboBox.DisplayMember = "Value"; // Show patient name
                    fillPatientPrescriptionPatientsComboBox.ValueMember = "Key";    // Use patient ID as the value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching patients: {ex.Message}");
            }
        }


        private void fillPatientPrescriptionPatientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fillPatientPrescriptionPatientsComboBox.SelectedIndex != -1)
            {
                // Get the selected KeyValuePair
                var selectedPatient = (KeyValuePair<int, string>)fillPatientPrescriptionPatientsComboBox.SelectedItem;

                // Extract the PatientID
                selectedPatientID = selectedPatient.Key;
                selectedPatientName = selectedPatient.Value;

                // Populate the prescriptions ComboBox for the selected patient
                populatePrescriptionsComboBox();
            }
        }

        private void populatePrescriptionsComboBox()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string prescriptionsQuery =
                        "SELECT Refills, Name, ID FROM 340_rrdc_prescriptions WHERE PatientID = @PatientID";

                    MessageBox.Show($"Selected patient ID: {selectedPatientID}");

                    using (var command = new MySqlCommand(prescriptionsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", selectedPatientID);

                        using (var reader = command.ExecuteReader())
                        {
                            // Clear the prescriptions combobox
                            fillPatientPrescriptionPrescriptionsComboBox.Items.Clear();

                            // Enable the prescriptions combo box
                            fillPatientPrescriptionPrescriptionsComboBox.Enabled = true;

                            while (reader.Read())
                            {
                                // Fetch prescription details
                                int prescriptionRefills = reader.GetInt32("Refills");
                                string prescriptionName = reader.GetString("Name");
                                int prescriptionID = reader.GetInt32("ID");

                                var prescriptionKey = new int[] { prescriptionID, prescriptionRefills};
                                var prescriptionValue = prescriptionName;

                                fillPatientPrescriptionPrescriptionsComboBox.Items.Add(
                                    new KeyValuePair<int[], string>(prescriptionKey, prescriptionValue));
                            }
                        }
                    }
                    fillPatientPrescriptionPrescriptionsComboBox.DisplayMember = "Value"; // Show prescription name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching prescription details: {ex.Message}");
            }
        }

        private void fillPatientPrescriptionsFillButton_Click(object sender, EventArgs e)
        {
            if (selectedPatientID == -1 || selectedPrescriptionID == -1)
            {
                MessageBox.Show("You must select a patient and a prescription first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (selectedPrescriptionRefills <= 0)
                {
                    DialogResult result = MessageBox.Show("The selected prescription has no remaining refills. Send a refill request to the doctor?", "No Remaining Refills", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Send refill request logic
                        try
                        {
                            using (var connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                // prepare the insert query
                                string insertRequestQuery =
                                    "INSERT INTO 340_rrdc_requests (RequestType, Reason) " +
                                   "VALUES (@RequestType, @Reason)";

                                using (var command = new MySqlCommand(insertRequestQuery, connection))
                                {
                                    // Build the reason string
                                    string reason =
                                        $"Patient {selectedPatientName} is requesting a refill of {selectedPrescriptionName}.";

                                    // Add params
                                    command.Parameters.AddWithValue("@RequestType", 1);
                                    command.Parameters.AddWithValue("@Reason", reason);

                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Refill request send to the doctor successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to send the refill request.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while sending the refill request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Database logic for decrementing Refills
                    try
                    {
                        using (var connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Decrement refill count
                            string updateRefillQuery =
                                "UPDATE 340_rrdc_prescriptions SET Refills = @newRefillCount WHERE ID = @PrescriptionID";
                            using (var command = new MySqlCommand(updateRefillQuery, connection))
                            {
                                command.Parameters.AddWithValue("@PrescriptionID", selectedPrescriptionID);
                                command.Parameters.AddWithValue("@newRefillCount", selectedPrescriptionRefills - 1);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Prescription filled successfully.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Close the form
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update prescription refills.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured while filling the prescription: {ex.Message}");
                    }
                }
            }
        }

        private void fillPatientPrescriptionPrescriptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fillPatientPrescriptionPrescriptionsComboBox.SelectedIndex != -1)
            {
                // Get the selected KeyValuePair
                var selectedPrescription = (KeyValuePair<int[], string>)fillPatientPrescriptionPrescriptionsComboBox.SelectedItem;

                // Extract the values
                int[] prescriptionKey = selectedPrescription.Key;
                selectedPrescriptionID = prescriptionKey[0];
                selectedPrescriptionRefills = prescriptionKey[1];
                selectedPrescriptionName = selectedPrescription.Value;

                MessageBox.Show($"Selected Prescription: {selectedPrescriptionName}\nPrescription ID: {selectedPrescriptionID}\nRefills: {selectedPrescriptionRefills}",
                    "Prescription Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
