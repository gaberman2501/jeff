using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPGroupAssignment
{
    public class Lecturer
    {
        private string lecID;
        private string lecName;
        private string contactnum;
        private string lecEmailAdd;
        private string lecclass;

        public string LecID 
        {
            get { return lecID; }
            set { lecID = value; } 
        }
        public string LecName 
        {
            get { return lecName; }
            set { lecName = value; }
        }
        public string ContactNum 
        {
            get { return contactnum; }
            set { contactnum = value; }
        }
        public string LecEmailAdd 
        {
            get { return lecEmailAdd; }
            set { lecEmailAdd = value; }
        }
        public string LecClass 
        {
            get { return lecclass; }
            set { lecclass = value; }
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\IOOPGroupAssignment\\databasetest.mdf;Integrated Security=True";

        public Lecturer GetLecDets()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM YourTable WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", Profile.username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Lecturer lecDetails  = new Lecturer();
                    lecDetails.LecID = (string)reader["LecturerID"];
                    lecDetails.LecName = (string)reader["Name"];
                    lecDetails.ContactNum = (string)reader["ContactNum"];
                    lecDetails.LecEmailAdd = (string)reader["EmailAddress"];
                    lecDetails.LecClass = (string)reader["Class"];

                    return lecDetails;
                }
            }

            return null;
        }

        public void RegisterStudent(string tableName, string column1Value, string column2Value, string column3Value, string column4Value, string column5Value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAdd = $"INSERT INTO {tableName} (StudentID, StuName, ContactNum, EmailAddress, StuYear ) VALUES (@Column1, @Column2, @Column3, @Column4, @Column5)";

                using (SqlCommand command = new SqlCommand(queryAdd, connection))
                {
                    command.Parameters.AddWithValue("@Column1", column1Value);
                    command.Parameters.AddWithValue("@Column2", column2Value);
                    command.Parameters.AddWithValue("@Column3", column3Value);
                    command.Parameters.AddWithValue("@Column4", column4Value);
                    command.Parameters.AddWithValue("@Column5", column5Value);

                    command.ExecuteNonQuery();
                }
            }
        }


        public ArrayList loadStu(string tableName, string ValueToSelect)
        {
                ArrayList studs = new ArrayList();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                connection.Open();

                string querySelect = $"SELECT StudentID FROM {tableName}";

                SqlCommand cmd = new SqlCommand(querySelect, connection);
                SqlDataReader rdr = cmd.ExecuteReader(); 

                    while (rdr.Read())
                    {
                        string studentName = (string)rdr["StudentID"];
                        studs.Add(studentName);
                    }
                }


            return studs;
        }

        public string selectStu(string tableName, string ValueToSelect)
        {
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 connection.Open();

                 string querySelect = $"SELECT StuName FROM {tableName} WHERE StudentID = @ToSelect";

                 using (SqlCommand command = new SqlCommand(querySelect, connection))
                 {
                    command.Parameters.AddWithValue("TableName", tableName);
                    command.Parameters.AddWithValue("ToSelect", ValueToSelect);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string studentName = (string)reader["StuName"];
                                return studentName;
                            }
                        }
                 }
             }
                return string.Empty;
        }

        public void EnrolStudent(string tableName, string column1Value, string column2Value, string column3Value, string column4Value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAdd = $"INSERT INTO {tableName} (StudentID, StuName, ContactNum, EmailAddress, StuYear ) VALUES (@Column1, @Column2, @Column3, @Column4, @Column5)";

                using (SqlCommand command = new SqlCommand(queryAdd, connection))
                {
                    command.Parameters.AddWithValue("@Column1", column1Value);
                    command.Parameters.AddWithValue("@Column2", column2Value);
                    command.Parameters.AddWithValue("@Column3", column3Value);
                    command.Parameters.AddWithValue("@Column4", column4Value);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

 