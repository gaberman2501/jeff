namespace IOOPGroupAssignment
{
    partial class FormUpdateStuEnrolment
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
            this.cmbSelectStud = new System.Windows.Forms.ComboBox();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblStudClass = new System.Windows.Forms.Label();
            this.lblStudLevel = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.cmbStudClass = new System.Windows.Forms.ComboBox();
            this.cmbStudLevel = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            
            
            this.SuspendLayout();
            // 
            // lblSelectStud
            // 
            this.lblSelectStud.AutoSize = true;
            this.lblSelectStud.Location = new System.Drawing.Point(13, 13);
            this.lblSelectStud.Name = "lblSelectStud";
            this.lblSelectStud.Size = new System.Drawing.Size(80, 13);
            this.lblSelectStud.TabIndex = 0;
            this.lblSelectStud.Text = "Select Student:";
            // 
            // cmbSelectStud
            // 
            
            this.cmbSelectStud.DisplayMember = "StudentID";
            this.cmbSelectStud.FormattingEnabled = true;
            this.cmbSelectStud.Location = new System.Drawing.Point(99, 10);
            this.cmbSelectStud.Name = "cmbSelectStud";
            this.cmbSelectStud.Size = new System.Drawing.Size(106, 21);
            this.cmbSelectStud.TabIndex = 1;
            this.cmbSelectStud.ValueMember = "StudentID";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(45, 46);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(35, 13);
            this.lblStudName.TabIndex = 2;
            this.lblStudName.Text = "Name";
            // 
            // lblStudClass
            // 
            this.lblStudClass.AutoSize = true;
            this.lblStudClass.Location = new System.Drawing.Point(43, 77);
            this.lblStudClass.Name = "lblStudClass";
            this.lblStudClass.Size = new System.Drawing.Size(68, 13);
            this.lblStudClass.TabIndex = 3;
            this.lblStudClass.Text = "Select Class:";
            // 
            // lblStudLevel
            // 
            this.lblStudLevel.AutoSize = true;
            this.lblStudLevel.Location = new System.Drawing.Point(44, 104);
            this.lblStudLevel.Name = "lblStudLevel";
            this.lblStudLevel.Size = new System.Drawing.Size(69, 13);
            this.lblStudLevel.TabIndex = 4;
            this.lblStudLevel.Text = "Select Level:";
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(127, 46);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(100, 20);
            this.txtStudName.TabIndex = 5;
            // 
            // cmbStudClass
            // 
            this.cmbStudClass.FormattingEnabled = true;
            this.cmbStudClass.Items.AddRange(new object[] {
            "Introduction into Artificial Intelligence",
            "Introduction into Object Oriented Programming",
            "Introduction into Java",
            "Python",
            "System Analytics and Design"});
            this.cmbStudClass.Location = new System.Drawing.Point(127, 73);
            this.cmbStudClass.Name = "cmbStudClass";
            this.cmbStudClass.Size = new System.Drawing.Size(100, 21);
            this.cmbStudClass.TabIndex = 6;
            // 
            // cmbStudLevel
            // 
            this.cmbStudLevel.FormattingEnabled = true;
            this.cmbStudLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStudLevel.Location = new System.Drawing.Point(127, 100);
            this.cmbStudLevel.Name = "cmbStudLevel";
            this.cmbStudLevel.Size = new System.Drawing.Size(100, 21);
            this.cmbStudLevel.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // databasetestDataSet
            // 
          
            
            // 
            // studentBindingSource
            // 
            
            
            // 
            // studentTableAdapter
            // 
            
            // 
            // FormUpdateStuEnrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 192);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbStudLevel);
            this.Controls.Add(this.cmbStudClass);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.lblStudLevel);
            this.Controls.Add(this.lblStudClass);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.cmbSelectStud);
            this.Controls.Add(this.lblSelectStud);
            this.Name = "FormUpdateStuEnrolment";
            this.Text = "Update Student Enrolment";
            this.Load += new System.EventHandler(this.FormUpdateStuEnrolment_Load);
            
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStud;
        private System.Windows.Forms.ComboBox cmbSelectStud;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblStudClass;
        private System.Windows.Forms.Label lblStudLevel;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.ComboBox cmbStudClass;
        private System.Windows.Forms.ComboBox cmbStudLevel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.BindingSource studentBindingSource;

    }
}