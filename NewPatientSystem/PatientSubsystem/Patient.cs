using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PatientSubsystem
{
    internal class Patient
    {
        private int ID;
        private string fName;
        private string lName;
        private string mName;

        public Patient() { 
        
        }
        public Patient(int ID, string fName, string lName)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
        }

        public int GetID()
        {
            return ID;
        }

        public string GetFName()
        {
            return fName;
        }

        public string GetLName()
        {
            return lName;
        }

        public Patient GetPatientData(string username, string password)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patientRow = "SELECT * FROM 340_rrdc_patients WHERE UserName = @username AND Password = @password;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patientRow, conn);

                Console.WriteLine("adding values to command");
                patCmd.Parameters.AddWithValue("@username", username);
                patCmd.Parameters.AddWithValue("@password", password);


                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    ID = patDat.GetInt32(patDat.GetOrdinal("ID"));
                    fName = patDat.GetString(patDat.GetOrdinal("FirstName"));
                    lName = patDat.GetString(patDat.GetOrdinal("LastName"));

                }
                Console.WriteLine("Reading data");

                patDat.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Patient thisP = new Patient(this.ID, this.fName, this.lName);
            //Console.WriteLine(thisP.GetID());
            return thisP;
        }

        public void showNotifications() {
            NotificationForm f3 = new NotificationForm(ID);
            f3.Show();
        }

        public void checkMedicalRecords(RichTextBox richTextBox1) {
            //Check Medical Records
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM 340_rrdc_prescriptions WHERE PatientID = 1";
                Console.Write(sql);

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@name", s);  //not sure what this does
                MySqlDataReader myReader = cmd.ExecuteReader();
                richTextBox1.Clear();
                richTextBox1.AppendText("Prescriptions: \n");
                while (myReader.Read())
                {
                    richTextBox1.AppendText("Name: " + myReader["Name"].ToString() + ", \n");
                    richTextBox1.AppendText("Refills: " + myReader["Refills"].ToString() + ", \n");
                    richTextBox1.AppendText("Received: " + myReader["Received"].ToString() + ", \n");
                    richTextBox1.AppendText("RefillDate: " + myReader["RefillDate"].ToString() + ", \n \n");
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

        public void requestMedicine() {
           Form2 f2 = new Form2(ID);
           f2.Show();
        }

        public void requestPhoneCall(DateTime d) 
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                //insert new appointment request with the patient's reasoning containing the requested date
                string reason = "Patient " + fName + " " + lName + " is requesting a phonecall on " + d.ToString();

                string addAppStr = "INSERT INTO 340_rrdc_requests (RequestType, Reason) VALUES (2, @reason)";

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
        }

        public void requestAppointment(DateTime d)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                //insert new appointment request with the patient's reasoning containing the requested date
                string reason = "Patient " + fName + " " + lName + " is requesting an appointment on " + d.ToString();

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
        }
    }
}