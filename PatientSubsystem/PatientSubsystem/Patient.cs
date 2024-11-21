using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PatientSubsystem
{
    internal class Patient
    {
        public int ID;
        public string fName;
        public string lName;
        public string mName;
        public string insuranceCardNumber;
        public int insurerID;
        public Patient(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public Patient()
        {

        }

        public void getPatientData()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patientRow = "SELECT * FROM 340_rrdc_patients WHERE FirstName = @fName AND LastName = @lName;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patientRow, conn);

                Console.WriteLine("adding values to command");
                patCmd.Parameters.AddWithValue("@fName", fName);
                patCmd.Parameters.AddWithValue("@lName", lName);

                
                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    ID = patDat.GetInt32(0);
                    mName = patDat.GetString(2);
                    insuranceCardNumber = patDat.GetString(4);
                    insurerID = patDat.GetInt32(5);

                }
                Console.WriteLine("Reading data");

                patDat.Close();
                conn.Close();
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
