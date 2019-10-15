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
    public partial class frmCourse : Form
    {
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmCourse()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tblCourse course = new tblCourse();

            course.cName = txtCName.Text;

            db.tblCourses.Add(course);
            db.SaveChanges();

            MessageBox.Show("New Course Added Successfully");
        }

        private void lnkNavigationPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            this.Hide();
        }
    }
}
