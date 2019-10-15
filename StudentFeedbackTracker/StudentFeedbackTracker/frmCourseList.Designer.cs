namespace StudentFeedbackTracker
{
    partial class frmCourseList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCourse
            // 
            this.gvCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourse.Location = new System.Drawing.Point(12, 12);
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.Size = new System.Drawing.Size(714, 358);
            this.gvCourse.TabIndex = 0;
            // 
            // frmCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 382);
            this.Controls.Add(this.gvCourse);
            this.Name = "frmCourseList";
            this.Text = "frmCourseList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCourseList_FormClosed);
            this.Load += new System.EventHandler(this.frmCourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCourse;
    }
}