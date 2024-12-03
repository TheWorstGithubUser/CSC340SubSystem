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
    public partial class MedicalRecords : Form
    {
        Patient thisP = new Patient();
        public MedicalRecords(int id)
        {
            SetPatient(id);
            InitializeComponent();
            //check records
            thisP.checkMedicalRecords(richTextBox1, thisP.GetID());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        public void SetPatient(int id)
        {
            thisP = new Patient(id);
        }
    }
}
