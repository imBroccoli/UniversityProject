﻿using System;
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
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse frmCS = new frmCourse();
            frmCS.Show();
            this.Hide();
        }

        private void allCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseList frmCSList = new frmCourseList();
            frmCSList.Show();
            this.Hide();
        }
    }
}
