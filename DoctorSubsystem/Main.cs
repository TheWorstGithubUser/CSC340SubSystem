using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSubsystem
{
    public partial class Main : Form
    {
        Doctor thisD = new Doctor();
        public Main()
        {
            InitializeComponent();
        }

        public void SetDoctor(int id, string f, string l)
        {
            thisD = new Doctor(id, f, l);
        }
    }
}
