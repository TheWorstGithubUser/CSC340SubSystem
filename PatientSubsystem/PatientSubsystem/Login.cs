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

namespace PatientSubsystem
{
    public partial class Login : Form
    {
        Patient thisP = new Patient();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //set the main screen
            Main main = new Main();
            //get the required data of the patient
            thisP = thisP.GetPatientData(usernameBox.Text, passwordBox.Text);

            //send needed variables to main
            main.SetPatient(thisP.GetID(), thisP.GetFName(), thisP.GetLName());
            //show main
            main.ShowDialog();
            this.Close();
        }
    }
}
