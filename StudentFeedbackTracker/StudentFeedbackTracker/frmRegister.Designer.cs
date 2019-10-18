namespace StudentFeedbackTracker
{
    partial class frmRegister
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.txtUserpass = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUserType);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.dtDOB);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtUserpass);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(147, 34);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(293, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "User Type:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(57, 290);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(61, 22);
            this.d.TabIndex = 7;
            this.d.Text = "Email:";
            // 
            // txtUserpass
            // 
            this.txtUserpass.Location = new System.Drawing.Point(147, 77);
            this.txtUserpass.Name = "txtUserpass";
            this.txtUserpass.Size = new System.Drawing.Size(293, 30);
            this.txtUserpass.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 119);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(293, 30);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 161);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(293, 30);
            this.txtLastName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 30);
            this.txtEmail.TabIndex = 13;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(147, 198);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(293, 30);
            this.dtDOB.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(147, 333);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 45);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cboUserType
            // 
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(147, 244);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(293, 30);
            this.cboUserType.TabIndex = 16;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 417);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserpass;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}