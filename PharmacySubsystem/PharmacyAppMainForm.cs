using MySql.Data.MySqlClient;
using System.Configuration;

namespace PharmacySubsystem
{
    public partial class PharmacyAppMainForm : Form
    {
        private string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

        public PharmacyAppMainForm()
        {
            InitializeComponent();
            newPrescriptionPollingTimer.Tick += newPrescriptionPollingTimerTick;
            newPrescriptionPollingTimer.Start();
        }

        private void newPrescriptionPollingTimerTick(object sender, EventArgs e)
        {
            checkForNewPrescriptions();
        }

        private void checkForNewPrescriptions()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while polling database: {ex.Message}");
            }
        }
    }
}
