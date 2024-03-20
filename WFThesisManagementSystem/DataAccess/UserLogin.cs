using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.StudentViews.Views;
using WFThesisManagementSystem.TeacherViews.Views;

namespace WFThesisManagementSystem.DataAccess
{
    public class UserLogin
    {
        public bool Login(string username, string password)
        {
            DBConnect dBConnect = new DBConnect();
            var connection = dBConnect._conn;
                connection.Open();

                
                string studentQuery = "SELECT * FROM StudentAccount WHERE student_username = @Username AND student_password = @Password";
                SqlCommand studentCommand = new SqlCommand(studentQuery, connection);
                studentCommand.Parameters.AddWithValue("@Username", username);
                studentCommand.Parameters.AddWithValue("@Password", password);

                
                string teacherQuery = "SELECT * FROM TeacherAccount WHERE teacher_username = @Username AND teacher_password = @Password";
                SqlCommand teacherCommand = new SqlCommand(teacherQuery, connection);
                teacherCommand.Parameters.AddWithValue("@Username", username);
                teacherCommand.Parameters.AddWithValue("@Password", password);

                
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable studentTable = new DataTable();
                adapter.SelectCommand = studentCommand;
                adapter.Fill(studentTable);

                DataTable teacherTable = new DataTable();
                adapter.SelectCommand = teacherCommand;
                adapter.Fill(teacherTable);

                
                if (studentTable.Rows.Count > 0)
                {
                    FStudentDashboard studentDashboard = new FStudentDashboard();
                    studentDashboard.Show();
                    return true;
                }
                else if (teacherTable.Rows.Count > 0)
                {
                    FTeacherDashboard teacherDashboard = new FTeacherDashboard();
                    teacherDashboard.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return false;
                }
        }
    }
}
