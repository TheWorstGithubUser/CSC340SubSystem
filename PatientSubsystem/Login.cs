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
            //get the required data of the patient
            thisP = thisP.GetPatientData(usernameBox.Text, passwordBox.Text);

            //set the main screen
            Main main = new Main(thisP.GetID());
            //show main
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
