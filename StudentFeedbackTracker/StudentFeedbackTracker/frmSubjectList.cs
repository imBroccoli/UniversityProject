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
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmSubjectList()
        {
            InitializeComponent();
        }

        private void frmSubjectList_Load(object sender, EventArgs e)
        {
            getSubjectList();
        }

        private void getSubjectList()
        {
            var subData = db.tblSubjects.Select(x => new { SubjectID = x.Id, SubjectName = x.sName, CourseID = x.cId }).ToList();

            if (subData != null)
            {
                gvSub.DataSource = subData;
            }
        }

        private void frmSubjectList_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            this.Hide();
        }
    }
}
