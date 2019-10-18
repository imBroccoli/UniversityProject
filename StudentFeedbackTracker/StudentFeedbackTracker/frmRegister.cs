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
    public partial class frmRegister : Form
    {
        StudentFeedbackTrackerEntities db = new StudentFeedbackTrackerEntities();
        public frmRegister()
        {
            InitializeComponent();

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadUserType();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tblUser usr = new tblUser();
            usr.UsrName = txtUserName.Text;
            usr.UsrPass = txtUserpass.Text;
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.DOB = dtDOB.Value;
            usr.UsrTypeId = int.Parse(cboUserType.ValueMember.ToString());
            usr.Email = txtEmail.Text;
            usr.startDate = DateTime.Now;

            db.tblUsers.Add(usr);
            db.SaveChanges();
        }

        private void LoadUserType()
        {
            var UserTypeData = db.tblUsrTypes.ToList();

            cboUserType.DataSource = UserTypeData;

            cboUserType.DisplayMember = "UsrTypeName";

            cboUserType.ValueMember = "Id";

            cboUserType.SelectedIndex = 0;

        }

        
    }
}
