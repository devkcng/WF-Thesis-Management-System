using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.UC
{
    public partial class FNotificationSendStudent : Form
    {
        private ThesisManagementContext _context;
        private int _notification_id;
        private NotificationRepository _notificationRepository;
        private StudentRepository _studentRepository;
        private StudentGroupRepository _studentGroupRepository;
        private TopicRepository _topicRepository;
        private List<Student> _students = new List<Student>();
        private List<int> Group_Id = new List<int>();
        private NotificationService _notificationService ;

        public FNotificationSendStudent(int notification_id , ThesisManagementContext context)
        {
            InitializeComponent();
            _notification_id = notification_id;
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _notificationService = new NotificationService(_context);
            ucNotificationSendStudentAll1.btnBackToEdit.Click += Close;
            ucNotificationSendStudentAll1.btnSend.Click += Send;
        }
        private void List_Load_Group()
        {
            ucNotificationSendStudentAll1.flpNotificationGroup.Controls.Clear();
            var Table = _studentGroupRepository.GetAll();
            foreach (var studentGroup in Table)
            {
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = studentGroup.group_name;
                ucTeacherAcceptRegisterSingle.Id = studentGroup.group_id;
                var topic = _topicRepository.GetById((int)studentGroup.topic_id);
                ucTeacherAcceptRegisterSingle.IdStudent = topic.topic_name;
                ucTeacherAcceptRegisterSingle.Clicked += List_Load_Student;
                ucTeacherAcceptRegisterSingle.CheckClicked += Choose_Student;
                ucTeacherAcceptRegisterSingle.Regist = "Select";
                ucNotificationSendStudentAll1.flpNotificationGroup.Controls.Add(ucTeacherAcceptRegisterSingle);
            }

        }
        private void Choose_Student(object sender, EventArgs e)
        {
            Load_Student();
        }
        private void Load_Student()
        {
            foreach(Control uc in ucNotificationSendStudentAll1.flpNotificationStudent.Controls)
            {
                if(uc is UserControl)
                {
                    UcTeacherAcceptRegisterSingle ucSmall = (UcTeacherAcceptRegisterSingle)uc;
                    ucSmall.cbxRegist.Checked = true;
                    var student = _studentRepository.GetById(int.Parse(ucSmall.IdStudent));
                    _students.Add(student);
                }    
            }
           
        }
        private void List_Load_Student(object sender, EventArgs e)
        {
            ucNotificationSendStudentAll1.flpNotificationStudent.Controls.Clear();
            UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle1 = sender as UcTeacherAcceptRegisterSingle;
            var Table = _studentRepository.GetAllByGroupId(ucTeacherAcceptRegisterSingle1.Id);
            foreach (var student in Table)
            {
                    UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                    ucTeacherAcceptRegisterSingle.NameStudent = student.student_name;
                    ucTeacherAcceptRegisterSingle.IdStudent = Convert.ToString(student.student_id);
                    ucTeacherAcceptRegisterSingle.Regist = "Select";
                    ucNotificationSendStudentAll1.flpNotificationStudent.Controls.Add(ucTeacherAcceptRegisterSingle);
            }

        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Send(object sender, EventArgs e)
        {
            
            NotificationMessage notificationMessage = new NotificationMessage();
            var notification = _notificationRepository.GetById(_notification_id);
            notificationMessage.Title = notification.notification_title;
            notificationMessage.Message = notification.notification_content;
            notificationMessage.Type = notification.notification_type;
            _notificationService.SendToStudent(_students, notificationMessage);
            if(_notificationService.CheckSendNotification(_students))
            {
                MessageBox.Show("Send To Student Success");
            }
            else MessageBox.Show("Send To Student Failture");


        }

        private void FNotificationSendStudent_Load(object sender, EventArgs e)
        {
            List_Load_Group();
        }
    }
}
