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
    public partial class FormUpdateStuEnrolment : Form
    {
        public FormUpdateStuEnrolment()
        {
            InitializeComponent();
        }

        private void FormUpdateStuEnrolment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasetestDataSet.Student' table. You can move, or remove it, as needed.
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (LecturerHome form2 = new LecturerHome())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }
    }
}
