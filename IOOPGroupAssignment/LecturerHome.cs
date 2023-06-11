using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPGroupAssignment
{
    public partial class LecturerHome : Form
    {

        public LecturerHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (LoginForm form2 = new LoginForm())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void btnProfUpdate_Click(object sender, EventArgs e)
        {
            using (FormUpdateLecProfile form2 = new FormUpdateLecProfile())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void btnRegStud_Click(object sender, EventArgs e)
        {
            using (FormRegisterStu form2 = new FormRegisterStu())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            using (FormDeleteStu form2 = new FormDeleteStu())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void btnStudEnroll_Click(object sender, EventArgs e)
        {
            using (FormEnrollStu form2 = new FormEnrollStu())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void btnStudUpEn_Click(object sender, EventArgs e)
        {
            using(FormUpdateStuEnrolment form2 = new FormUpdateStuEnrolment())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void LecturerHome_Load(object sender, EventArgs e)
        {
            string value = Profile.username;
            lblWelcome.Text = "Welcome " + value;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
