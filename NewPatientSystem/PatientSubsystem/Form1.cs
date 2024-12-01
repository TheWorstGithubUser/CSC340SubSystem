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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatientSubsystem
{
    public partial class Form1 : Form
    {
        //I am currently assuming our user is ID = 1 until we get a functional login screen
        public string selectedDate;
        Patient patient = new Patient();   //TO-DO: Implement login
        public string fname;
        public string lname;
        
        public Form1()
        {
            patient = patient.GetPatientData("ray", "1234");
            InitializeComponent();
            
            Console.Write("Logged in as " + patient.GetLName());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check Medical Records
            patient.checkMedicalRecords(richTextBox1);
        }

        private void phoneCallRequest_Click(object sender, EventArgs e)
        {
            //Request phonecall with doctor
            patient.requestPhoneCall(appointmentDatePicker.Value);
        }

        private void medicineRequest_Click(object sender, EventArgs e)
        {
            //Request medicine refill
            patient.requestMedicine();

        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            //Get all notifications
            patient.showNotifications();
        }
        private void requestAppointment_Click(object sender, EventArgs e)
        {
            //Request Appointment with selected appointment date
            patient.requestAppointment(appointmentDatePicker.Value);
        }

        private void cancelAppointment_Click(object sender, EventArgs e)
        {
            //Request appointment with selected appointment date
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM 340_rrdc_prescriptions WHERE ID = 1";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@name", s);  //not sure what this does
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //textBox1.Text = myReader["Refills"].ToString();
                    //textBox2.Text = myReader["Received"].ToString();
                    //textBox3.Text = myReader["RefillDate"].ToString();
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

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //Value changed in appointment date
            //store value publicly
            selectedDate = appointmentDatePicker.Value.ToShortDateString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //unused
        }
    }
}
