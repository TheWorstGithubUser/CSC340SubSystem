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

namespace PatientSubsystem
{
    public partial class Main : Form
    {
        Patient thisP = new Patient();
        public Main(int patientId)
        {
            InitializeComponent();
            thisP = new Patient(patientId);
            //Console.WriteLine(thisP.GetID());
            //Console.WriteLine(patientId);
            thisP = thisP.GetPatientData(patientId);
            thisP.showAppointments(appointmentListBox, patientId);
        }

        public void SetPatient(int id)
        {
            //called in Login to set the patient on the main page
            thisP = new Patient(id);
            thisP = thisP.GetPatientData(id);
        }

        private void checkRecordsButton_Click(object sender, EventArgs e)
        {
            MedicalRecords medicalRecords = new MedicalRecords(thisP.GetID());
            this.Hide();
            medicalRecords.ShowDialog();
            this.Show();
            
        }

        private void phoneCallRequest_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to schedule a phone call?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(res == DialogResult.OK)
            {
                thisP.requestPhoneCall(appointmentDatePicker.Value);
            }
        }

        private void medicineRequest_Click(object sender, EventArgs e)
        {
            RequestMeds request = new RequestMeds(thisP.GetID());
            this.Hide();
            request.ShowDialog();
            this.Show();
        }

        private void requestAppointment_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to schedule an appointment?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                thisP.requestAppointment(appointmentDatePicker.Value, thisP.GetID());
                appointmentListBox.Items.Add(appointmentDatePicker.Value);
            }
        }

        private void cancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to schedule an appointment?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                thisP.cancelAppointment((DateTime)appointmentListBox.Items[appointmentListBox.SelectedIndex], thisP.GetID());
                appointmentListBox.Items.Remove(appointmentListBox.SelectedIndex);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            NotificationForm notif = new NotificationForm(thisP.GetID());
            this.Hide();
            notif.ShowDialog();
            this.Show();
        }

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
