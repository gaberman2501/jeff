using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOOPGroupAssignment
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtuname.Clear();
            txtpword.Clear();
        }


        public void btnlogin_Click(object sender, EventArgs e)
        {
            Profile storeusername = new Profile(txtuname.Text);

            string entereduname = txtuname.Text;
            string enteredpword = txtpword.Text;

            Profile login = new Profile();

            login.loginMethod(entereduname, enteredpword);
        }
    }
}
