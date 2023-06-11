namespace IOOPGroupAssignment
{
    partial class FormEnrollStu
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
            this.components = new System.ComponentModel.Container();
            this.lblSelectStud = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.lblSelectLevel = new System.Windows.Forms.Label();
            this.cmbSelectStu = new System.Windows.Forms.ComboBox();
            
            this.cmbSelectStuClass = new System.Windows.Forms.ComboBox();
            this.cmbSelectStuLevel = new System.Windows.Forms.ComboBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
           
           
            this.SuspendLayout();
            // 
            // lblSelectStud
            // 
            this.lblSelectStud.AutoSize = true;
            this.lblSelectStud.Location = new System.Drawing.Point(39, 22);
            this.lblSelectStud.Name = "lblSelectStud";
            this.lblSelectStud.Size = new System.Drawing.Size(121, 13);
            this.lblSelectStud.TabIndex = 0;
            this.lblSelectStud.Text = "Select Student to Enroll:";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(39, 49);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(35, 13);
            this.lblStudName.TabIndex = 1;
            this.lblStudName.Text = "Name";
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Location = new System.Drawing.Point(39, 76);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(68, 13);
            this.lblSelectClass.TabIndex = 2;
            this.lblSelectClass.Text = "Select Class:";
            // 
            // lblSelectLevel
            // 
            this.lblSelectLevel.AutoSize = true;
            this.lblSelectLevel.Location = new System.Drawing.Point(39, 103);
            this.lblSelectLevel.Name = "lblSelectLevel";
            this.lblSelectLevel.Size = new System.Drawing.Size(69, 13);
            this.lblSelectLevel.TabIndex = 3;
            this.lblSelectLevel.Text = "Select Level:";
            // 
            // cmbSelectStu
            // 
            this.cmbSelectStu.DisplayMember = "StudentID";
            this.cmbSelectStu.FormattingEnabled = true;
            this.cmbSelectStu.Location = new System.Drawing.Point(180, 22);
            this.cmbSelectStu.Name = "cmbSelectStu";
            this.cmbSelectStu.Size = new System.Drawing.Size(109, 21);
            this.cmbSelectStu.TabIndex = 4;
            this.cmbSelectStu.ValueMember = "StudentID";
            this.cmbSelectStu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            // 
            // cmbSelectStuClass
            // 
            this.cmbSelectStuClass.FormattingEnabled = true;
            this.cmbSelectStuClass.Items.AddRange(new object[] {
            "Introduction into Artificial Intelligence",
            "Introduction into Object Oriented Programming",
            "Introduction into Java",
            "Python",
            "System Analytics and Design"});
            this.cmbSelectStuClass.Location = new System.Drawing.Point(180, 76);
            this.cmbSelectStuClass.Name = "cmbSelectStuClass";
            this.cmbSelectStuClass.Size = new System.Drawing.Size(109, 21);
            this.cmbSelectStuClass.TabIndex = 5;
            // 
            // cmbSelectStuLevel
            // 
            this.cmbSelectStuLevel.FormattingEnabled = true;
            this.cmbSelectStuLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cmbSelectStuLevel.Location = new System.Drawing.Point(180, 103);
            this.cmbSelectStuLevel.Name = "cmbSelectStuLevel";
            this.cmbSelectStuLevel.Size = new System.Drawing.Size(109, 21);
            this.cmbSelectStuLevel.TabIndex = 6;
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(180, 49);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.ReadOnly = true;
            this.txtStudName.Size = new System.Drawing.Size(109, 20);
            this.txtStudName.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(76, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEnrollStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(129)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(333, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.cmbSelectStuLevel);
            this.Controls.Add(this.cmbSelectStuClass);
            this.Controls.Add(this.cmbSelectStu);
            this.Controls.Add(this.lblSelectLevel);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.lblSelectStud);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEnrollStu";
            this.Text = "FormEnrollStu";
            this.Load += new System.EventHandler(this.FormEnrollStu_Load);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStud;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Label lblSelectLevel;
        private System.Windows.Forms.ComboBox cmbSelectStu;
        private System.Windows.Forms.ComboBox cmbSelectStuClass;
        private System.Windows.Forms.ComboBox cmbSelectStuLevel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;




        public System.Windows.Forms.TextBox txtStudName;
    }
}