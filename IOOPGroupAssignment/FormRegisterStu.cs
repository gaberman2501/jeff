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
    public partial class FormRegisterStu : Form
    {
        public FormRegisterStu()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string tableName = "Student";
            string column1Value = txtStudID.Text;  
            string column2Value = txtStudName.Text;
            string column3Value = txtStudNum.Text;
            string column4Value= txtStudMail.Text;
            string column5Value = txtStudYear.Text;

            Lecturer addMethod = new Lecturer();
            addMethod.RegisterStudent(tableName, column1Value, column2Value, column3Value, column4Value, column5Value);
        }
    }
}
