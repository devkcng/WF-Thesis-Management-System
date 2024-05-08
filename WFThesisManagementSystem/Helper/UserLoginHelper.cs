using System.Windows.Forms;

using WFThesisManagementSystem.Forms.StudentViews.Views;
using WFThesisManagementSystem.Forms.TeacherViews.Views;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class UserLoginHelper
    {
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        private ThesisManagementContext _context;

        public UserLoginHelper(ThesisManagementContext context)
        {
            _context = context;
        }

        public bool Login(string username, string password)
        {

            StudentAccountRepository studentAccountRepository = new StudentAccountRepository(_context);
            TeacherAccountRepository teacherAccountRepository = new TeacherAccountRepository(_context);
            var student = studentAccountRepository.GetByUsername(username);
            var teacher = teacherAccountRepository.GetByUsername(username);
            if (student != null)
            {
                if (student.student_password == password)
                {
                    _userSessionHelper.UserName = student.student_username;
                    _userSessionHelper.Password = student.student_password;
                    if (student.student_id != null) _userSessionHelper.UserID = (int)student.student_id;
                    FStudentRegisterTopic studentRegisterTopic = new FStudentRegisterTopic(_context);
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
                    _userSessionHelper.UserName = teacher.teacher_username;
                    _userSessionHelper.Password = teacher.teacher_password;
                    if (teacher.teacher_id != null) _userSessionHelper.UserID = (int)teacher.teacher_id;
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
