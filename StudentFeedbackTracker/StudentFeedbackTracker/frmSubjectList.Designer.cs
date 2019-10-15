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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNavigationPanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavigationPanel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigationPanel.Location = new System.Drawing.Point(12, 356);
            this.btnNavigationPanel.Name = "btnNavigationPanel";
            this.btnNavigationPanel.Size = new System.Drawing.Size(674, 43);
            this.btnNavigationPanel.TabIndex = 1;
            this.btnNavigationPanel.Text = "Navigation Panel";
            this.btnNavigationPanel.UseVisualStyleBackColor = true;
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click);
            // 
            // frmSubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 411);
            this.Controls.Add(this.btnNavigationPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSubjectList";
            this.Text = "frmSubjectList";
            this.Load += new System.EventHandler(this.frmSubjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNavigationPanel;
    }
}