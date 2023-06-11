using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPGroupAssignment
{
    public class Profile
    {
        public static string username;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        } 

        public Profile(string uname)
        {
            username = uname;
        }

        public Profile()
        {
        }

        public void loginMethod(string entereduname, string enteredpword)
        {
            bool isValid()
            {
                if (entereduname == string.Empty)
                {
                    MessageBox.Show("Please enter a username.");
                    return false;
                }

                else if (enteredpword == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                    return false;
                }
                return true;

            }

            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive - Asia Pacific University\IOOPGroupAssignment\IOOPGroupAssignment\databasetest.mdf;Integrated Security=True"))
                {
                    string loginquery = "SELECT * FROM users WHERE username = @username AND pword = @password";
                    SqlDataAdapter sda = new SqlDataAdapter(loginquery, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@username", entereduname);
                    sda.SelectCommand.Parameters.AddWithValue("@password", enteredpword);

                    DataTable dta = new DataTable();
                    sda.Fill(dta);

                    if (dta.Rows.Count == 1)
                    {
                        string roleQuery = "SELECT urole FROM users WHERE username = @username AND pword = @password";
                        SqlDataAdapter sda2 = new SqlDataAdapter(roleQuery, conn);
                        sda2.SelectCommand.Parameters.AddWithValue("@username", entereduname);
                        sda2.SelectCommand.Parameters.AddWithValue("@password", enteredpword);

                        DataTable dta2 = new DataTable();
                        sda2.Fill(dta2);

                        string role = dta2.Rows[0]["urole"].ToString();

                        if (role == "admin")
                        {
                            using (AdminHome form2 = new AdminHome())
                            {
                                form2.Show();
                            }
                        }

                        else if (role == "student")
                        {
                            using (StudentHome form2 = new StudentHome())
                            {
                                form2.Show();
                            }
                        }

                        else if (role == "lecturer")
                        {
                            using (LecturerHome form2 = new LecturerHome())
                            {
                                form2.ShowDialog();
                            }
                        }

                        else if (role == "trainer")
                        {
                            using (TrainerHome form2 = new TrainerHome())
                            {
                                form2.Show();
                            }
                        }

                    }

                    else if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("Please enter valid login details.");
                    }


                }
            }

        }

        public void updateMethod(string enteredpword)
        {

        }

    }
}








