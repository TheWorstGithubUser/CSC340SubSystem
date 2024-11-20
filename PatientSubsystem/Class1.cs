using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PatientSubsystem
{
    internal class Patient
    {
        private int patientID;
        private String patientName;

        public Patient()
        {

        }

        public Patient(int id)
        {
            patientID = id;
        }

        public Patient(int id, String name)
        {
            patientID = id;
            patientName = name;
        }

        public int getPatientID()
        {
            return patientID;
        }

        public String getPatientName()
        {
            return patientName;
        }

        public static Patient getPatientData(String username, String password)
        {
            Patient thisP = new Patient();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT ID FROM 340_rrdc_patients WHERE UserName=@username && Password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@patientID", 2222);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    int i = myReader.GetInt32("id");
                    String n = myReader["name"].ToString();
                    thisP = new Patient(i, n);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return thisP;

        }
    }
}
