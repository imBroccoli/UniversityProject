using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTrackingSystem
{
    public partial class frmStaffRegistration : Form
    {
        public frmStaffRegistration()
        {
            InitializeComponent();
        }

        public static implicit operator frmStaffRegistration(frmStudentRegistration v)
        {
            throw new NotImplementedException();
        }
    }
}
