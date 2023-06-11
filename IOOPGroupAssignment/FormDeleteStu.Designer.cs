namespace IOOPGroupAssignment
{
    partial class FormDeleteStu
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
            this.lblSelectStu = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.lblStudYear = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDispStudName = new System.Windows.Forms.Label();
            this.lblDispStudNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectStu
            // 
            this.lblSelectStu.AutoSize = true;
            this.lblSelectStu.Location = new System.Drawing.Point(6, 11);
            this.lblSelectStu.Name = "lblSelectStu";
            this.lblSelectStu.Size = new System.Drawing.Size(126, 13);
            this.lblSelectStu.TabIndex = 0;
            this.lblSelectStu.Text = "Select Student to Delete:";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(66, 48);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(35, 13);
            this.lblStudName.TabIndex = 1;
            this.lblStudName.Text = "Name";
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Location = new System.Drawing.Point(66, 76);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(84, 13);
            this.lblStudNum.TabIndex = 2;
            this.lblStudNum.Text = "Contact Number";
            // 
            // lblStudYear
            // 
            this.lblStudYear.AutoSize = true;
            this.lblStudYear.Location = new System.Drawing.Point(66, 104);
            this.lblStudYear.Name = "lblStudYear";
            this.lblStudYear.Size = new System.Drawing.Size(29, 13);
            this.lblStudYear.TabIndex = 3;
            this.lblStudYear.Text = "Year";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblDispStudName
            // 
            this.lblDispStudName.Location = new System.Drawing.Point(166, 48);
            this.lblDispStudName.Name = "lblDispStudName";
            this.lblDispStudName.Size = new System.Drawing.Size(109, 13);
            this.lblDispStudName.TabIndex = 5;
            // 
            // lblDispStudNum
            // 
            this.lblDispStudNum.Location = new System.Drawing.Point(166, 76);
            this.lblDispStudNum.Name = "lblDispStudNum";
            this.lblDispStudNum.Size = new System.Drawing.Size(109, 13);
            this.lblDispStudNum.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(166, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(138, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormDeleteStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDispStudNum);
            this.Controls.Add(this.lblDispStudName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStudYear);
            this.Controls.Add(this.lblStudNum);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.lblSelectStu);
            this.Name = "FormDeleteStu";
            this.Text = "FormDeleteStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStu;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.Label lblStudYear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDispStudName;
        private System.Windows.Forms.Label lblDispStudNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}