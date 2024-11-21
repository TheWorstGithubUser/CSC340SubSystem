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
        public Main()
        {
            InitializeComponent();
        }

        public void SetPatient(int id, string fName, string lName)
        {
            //called in Login to set the patient on the main page
            thisP = new Patient(id, fName, lName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for testing
            //Console.WriteLine("Main: " + thisP.GetID());
        }
    }
}
