using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOOPGroupAssignment
{
    public partial class FormEnrollStu : Form
    {
        public FormEnrollStu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (LecturerHome form2 = new LecturerHome())
            {
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void FormEnrollStu_Load(object sender, EventArgs e)
        {
            cmbSelectStu.Items.Clear();
            
            Lecturer selectstud = new Lecturer();
            string tableName = "Student";
            string ValueToSelect = "StudentID";
            ArrayList studList = selectstud.loadStu(tableName, ValueToSelect);

            foreach (var item in studList)
            {
                cmbSelectStu.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Lecturer selectMethod = new Lecturer();
            string tableName = "Student";
            string ValueToSelect = cmbSelectStu.SelectedItem.ToString();

            txtStudName.Text = selectMethod.selectStu(tableName, ValueToSelect);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studclass = cmbSelectStuClass.SelectedItem.ToString();
            string studlevel = cmbSelectStuLevel.SelectedItem.ToString();

            Lecturer enrolMethod = new Lecturer();
            enrolMethod;
        }
    }
}
