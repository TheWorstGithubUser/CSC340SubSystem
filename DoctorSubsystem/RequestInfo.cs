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
    public partial class RequestInfo : Form
    {
        int thisNotifID;
        string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

        MySqlConnection conn;
        public RequestInfo(int id)
        {
            InitializeComponent();

            thisNotifID = id;
            conn = new MySqlConnection(connStr);
        }

        int id, reqType, reqID, prescripID;
        string reason;
        DateTime lastModDate;

        int status;

        //display: lastmodified, request type, reason, (if applicable) link to prescription 
        private void RequestInfo_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Entered Load");
            try
            {
                conn.Open();

                string getReqString = "SELECT * FROM 340_rrdc_requests LEFT JOIN 340_rrdc_notifications ON " +
                    "340_rrdc_requests.ID = 340_rrdc_notifications.RequestID WHERE 340_rrdc_notifications.ID = @notifID";
                MySqlCommand getReqCmd = new MySqlCommand(getReqString, conn);

                getReqCmd.Parameters.AddWithValue("@notifID", thisNotifID);

                MySqlDataReader reqData = getReqCmd.ExecuteReader();

                if (reqData.Read())
                {
                    reqID = reqData.GetInt32(reqData.GetOrdinal("ID"));//gets the ID from the request table

                    reqType = reqData.GetInt32(reqData.GetOrdinal("RequestType"));

                    lastModDate = reqData.GetDateTime(reqData.GetOrdinal("LastModified"));

                    reason = reqData.GetString(reqData.GetOrdinal("Reason"));

                    if (!reqData.IsDBNull(reqData.GetOrdinal("PrescriptionID")))
                    {
                        prescripID = reqData.GetInt32(reqData.GetOrdinal("PrescriptionID"));
                    }
                    else
                    {
                        prescripID = -1;
                    }

                    if (reqData.IsDBNull(reqData.GetOrdinal("Status"))) //if status is null
                    {
                        this.statusDropdown.SelectedIndex = 0;//undecided
                        status = 0;
                    }
                    else if (reqData.GetInt16(reqData.GetOrdinal("Status")) == 1) //approved
                    {
                        this.statusDropdown.SelectedIndex = 1;
                        status = 1;
                    }
                    else //denied
                    {
                        this.statusDropdown.SelectedIndex = 2;
                        status = 2;
                    }
                }

                this.Text = "Request #" + reqID;

                this.dateLabel.Text = "Last Modified " + lastModDate.ToString() +": ";

                switch (reqType)
                {
                    case 0:
                        this.reqLabel.Text = "Appointment Request:";
                        break;
                    case 1:
                        this.reqLabel.Text = "Refill Request:";
                        break;
                    case 2:
                        this.reqLabel.Text = "Phone Call Request:";
                        break;
                    case 3:
                        this.reqLabel.Text = "Medicine Request:";
                        break;
                    case 4:
                        this.reqLabel.Text = "Confirmation Request:";
                        break;
                }

                this.descripBox.Text = reason;

                reqData.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void statusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable/disable updateStatusButton when appropriate
            if (this.statusDropdown.SelectedIndex != status)
            {
                updateStatusButton.Enabled = true;
            }
            else
            {
                updateStatusButton.Enabled = false;
            }
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            //update the request with the new status
            string updateReqStr = "UPDATE 340_rrdc_requests SET LastModified = CURRENT_TIMESTAMP, Status = @status WHERE ID = @id";

            MySqlCommand updateReqCmd = new MySqlCommand(updateReqStr, conn);

            updateReqCmd.Parameters.AddWithValue("@status", status);
            updateReqCmd.Parameters.AddWithValue("@id", reqID);

            updateReqCmd.ExecuteNonQuery();


            //create new notif for the updated request
            string createUpdatedNotifStr = "INSERT INTO 340_rrdc_notifications (New, RequestID, Body) VALUES (1, @reqID, @reason)";

            MySqlCommand createUpdatedNotifCmd = new MySqlCommand(createUpdatedNotifStr, conn);

            createUpdatedNotifCmd.Parameters.AddWithValue("@reqID", reqID);
            createUpdatedNotifCmd.Parameters.AddWithValue("@reason", reason);

            createUpdatedNotifCmd.ExecuteNonQuery();

            //set new status and disable this button
            status = this.statusDropdown.SelectedIndex;
            this.updateStatusButton.Enabled = false;
        }
    }
}
