namespace IOOPGroupAssignment
{
    partial class LoginForm
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblowrd = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(24, 98);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(21, 20);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(55, 13);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "Username";
            // 
            // lblowrd
            // 
            this.lblowrd.AutoSize = true;
            this.lblowrd.Location = new System.Drawing.Point(21, 61);
            this.lblowrd.Name = "lblowrd";
            this.lblowrd.Size = new System.Drawing.Size(53, 13);
            this.lblowrd.TabIndex = 2;
            this.lblowrd.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(116, 20);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(100, 20);
            this.txtuname.TabIndex = 3;
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(116, 54);
            this.txtpword.Name = "txtpword";
            this.txtpword.Size = new System.Drawing.Size(100, 20);
            this.txtpword.TabIndex = 4;
            this.txtpword.UseSystemPasswordChar = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 147);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtpword);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.lblowrd);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.btnlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblowrd;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtuname;
    }
}

