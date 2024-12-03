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
    public partial class CreatePrescriptionForm : Form
    {
        MySqlConnection conn;
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
        int[] patIDs;
        int[] medIDs;
        List<Int32> medsToAdd = new List<Int32>();

        public CreatePrescriptionForm()
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);

            conn.Open();

            string numPatStr = "SELECT COUNT(*) FROM 340_rrdc_patients";
            MySqlCommand numPatCmd = new MySqlCommand(numPatStr, conn);
            MySqlDataReader numPatRdr = numPatCmd.ExecuteReader();
            if (numPatRdr.Read())
                patIDs = new int[numPatRdr.GetInt32(0)];

            numPatRdr.Close();

            string namesDropdownStr = "SELECT ID, FirstName, LastName FROM 340_rrdc_patients ORDER BY LastName";
            MySqlCommand namesDropdownCmd = new MySqlCommand(namesDropdownStr, conn);

            MySqlDataReader namesDropdownRdr = namesDropdownCmd.ExecuteReader();

            int i = 0;
            while (namesDropdownRdr.Read())
            {
                patIDs[i++] = namesDropdownRdr.GetInt32(namesDropdownRdr.GetOrdinal("ID"));

                patientsComboBox.Items.Add(namesDropdownRdr.GetString(namesDropdownRdr.GetOrdinal("LastName")) + ", " +
                    namesDropdownRdr.GetString(namesDropdownRdr.GetOrdinal("FirstName")));
            }

            namesDropdownRdr.Close();

            string numMedsStr = "SELECT COUNT(*) FROM 340_rrdc_medicine";
            MySqlCommand numMedsCmd = new MySqlCommand(numMedsStr, conn);
            MySqlDataReader numMedsRdr = numMedsCmd.ExecuteReader();
            if (numMedsRdr.Read())
                medIDs = new int[numMedsRdr.GetInt32(0)];
            numMedsRdr.Close();

            string medsDropdownStr = "SELECT MedicineID, name, dosage, amount, instructions FROM 340_rrdc_medicine ORDER BY amount";
            MySqlCommand medsDropdownCmd = new MySqlCommand(medsDropdownStr, conn);
            MySqlDataReader medsDropdownRdr = medsDropdownCmd.ExecuteReader();

            i = 0;
            while (medsDropdownRdr.Read())
            {
                existingMedCombo.Items.Add(medsDropdownRdr.GetInt16(medsDropdownRdr.GetOrdinal("amount")) + " " +
                    medsDropdownRdr.GetString(medsDropdownRdr.GetOrdinal("name")) + " " + medsDropdownRdr.GetInt16(medsDropdownRdr.GetOrdinal("dosage")) + "; " +
                    medsDropdownRdr.GetString(medsDropdownRdr.GetOrdinal("instructions")));
                medIDs[i++] = medsDropdownRdr.GetInt32(medsDropdownRdr.GetOrdinal("MedicineID"));
            }

            conn.Close();
        }

        private void patientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prescripNameBox.Enabled = true;
            prescripNameLabel.Enabled = true;
            numRefillsBox.Enabled = true;
            refillsLabel.Enabled = true;
            refillDateCheck.Enabled = true;
            existingMedRadio.Enabled = true;
            newMedRadio.Enabled = true;
        }

        private void medNameBox_TextChanged(object sender, EventArgs e)
        {
            checkMedInfoFilled();
        }

        private void dosageBox_TextChanged(object sender, EventArgs e)
        {
            checkMedInfoFilled();
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            checkMedInfoFilled();
        }

        private void instructionsBox_TextChanged(object sender, EventArgs e)
        {
            checkMedInfoFilled();
        }

        private void checkMedInfoFilled()
        {
            if (!medNameBox.Text.Equals("") && !dosageBox.Text.Equals("") && !amountBox.Text.Equals("") && !instructionsBox.Text.Equals(""))
                addMedicineButton.Enabled = true;
            else
                addMedicineButton.Enabled = false;
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand addMedCmd;
            MySqlDataReader addMedRdr;
            int medIDtoAdd;

            if (newMedRadio.Checked)
            {
                string newMedStr = "INSERT INTO 340_rrdc_medicine (name, dosage, amount, instructions) VALUES (@name, @dose, @amt, @instr)";
                addMedCmd = new MySqlCommand(newMedStr, conn);

                addMedCmd.Parameters.AddWithValue("@name", medNameBox.Text);
                addMedCmd.Parameters.AddWithValue("@dose", Int16.Parse(dosageBox.Text));
                addMedCmd.Parameters.AddWithValue("@amt", Int16.Parse(amountBox.Text));
                addMedCmd.Parameters.AddWithValue("@instr", instructionsBox.Text);

                addMedCmd.ExecuteNonQuery();

                string getAddedMedStr = "SELECT MedicineID FROM 340_rrdc_medicine ORDER BY MedicineID DESC LIMIT 1";
                MySqlCommand getAddedMedCmd = new MySqlCommand(getAddedMedStr, conn);
                MySqlDataReader getAddedMedRdr = getAddedMedCmd.ExecuteReader();
                if (getAddedMedRdr.Read())
                    medsToAdd.Add(getAddedMedRdr.GetInt32(0));
                getAddedMedRdr.Close();

                medNameBox.Clear();
                dosageBox.Clear();
                amountBox.Clear();
                instructionsBox.Clear();
                addMedicineButton.Enabled = false;
            }
            else
            {
                medsToAdd.Add(medIDs[existingMedCombo.SelectedIndex]);
            }

            string medIDsToQuery = "";
            foreach(int m in medsToAdd)
            {
                medIDsToQuery += m + ", ";
            }

            medIDsToQuery = medIDsToQuery.Substring(0, medIDsToQuery.Length - 2);
            Console.WriteLine(medIDsToQuery);

            //not worried about injection here because the values going in are ints generated by the database
            string displayAddedMedStr = "SELECT name, dosage, amount, instructions FROM 340_rrdc_medicine WHERE MedicineID IN ("+medIDsToQuery+")";
            MySqlCommand displayAddedMedCmd = new MySqlCommand(displayAddedMedStr, conn);
            MySqlDataReader displayAddedMedRdr = displayAddedMedCmd.ExecuteReader();

            medicineListView.Items.Clear();

            while (displayAddedMedRdr.Read())
            {
                string[] newItem = { displayAddedMedRdr.GetString(displayAddedMedRdr.GetOrdinal("name")), 
                    displayAddedMedRdr.GetInt16(displayAddedMedRdr.GetOrdinal("dosage")).ToString(), 
                    displayAddedMedRdr.GetInt16(displayAddedMedRdr.GetOrdinal("amount")).ToString(),
                    displayAddedMedRdr.GetString(displayAddedMedRdr.GetOrdinal("instructions"))};
                ListViewItem lvi = new ListViewItem(newItem);
                medicineListView.Items.Add(lvi);
            }

            conn.Close();

            prescripReady();

        }

        private void existingMedCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            addMedicineButton.Enabled = true;
        }

        private void existingMedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (existingMedRadio.Checked)
            {
                existingMedCombo.Enabled = true;
                if(existingMedCombo.SelectedIndex != -1)
                {
                    addMedicineButton.Enabled = true;
                }
            }
            else
                existingMedCombo.Enabled = false;
        }

        private void newMedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (newMedRadio.Checked)
            {
                medNameBox.Enabled = true;
                medNameLabel.Enabled = true;
                dosageBox.Enabled = true;
                dosageLabel.Enabled = true;
                amountBox.Enabled = true;
                amountLabel.Enabled = true;
                instructionsBox.Enabled = true;
                instructionsLabel.Enabled = true;
                checkMedInfoFilled();
            }
            else
            {
                medNameBox.Enabled = false;
                medNameLabel.Enabled = false;
                dosageBox.Enabled = false;
                dosageLabel.Enabled = false;
                amountBox.Enabled = false;
                amountLabel.Enabled = false;
                instructionsBox.Enabled = false;
                instructionsLabel.Enabled = false;
            }
                
        }

        private void createPrescripButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string createPrescripStr;
            MySqlCommand createPrescriptCmd;
            if (refillDateCheck.Checked)
            {
                Console.WriteLine("Refill date checked");
                if (!prescripNameBox.Text.Equals(""))
                {
                    Console.WriteLine("FilledName");
                    createPrescripStr = "INSERT INTO 340_rrdc_prescriptions (PatientID, Name, Refills, RefillDate) VALUES (@id, @name, @re, @reDate)";
                    createPrescriptCmd = new MySqlCommand(createPrescripStr, conn);

                    createPrescriptCmd.Parameters.AddWithValue("@id", patIDs[patientsComboBox.SelectedIndex]);
                    createPrescriptCmd.Parameters.AddWithValue("@name", prescripNameBox.Text);
                    createPrescriptCmd.Parameters.AddWithValue("@re", Int16.Parse(numRefillsBox.Text));
                    createPrescriptCmd.Parameters.AddWithValue("@reDate", earliestRefillPicker.Value);
                }
                else
                {
                    Console.WriteLine("EmptyName");
                    createPrescripStr = "INSERT INTO 340_rrdc_prescriptions (PatientID, Refills, RefillDate) VALUES (@id, @re, @reDate)";
                    createPrescriptCmd = new MySqlCommand(createPrescripStr, conn);

                    createPrescriptCmd.Parameters.AddWithValue("@id", patIDs[patientsComboBox.SelectedIndex]);
                    createPrescriptCmd.Parameters.AddWithValue("@re", Int16.Parse(numRefillsBox.Text));
                    createPrescriptCmd.Parameters.AddWithValue("@reDate", earliestRefillPicker.Value);
                }
            }
            else
            {
                Console.WriteLine("RefillDate Unchecked");
                if (!prescripNameBox.Text.Equals(""))
                {
                    Console.WriteLine("FilledName");
                    createPrescripStr = "INSERT INTO 340_rrdc_prescriptions (PatientID, Name, Refills) VALUES (@id, @name, @re)";
                    createPrescriptCmd = new MySqlCommand(createPrescripStr, conn);

                    createPrescriptCmd.Parameters.AddWithValue("@id", patIDs[patientsComboBox.SelectedIndex]);
                    createPrescriptCmd.Parameters.AddWithValue("@name", prescripNameBox.Text);
                    createPrescriptCmd.Parameters.AddWithValue("@re", Int16.Parse(numRefillsBox.Text));
                }
                else
                {
                    Console.WriteLine("EmptyName");
                    createPrescripStr = "INSERT INTO 340_rrdc_prescriptions (PatientID, Refills) VALUES (@id, @re)";
                    createPrescriptCmd = new MySqlCommand(createPrescripStr, conn);

                    createPrescriptCmd.Parameters.AddWithValue("@id", patIDs[patientsComboBox.SelectedIndex]);
                    createPrescriptCmd.Parameters.AddWithValue("@re", Int16.Parse(numRefillsBox.Text));
                }
            }

            createPrescriptCmd.ExecuteNonQuery();

            string notifPrescripStr = "INSERT INTO 340_rrdc_notifications (Body) VALUES (@body)";
            MySqlCommand notifPrescripCmd = new MySqlCommand(notifPrescripStr, conn);

            notifPrescripCmd.Parameters.AddWithValue("@body", "Prescription added for " + patientsComboBox.SelectedItem.ToString());

            conn.Close();

            this.Close();
        }

        private void prescripReady()
        {
            Console.WriteLine(medicineListView.Items.Count > 0);
            Console.WriteLine(!numRefillsBox.Text.Equals(""));
            if (medicineListView.Items.Count > 0 && !numRefillsBox.Text.Equals(""))
                createPrescripButton.Enabled = true;
            else
                createPrescripButton.Enabled = false;
        }

        private void medicineListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            prescripReady();
        }

        private void numRefillsBox_TextChanged(object sender, EventArgs e)
        {
            prescripReady();
        }
    }

}
