using System.Windows.Forms;

namespace DoctorSubsystem
{
    public partial class Login : Form
    {
        Doctor thisD = new Doctor();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            //set the main screen
            Main main = new Main();
            //get the required data of the patient
            thisD = thisD.GetDoctorData(usernameBox.Text, passwordBox.Text);

            //send needed variables to main
            main.SetDoctor(thisD.GetID(), thisD.GetFName(), thisD.GetLName());
            //show main
            main.ShowDialog();
            this.Close();
        }
    }
}
