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
    public partial class Form1 : Form
    {
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        MySqlConnection conn;

        //show notifications
        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string getNotifsStr = "SELECT * FROM 340_rrdc_notifications ORDER BY ReceivedOn DESC";
                MySqlCommand getNotifsCmd = new MySqlCommand(getNotifsStr, conn);

                MySqlDataReader notifData = getNotifsCmd.ExecuteReader();

                displayNotifs(notifData);

                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //toggle between displaying new or all notifications
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (showNewNotifsButton.Text.Equals("New Notifications"))
                {
                    showNewNotifsButton.Text = "All Notifications";
                    //add query to fill info box with new notifs only

                    conn.Open();

                    string showNewNotifsStr = "SELECT * FROM 340_rrdc_notifications WHERE New = 1 ORDER BY ReceivedOn DESC";
                    MySqlCommand showNewNotifsCmd = new MySqlCommand(showNewNotifsStr, conn);

                    MySqlDataReader newNotifData = showNewNotifsCmd.ExecuteReader();

                    displayNotifs(newNotifData);

                    conn.Close();

                }
                else
                {
                    showNewNotifsButton.Text = "New Notifications";
                    //add query to fill info box with all notifs
                    conn.Open();

                    string getNotifsStr = "SELECT * FROM 340_rrdc_notifications ORDER BY ReceivedOn DESC";
                    MySqlCommand getNotifsCmd = new MySqlCommand(getNotifsStr, conn);

                    MySqlDataReader notifData = getNotifsCmd.ExecuteReader();

                    displayNotifs(notifData);

                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //open create prescription form
        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            Form createPrescrip = new CreatePrescriptionForm();
            createPrescrip.Show();
        }

        //open patient list
        private void button3_Click(object sender, EventArgs e)
        {
            Form patientList = new PatientListForm();
            patientList.Show();
        }

        //view request selected from notification window
        private void button4_Click(object sender, EventArgs e)
        {
            //view Request
            var selectedItem = notifsListView.SelectedItems[0];
            int selectedID = Int32.Parse(selectedItem.Text);

            Form viewReq = new RequestInfo(selectedID);
            viewReq.Show();

            Console.WriteLine(selectedID);
        }

        //put read notifs into the list view
        public void displayNotifs(MySqlDataReader reader)
        {
            notifsListView.Items.Clear();
            while (reader.Read())
            {
                string[] newItem = { reader.GetInt32(0).ToString(), reader.GetDateTime(1).ToString(), reader.GetString(4) };
                ListViewItem lvi = new ListViewItem(newItem);
                notifsListView.Items.Add(lvi);
            }
        }

        //refresh notifications
        private void refreshButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            string getNotifsStr = "SELECT * FROM 340_rrdc_notifications ORDER BY ReceivedOn DESC";
            MySqlCommand getNotifsCmd = new MySqlCommand(getNotifsStr, conn);

            MySqlDataReader notifData = getNotifsCmd.ExecuteReader();

            displayNotifs(notifData);

            conn.Close();
        }
    }
}
