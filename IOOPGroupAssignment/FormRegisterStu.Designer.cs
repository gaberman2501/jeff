namespace IOOPGroupAssignment
{
    partial class FormRegisterStu
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
            this.lblStuDet = new System.Windows.Forms.Label();
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudNum = new System.Windows.Forms.TextBox();
            this.txtStudYear = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStudMail = new System.Windows.Forms.TextBox();
            this.lblStuMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStuDet
            // 
            this.lblStuDet.AutoSize = true;
            this.lblStuDet.Location = new System.Drawing.Point(12, 9);
            this.lblStuDet.Name = "lblStuDet";
            this.lblStuDet.Size = new System.Drawing.Size(110, 13);
            this.lblStuDet.TabIndex = 0;
            this.lblStuDet.Text = "Enter Student Details:";
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Location = new System.Drawing.Point(32, 38);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(55, 13);
            this.lblStudID.TabIndex = 1;
            this.lblStudID.Text = "StudentID";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(32, 65);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(35, 13);
            this.lblStudName.TabIndex = 2;
            this.lblStudName.Text = "Name";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(32, 147);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Location = new System.Drawing.Point(32, 91);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(84, 13);
            this.lblStudNum.TabIndex = 3;
            this.lblStudNum.Text = "Contact Number";
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(130, 35);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(100, 20);
            this.txtStudID.TabIndex = 5;
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(130, 62);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(100, 20);
            this.txtStudName.TabIndex = 6;
            // 
            // txtStudNum
            // 
            this.txtStudNum.Location = new System.Drawing.Point(130, 88);
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(100, 20);
            this.txtStudNum.TabIndex = 7;
            // 
            // txtStudYear
            // 
            this.txtStudYear.Location = new System.Drawing.Point(130, 144);
            this.txtStudYear.Name = "txtStudYear";
            this.txtStudYear.Size = new System.Drawing.Size(100, 20);
            this.txtStudYear.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(41, 187);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStudMail
            // 
            this.txtStudMail.Location = new System.Drawing.Point(130, 118);
            this.txtStudMail.Name = "txtStudMail";
            this.txtStudMail.Size = new System.Drawing.Size(100, 20);
            this.txtStudMail.TabIndex = 12;
            // this.txtStudMail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStuMail
            // 
            this.lblStuMail.AutoSize = true;
            this.lblStuMail.Location = new System.Drawing.Point(32, 121);
            this.lblStuMail.Name = "lblStuMail";
            this.lblStuMail.Size = new System.Drawing.Size(73, 13);
            this.lblStuMail.TabIndex = 11;
            this.lblStuMail.Text = "Email Address";
            // this.lblStuMail.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormRegisterStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 229);
            this.Controls.Add(this.txtStudMail);
            this.Controls.Add(this.lblStuMail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStudYear);
            this.Controls.Add(this.txtStudNum);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblStudNum);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.lblStudID);
            this.Controls.Add(this.lblStuDet);
            this.Name = "FormRegisterStu";
            this.Text = "FormRegisterStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuDet;
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtStudNum;
        private System.Windows.Forms.TextBox txtStudYear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStudMail;
        private System.Windows.Forms.Label lblStuMail;
    }
}