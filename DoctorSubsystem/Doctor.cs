using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

namespace DoctorSubsystem
{
        internal class Doctor
    {
        private int ID;
        private string fName;
        private string lName;

        public Doctor(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public Doctor(int id)
        {
            ID = id;
        }

        public Doctor(int ID, string fName, string lName)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
        }

        public Doctor()
        {

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

        public Doctor GetDoctorData(string username, string password)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string doctorRow = "SELECT ID FROM 340_rrdc_doctors WHERE UserName = @username AND Password = @password;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(doctorRow, conn);
                Console.WriteLine("adding values to command");
                patCmd.Parameters.AddWithValue("@username", username);
                patCmd.Parameters.AddWithValue("@password", password);


                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    ID = patDat.GetInt32(0);
                    fName = patDat.GetString(1);
                    lName = patDat.GetString(3);
                }
                Console.WriteLine("Reading data");

                patDat.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Doctor thisD = new Doctor(this.ID, this.fName, this.lName);
            return thisD;   
        }
    }
}


