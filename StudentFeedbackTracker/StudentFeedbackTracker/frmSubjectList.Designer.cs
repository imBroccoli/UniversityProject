namespace StudentFeedbackTracker
{
    partial class frmSubjectList
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
            this.gvSub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvSub)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSub
            // 
            this.gvSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSub.Location = new System.Drawing.Point(12, 12);
            this.gvSub.Name = "gvSub";
            this.gvSub.Size = new System.Drawing.Size(674, 344);
            this.gvSub.TabIndex = 0;
            // 
            // frmSubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.gvSub);
            this.Name = "frmSubjectList";
            this.Text = "frmSubjectList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSubjectList_FormClosed);
            this.Load += new System.EventHandler(this.frmSubjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSub;
    }
}