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
    public partial class frmControlPanel : Form
    {
        public frmControlPanel()
        {
            InitializeComponent();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse course = new frmCourse();
            course.MdiParent = this;
            course.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject sub = new frmSubject();
            sub.MdiParent = this;
            sub.Show();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentRegistration studReg = new frmStudentRegistration();
            studReg.MdiParent = this;
            studReg.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffRegistration staffReg = new frmStaffRegistration();
            staffReg.MdiParent = this;
            staffReg.Show();
        }

        private void assessmentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessmentTypeInfo AssessTypeInfo = new frmAssessmentTypeInfo();
            AssessTypeInfo.MdiParent = this;
            AssessTypeInfo.Show();
        }

        private void userTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyUserTypeInfo ModUserType = new frmModifyUserTypeInfo();
            ModUserType.MdiParent = this;
            ModUserType.Show();
        }

        private void userInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModifyUserInfo ModUserInfo = new frmModifyUserInfo();
            ModUserInfo.MdiParent = this;
            ModUserInfo.Show();
        }

        private void allCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllCourses allCourses = new frmAllCourses();
            allCourses.MdiParent = this;
            allCourses.Show();
        }

        private void allSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllSubject allSubject = new frmAllSubject();
            allSubject.MdiParent = this;
            allSubject.Show();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllUsers allUsers = new frmAllUsers();
            allUsers.MdiParent = this;
            allUsers.Show();
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllStudent allStudent = new frmAllStudent();
            allStudent.MdiParent = this;
            allStudent.Show();
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllStaff allStaff = new frmAllStaff();
            allStaff.MdiParent = this;
            allStaff.Show();
        }

        private void userTypeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllUserType allUserTypeInfo = new frmAllUserType();
            allUserTypeInfo.MdiParent = this;
            allUserTypeInfo.Show();
        }

        private void asessmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllAssessment allAsmnt = new frmAllAssessment();
            allAsmnt.MdiParent = this;
            allAsmnt.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeedback feedback = new frmFeedback();
            feedback.MdiParent = this;
            feedback.Show();
        }

        private void feedbackTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeedbackType feedbackType = new frmFeedbackType();
            feedbackType.MdiParent = this;
            feedbackType.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade grade = new frmGrade();
            grade.MdiParent = this;
            grade.Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotes notes = new frmNotes();
            notes.MdiParent = this;
            notes.Show();
        }

        private void subjectAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectAssessment subAssessment = new frmSubjectAssessment();
            subAssessment.MdiParent = this;
            subAssessment.Show();
        }

        private void assessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessment assessment = new frmAssessment();
            assessment.MdiParent = this;
            assessment.Show();
        }

        private void allAssessmentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllAssessmentType allAssessmentType = new frmAllAssessmentType();
            allAssessmentType.MdiParent = this;
            allAssessmentType.Show();
        }

        private void allSubjectAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllSubAssess allSubAssess = new frmAllSubAssess();
            allSubAssess.MdiParent = this;
            allSubAssess.Show();
        }

        private void assessmentTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAssessmentTypeInfo assessmentType = new frmAssessmentTypeInfo();
            assessmentType.MdiParent = this;
            assessmentType.Show();
        }
    }
}
