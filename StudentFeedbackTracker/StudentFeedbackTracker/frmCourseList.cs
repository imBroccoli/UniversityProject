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
    public partial class frmCourseList : Form
    {
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmCourseList()
        {
            InitializeComponent();
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            getAllCourses();
        }

        public void getAllCourses()
        {
            var courseData = db.tblCourses.Select(x => new { CoourseID = x.Id, CourseName = x.cName }).ToList();

            if (courseData != null)
            {
                gvCourse.DataSource = courseData;
            }
        }

        private void frmCourseList_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            this.Hide();
        }
    }
}
