using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker
{
    public partial class frmSubjectList : Form
    {
        public frmSubjectList()
        {
            InitializeComponent();
        }

        private void frmSubjectList_Load(object sender, EventArgs e)
        {

        }

        private void btnNavigationPanel_Click(object sender, EventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            this.Hide();
        }
    }
}
