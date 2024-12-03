using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacySubsystem
{
    internal class Prescription
    {
        int id;
        int patientId;
        int refills;
        string name;
        bool pending;

        public Prescription() 
        {

        }

        public Prescription(int id)
        {
            this.id = id;
        }

        public Prescription(int id, int refills, string name, int pend, int pId)
        {
            this.id = id;
            this.refills = refills;
            this.name = name;
            this.patientId = pId;
            if(pend == 1)
            {
                pending = true;
            }
            else
            {
                pending = false;
            }
        }

        public int GetId()
        {
            return this.id;
        }

        public void ConfirmArrival(int pId)
        {
            this.pending = false;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string pending = "UPDATE 340_rrdc_prescriptions SET Pending = 0 WHERE ID = @pId;";

                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(pending, conn);

                patCmd.Parameters.AddWithValue("@pId", pId);

                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");
                patDat.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

        public string GetPatientFirstName(int pId)
        {
            string patientF = null;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patient = "SELECT FirstName FROM 340_rrdc_patients WHERE ID = @pId;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patient, conn);

                patCmd.Parameters.AddWithValue("@pId", pId);

                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    patientF = patDat.GetString(0);
                }
                patDat.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Patient First: " + ex.Message);
            }
            conn.Close();
            return patientF;
        }

        public void GetPerscriptionData(int id)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string prescription = "SELECT * FROM 340_rrdc_requests WHERE ID = @id;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(prescription, conn);

                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    this.id = id;
                    this.refills = patDat.GetInt32(1);
                    this.name = patDat.GetString(7);
                    this.patientId = patDat.GetInt32(6);
                    if (patDat.GetInt32(5)==1)
                    {
                        this.pending = true;
                    }
                    else 
                    {
                        this.pending = false;
                    }
                }
                Console.WriteLine("Reading data");
                conn.Close();
                patDat.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string GetPatientLastName(int pId)
        {
            string patientL = null;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();

                string patient = "SELECT LastName FROM 340_rrdc_patients WHERE ID = @pId;";
                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(patient, conn);

                patCmd.Parameters.AddWithValue("@pId", pId);

                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");

                if (patDat.Read())
                {
                    patientL = patDat.GetString(0);
                }
                patDat.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Patient last: " + ex.Message);
            }
            conn.Close();
            return patientL;
        }

        public void NotifyPatient(int id)
        {
            DateTime date = DateTime.Now;
            this.GetPerscriptionData(id);
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("opening sql connection");
                conn.Open();
                string notif = "INSERT INTO 340_rrdc_notifications (ReceivedOn, New, Body, ReceiverID) VALUES (@date, 1, 'You have a prescription ready!', @patientId);";

                Console.WriteLine("creating command");
                MySqlCommand patCmd = new MySqlCommand(notif, conn);

                patCmd.Parameters.AddWithValue("@date", date);
                patCmd.Parameters.AddWithValue("@patientId", this.patientId);

                MySqlDataReader patDat = patCmd.ExecuteReader();
                Console.WriteLine("Executing Command");
                patDat.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

        public override string ToString() 
        {
            return "Name: " + this.name + " Refills: " + this.refills + " Pending: " + this.pending + " Patient Name: " + this.GetPatientFirstName(this.patientId) + " " + this.GetPatientLastName(this.patientId); 
        }
    }
}
