using MySql.Data.MySqlClient;
using System.Configuration;

namespace PharmacySubsystem
{
    public partial class PharmacyAppMainForm : Form
    {
        private string connectionString = "server=157.89.24.3;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        private List<string[]> patientList = new List<string[]>(); // Each patient is a string array : [LastName, MiddleName, FirstName, ID]
        private int lastPatientCount = -1;

        public PharmacyAppMainForm()
        {
            InitializeComponent();

            // Start DB polling timers
            newPrescriptionPollingTimer.Tick += newPrescriptionPollingTimerTick;
            newPrescriptionPollingTimer.Interval = 5000;
            newPrescriptionPollingTimer.Start();

            patientListingPollingTimer.Tick += patientListingPollingTimerTick;
            patientListingPollingTimer.Interval = 5000;
            patientListingPollingTimer.Start();
        }

        private void patientListingPollingTimerTick(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string countQuery = "SELECT COUNT(*) FROM 340_rrdc_patients";
                    using (var countCommand = new MySqlCommand(countQuery, connection))
                    {
                        int currentPatientCount = Convert.ToInt32(countCommand.ExecuteScalar());

                        Console.WriteLine($"Count: {currentPatientCount}");
                        // Count logic
                        if (currentPatientCount != lastPatientCount)
                        {
                            lastPatientCount = currentPatientCount;
                            fetchAndUpdatePatientListing();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while polling database for patient count: {ex.Message}");
            }
        }

        private void fetchAndUpdatePatientListing()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string patientQuery = "SELECT LastName, MiddleName, FirstName, ID FROM 340_rrdc_patients";
                    using (var command = new MySqlCommand(patientQuery, connection))
                    {
                        var newPatientList = new List<string[]>();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] patient = new string[]
                                {
                                    reader.GetString("LastName"),
                                    reader.GetString("MiddleName"),
                                    reader.GetString("FirstName"),
                                    reader.GetInt32("ID").ToString()
                                };
                                newPatientList.Add(patient);
                            }
                        }

                        // Update the patient listing and refresh the list view
                        patientList = newPatientList;
                        populatePatientListView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while fetching patient list: {ex.Message}");
            }
        }

        private void notifyPatientButton_Click(object sender, EventArgs e)
        {
            // Make sure a patient has been selected
            if (patientListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a patient to notify.", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the selected patient's details from the list view
                var selectedPatientItem = patientListView.SelectedItems[0];
                string lastName = selectedPatientItem.Text;
                string middleName = selectedPatientItem.SubItems[1].Text;
                string firstName = selectedPatientItem.SubItems[2].Text;

                string patientID =
                    patientList.FirstOrDefault(p => p[0] == lastName && p[1] == middleName && p[2] == firstName)?[3];

                if (string.IsNullOrEmpty(patientID))
                {
                    MessageBox.Show("Unable to find the patient ID.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Notify the patient
                string middleInitial = !string.IsNullOrEmpty(middleName) ? middleName[0].ToString() + "." : "";
                string message = $"Notifying {firstName} {middleInitial} {lastName}";

                MessageBox.Show(message, "Patient Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Add logic here to send notification to patient
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while notifying the patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newPrescriptionArrivalButton_Click(object sender, EventArgs e)
        {
            if (newPrescriptionArrivalButton.BackColor == Color.Yellow)
            {
                // Retrieve patient details
                string firstName = "";
                string middleName = "";
                string lastName = "";
                int prescriptionID = -1;

                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string mostRecentPrescriptionQuery =
                            "SELECT p.FirstName, p.MiddleName, p.LastName, pr.ID " +
                            "FROM 340_rrdc_prescriptions pr " +
                            "JOIN 340_rrdc_patients p ON pr.PatientID = p.ID " +
                            "WHERE pr.Pending = 1 " +
                            "ORDER BY pr.ID DESC " +
                            "LIMIT 1";
                        using (var command = new MySqlCommand(mostRecentPrescriptionQuery, connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    firstName = reader.GetString("FirstName");
                                    middleName = reader.GetString("MiddleName");
                                    lastName = reader.GetString("LastName");
                                    prescriptionID = reader.GetInt32("ID");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving prescription details: {ex.Message}");
                    return;
                }

                // Derive the middle initial
                string middleInitial = !string.IsNullOrEmpty(middleName) ? middleName[0].ToString() + "." : "";

                // Build the dialog message
                string message = $"{firstName} {middleInitial} {lastName} has a new prescription. Do you want to send an acknowledgement to the doctor?";

                DialogResult result = MessageBox.Show(
                    message,
                    "New Prescription Acknowledgement Notification",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Acknowledgement was sent to the doctor.");

                    // Set pending to 0 logic
                    try
                    {
                        using (var connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string updatePendingStatusQuery =
                                "UPDATE 340_rrdc_prescriptions SET Pending = 0 WHERE ID = @PrescriptionID";
                            using (var updateCommand = new MySqlCommand(updatePendingStatusQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Prescription status updated successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update prescription status");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating prescription status: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no new prescriptions.", "No New Rx Notifications",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void populatePatientListView()
        {
            patientListView.Items.Clear();

            foreach (var patient in patientList)
            {
                var patientItem = new ListViewItem(patient[0]); // LastName
                patientItem.SubItems.Add(patient[1]); // Middle Name
                patientItem.SubItems.Add(patient[2]); // FirstName
                patientListView.Items.Add(patientItem);
            }
        }

        private void newPrescriptionPollingTimerTick(object sender, EventArgs e)
        {
            checkForNewPrescriptions();
        }

        private void checkForNewPrescriptions()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM 340_rrdc_prescriptions WHERE Pending = 1";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Execute the query
                        int pendingPrescriptionCount = Convert.ToInt32(command.ExecuteScalar());

                        if (pendingPrescriptionCount > 0)
                        {
                            // Change the new prescription button color to yellow
                            newPrescriptionArrivalButton.BackColor = Color.Yellow;
                            newPrescriptionArrivalButton.ForeColor = Color.Black;
                        }
                        else
                        {
                            // Reset the new prescription button to original color
                            newPrescriptionArrivalButton.BackColor = Color.FromArgb(22, 22, 22);
                            newPrescriptionArrivalButton.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while polling database for new prescriptions: {ex.Message}");
            }
        }

        private void fillPatientPrescriptionButton_Click(object sender, EventArgs e)
        {
            FillPatientPrescriptionForm fillPatientPrescriptionForm = new FillPatientPrescriptionForm();
            fillPatientPrescriptionForm.Show();
        }
    }
}
