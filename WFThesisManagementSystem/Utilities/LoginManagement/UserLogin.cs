using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.StudentViews.Views;
using WFThesisManagementSystem.TeacherViews.Views;

namespace WFThesisManagementSystem.Utilities.LoginManagement
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

            // đang xử lý phần check nếu student chưa có nhóm thì đẩy qua form register else đẩy qa dashboard
            if (studentTable.Rows.Count > 0)
            {
                StudentDAO studentDAO = new StudentDAO();
                Student student = new Student();
                student.Id = int.Parse(studentDAO.GetStudentIDFromUsername(username));
                //student.groupID = int.Parse(studentDAO.GetGroupIDOfStudent(student.Id));

                if (studentDAO.GetGroupIDOfStudent(student.Id).Length != 0)
                {
                    MessageBox.Show(studentDAO.GetGroupIDOfStudent(student.Id));
                    FStudentDashboard studentDashboard = new FStudentDashboard(studentDAO.GetStudentIDFromUsername(username));
                    connection.Close();
                    studentDashboard.Show();
                    return true;
                }
                else
                {
                    FStudentRegisterTopic studentRegisterTopic = new FStudentRegisterTopic();
                    connection.Close();
                    studentRegisterTopic.Show();
                    return true;
                }
            }
            else if (teacherTable.Rows.Count > 0)
            {
                FTeacherDashboard teacherDashboard = new FTeacherDashboard();
                connection.Close();
                teacherDashboard.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                connection.Close();
                return false;
            }
        }
    }
}
