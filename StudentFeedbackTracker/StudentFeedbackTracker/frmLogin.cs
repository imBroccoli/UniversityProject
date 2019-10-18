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
    public partial class frmLogin : Form
    {
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userData = db.tblUsers.Where(d => d.UsrName == txtUsername.Text && d.UsrPass == txtPassword.Text).FirstOrDefault();

            if (userData != null)
            {
                Tools.UsrType = userData.tblUsrType.UsrTypeName;
                MessageBox.Show("Welcome " + Tools.UsrType);
                frmNavigation frmNav = new frmNavigation();
                frmNav.Show();
                this.Hide();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.Show();
            this.Hide();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
