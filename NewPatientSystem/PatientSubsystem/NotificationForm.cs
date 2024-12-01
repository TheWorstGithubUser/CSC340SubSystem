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

namespace PatientSubsystem
{
    public partial class NotificationForm : Form
    {
        int ID;
        public NotificationForm(int patientID)
        {
            ID = patientID;
            InitializeComponent();
        }

        private void NotifTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            //Get all notifications
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM 340_rrdc_notifications WHERE new = 0 AND ReceiverID = " + ID;
                //Console.Write(sql);

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@name", s);  //not sure what this does
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    NotifTextBox.AppendText("Notification \n");
                    NotifTextBox.AppendText("Date: " + myReader["ReceivedON"].ToString() + ", \n");
                    NotifTextBox.AppendText("Request ID: " + myReader["RequestID"].ToString() + ", \n");
                    NotifTextBox.AppendText("Info: " + myReader["Body"].ToString() + ", \n \n");
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
    }
}

