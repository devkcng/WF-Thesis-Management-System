using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.StudentViews.Views;
using WFThesisManagementSystem.TeacherViews.Views;

namespace WFThesisManagementSystem.Helper
{
    public class UserLoginHelper
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public bool Login(string username, string password)
        {
            //DBConnect dBConnect = new DBConnect();
            //var connection = dBConnect._conn;
            //connection.Open();

            //string studentQuery = "SELECT * FROM StudentAccount WHERE student_username = @Username AND student_password = @Password";
            //SqlCommand studentCommand = new SqlCommand(studentQuery, connection);
            //studentCommand.Parameters.AddWithValue("@Username", username);
            //studentCommand.Parameters.AddWithValue("@Password", password);


            //string teacherQuery = "SELECT * FROM TeacherAccount WHERE teacher_username = @Username AND teacher_password = @Password";
            //SqlCommand teacherCommand = new SqlCommand(teacherQuery, connection);
            //teacherCommand.Parameters.AddWithValue("@Username", username);
            //teacherCommand.Parameters.AddWithValue("@Password", password);


            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable studentTable = new DataTable();
            //adapter.SelectCommand = studentCommand;
            //adapter.Fill(studentTable);

            //DataTable teacherTable = new DataTable();
            //adapter.SelectCommand = teacherCommand;
            //adapter.Fill(teacherTable);

            //// đang xử lý phần check nếu student chưa có nhóm thì đẩy qua form register else đẩy qa dashboard
            //if (studentTable.Rows.Count > 0)
            //{
            //    StudentDAO studentDAO = new StudentDAO();
            //    Student student = new Student();
            //    student.student_id = int.Parse(studentDAO.GetStudentIDFromUsername(username));
            //    //student.groupID = int.Parse(studentDAO.GetGroupIDOfStudent(student.Id));
            //    FStudentRegisterTopic studentRegisterTopic = new FStudentRegisterTopic(student.student_id);
            //    connection.Close();
            //    studentRegisterTopic.Show();
            //    return true;
            //}
            //else if (teacherTable.Rows.Count > 0)
            //{
            //    FTeacherDashboard teacherDashboard = new FTeacherDashboard();
            //    connection.Close();
            //    teacherDashboard.Show();
            //    return true;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password.");
            //    connection.Close();
            //    return false;
            //}
            ThesisManagementContext context = new ThesisManagementContext();
            var student = context.StudentAccounts.Find(username);
            var teacher = context.TeacherAccounts.Find(username);
            if (student != null)
            {
                if (student.student_password == password)
                {
                    UserName = student.student_username;
                    Password = student.student_password;
                    StudentDAO studentDAO = new StudentDAO();
                    Student student1 = new Student();
                    student1.student_id = int.Parse(studentDAO.GetStudentIDFromUsername(username));
                    //student.groupID = int.Parse(studentDAO.GetGroupIDOfStudent(student.Id));
                    FStudentRegisterTopic studentRegisterTopic = new FStudentRegisterTopic(student1.student_id);
                    studentRegisterTopic.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return false;
                }
            }
            else if (teacher != null)
            {
                if (teacher.teacher_password == password)
                {
                    UserName = teacher.teacher_username;
                    Password = teacher.teacher_password;
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
            else
            {
                MessageBox.Show("Invalid username or password.");
                return false;
            }
        }
    }
}
