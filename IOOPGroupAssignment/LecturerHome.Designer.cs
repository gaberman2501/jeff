namespace IOOPGroupAssignment
{
    partial class LecturerHome
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
            this.btnRegStud = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnProfUpdate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudUpEn = new System.Windows.Forms.Button();
            this.btnStudEnroll = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegStud
            // 
            this.btnRegStud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegStud.Location = new System.Drawing.Point(16, 46);
            this.btnRegStud.Name = "btnRegStud";
            this.btnRegStud.Size = new System.Drawing.Size(87, 29);
            this.btnRegStud.TabIndex = 0;
            this.btnRegStud.Text = "Register Student";
            this.btnRegStud.UseVisualStyleBackColor = true;
            this.btnRegStud.Click += new System.EventHandler(this.btnRegStud_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(16, 82);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(87, 30);
            this.btnDelStud.TabIndex = 1;
            this.btnDelStud.Text = "Delete Student";
            this.btnDelStud.UseVisualStyleBackColor = true;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnProfUpdate
            // 
            this.btnProfUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfUpdate.Location = new System.Drawing.Point(193, 3);
            this.btnProfUpdate.Name = "btnProfUpdate";
            this.btnProfUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnProfUpdate.TabIndex = 2;
            this.btnProfUpdate.Text = "Update Profile";
            this.btnProfUpdate.UseVisualStyleBackColor = true;
            this.btnProfUpdate.Click += new System.EventHandler(this.btnProfUpdate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(275, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudUpEn
            // 
            this.btnStudUpEn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudUpEn.Location = new System.Drawing.Point(109, 82);
            this.btnStudUpEn.Name = "btnStudUpEn";
            this.btnStudUpEn.Size = new System.Drawing.Size(87, 30);
            this.btnStudUpEn.TabIndex = 5;
            this.btnStudUpEn.Text = "Update Enrolment";
            this.btnStudUpEn.UseVisualStyleBackColor = true;
            this.btnStudUpEn.Click += new System.EventHandler(this.btnStudUpEn_Click);
            // 
            // btnStudEnroll
            // 
            this.btnStudEnroll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudEnroll.Location = new System.Drawing.Point(109, 46);
            this.btnStudEnroll.Name = "btnStudEnroll";
            this.btnStudEnroll.Size = new System.Drawing.Size(87, 29);
            this.btnStudEnroll.TabIndex = 4;
            this.btnStudEnroll.Text = "Enroll Student";
            this.btnStudEnroll.UseVisualStyleBackColor = true;
            this.btnStudEnroll.Click += new System.EventHandler(this.btnStudEnroll_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(16, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReq
            // 
            this.btnReq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReq.Location = new System.Drawing.Point(212, 56);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(129, 38);
            this.btnReq.TabIndex = 7;
            this.btnReq.Text = "View Requests";
            this.btnReq.UseVisualStyleBackColor = true;
            // 
            // LecturerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 124);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnStudUpEn);
            this.Controls.Add(this.btnStudEnroll);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfUpdate);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.btnRegStud);
            this.Name = "LecturerHome";
            this.Text = "LecturerHome";
            this.Load += new System.EventHandler(this.LecturerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegStud;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnProfUpdate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudUpEn;
        private System.Windows.Forms.Button btnStudEnroll;
        private System.Windows.Forms.Label lblWelcome;


        private System.Windows.Forms.BindingSource requestBindingSource;

        private System.Windows.Forms.BindingSource requestBindingSource1;
        private System.Windows.Forms.Button btnReq;
    }
}