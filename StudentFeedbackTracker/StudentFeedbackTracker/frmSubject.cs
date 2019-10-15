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
    public partial class frmSubject : Form
    {
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
                var courseData = db.tblCourses.ToList();
                cboCourseName.DataSource = courseData;
                cboCourseName.DisplayMember = "cName";
                cboCourseName.ValueMember = "Id";
                cboCourseName.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tblSubject subs = new tblSubject();

            subs.sName = txtSName.Text;
            subs.cId = int.Parse(cboCourseName.SelectedValue.ToString());
            db.tblSubjects.Add(subs);
            db.SaveChanges();
            MessageBox.Show("New subject has been added", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkNavigationPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            this.Hide();
        }

        private void frmSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
