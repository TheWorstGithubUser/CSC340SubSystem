using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatientSubsystem
{
    public partial class Form2 : Form
    {
        int prescriptionID;
        int ID;
        string patientFName;
        string patientLName;
        string prescriptionName;
        public Form2(int patientID)
        {
            ID = patientID;
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            GetPatientPrescriptions();
            Form1 f1 = new Form1();
           
        }

        private void GetPatientPrescriptions()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM 340_rrdc_prescriptions WHERE PatientID = 1";    //assumes patientID is 1 as I do not have the login system in this build
                Console.Write(sql);

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();
                PatientPrescriptionList.AppendText("Prescriptions: \n");
                while (myReader.Read())
                {
                    PatientPrescriptionList.AppendText("Prescription ID: " + myReader["ID"].ToString() + ", \n");
                    PatientPrescriptionList.AppendText("Name: " + myReader["Name"].ToString() + ", \n");
                    PatientPrescriptionList.AppendText("Refills: " + myReader["Refills"].ToString() + ", \n");
                    PatientPrescriptionList.AppendText("Received: " + myReader["Received"].ToString() + ", \n");
                    PatientPrescriptionList.AppendText("RefillDate: " + myReader["RefillDate"].ToString() + ", \n \n");
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }
        private void prescriptionIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!prescriptionIDTextBox.Text.Equals(""))
            {
                try
                {
                    prescriptionID = Int32.Parse(prescriptionIDTextBox.Text);
                }
                catch (Exception ex)
                {

                }
            }
            
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            GetPatientName();
            GetPrescriptionName();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                //Submit request for refill
                string reason = "Patient " + patientFName + " " + patientLName + " is requesting a refill of " + prescriptionName;

                string addAppStr = "INSERT INTO 340_rrdc_requests (RequestType, Reason) VALUES (1, @reason)";

                MySqlCommand addAppointmentRequest = new MySqlCommand(addAppStr, conn);

                addAppointmentRequest.Parameters.AddWithValue("@reason", reason);

                addAppointmentRequest.ExecuteNonQuery();

                string getIDStr = "SELECT LAST_INSERT_ID()";

                //query to obtain the id of the just-added request to relate it to the notification we're about to create
                MySqlCommand getLatestID = new MySqlCommand(getIDStr, conn);
                int latestID = -1;

                MySqlDataReader IDReader = getLatestID.ExecuteReader();
                IDReader.Read();

                latestID = IDReader.GetInt32(0);
                IDReader.Close();

                //insert new notification with the id we just got and the reason for the request
                string addNotifStr = "INSERT INTO 340_rrdc_notifications (New, RequestID, Body) VALUES (0, @reqID, @reason)";

                MySqlCommand addAppointmentNotification = new MySqlCommand(addNotifStr, conn);


                addAppointmentNotification.Parameters.AddWithValue("@reqID", latestID);
                addAppointmentNotification.Parameters.AddWithValue("@reason", reason);

                addAppointmentNotification.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Close();
        }
        private void GetPrescriptionName()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patientRow = "SELECT * FROM 340_rrdc_prescriptions WHERE ID = @prescriptionID";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patientRow, conn);

                Console.WriteLine("adding values to command");
                patCmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);


                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    prescriptionName = patDat.GetString(patDat.GetOrdinal("Name"));
                }
                Console.WriteLine("Reading data");

                patDat.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void GetPatientName()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patientRow = "SELECT * FROM 340_rrdc_patients WHERE ID = @patientID";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patientRow, conn);

                Console.WriteLine("adding values to command");
                patCmd.Parameters.AddWithValue("@patientID", ID);


                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    patientFName = patDat.GetString(patDat.GetOrdinal("FirstName"));
                    patientLName = patDat.GetString(patDat.GetOrdinal("LastName"));

                }
                Console.WriteLine("Reading data");

                patDat.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //Don't use functions below I can't remove them
        private void PatientPrescriptionList_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
