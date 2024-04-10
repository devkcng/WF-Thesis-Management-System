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
        
        private NotificationRepository _notificationRepository;
        private StudentRepository _studentRepository;
        private StudentGroupRepository _studentGroupRepository;
        private TopicRepository _topicRepository;
        private List<Student> _students;
        private NotificationService _notificationService ;
        private NotificationMessage _notificationMessage;

        public FNotificationSendStudent(NotificationMessage message , ThesisManagementContext context)
        {
            InitializeComponent();
            _notificationMessage = message;
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _students = new List<Student>();
            _notificationService = new NotificationService(_context);
            ucNotificationSendStudentAll1.btnBackToEdit.Click += Close;
            ucNotificationSendStudentAll1.btnSend.Click += Send;
        }

        private void FNotificationSendStudent_Load(object sender, EventArgs e)
        {
            List_Load_Group();
        }

        #region InitUsercontrol
        private void List_Load_Group()
        {
            ucNotificationSendStudentAll1.flpNotificationGroup.Controls.Clear();
            var studentGroups = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroups)
            {
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = studentGroup.group_name;
                ucTeacherAcceptRegisterSingle.Id = studentGroup.group_id;

                var topic = _topicRepository.GetById((int)studentGroup.topic_id);

                ucTeacherAcceptRegisterSingle.IdStudent = topic.topic_name; //show topic name

                ucTeacherAcceptRegisterSingle.Clicked += OnClicked_UcGroup;
                ucTeacherAcceptRegisterSingle.CheckClicked += Choose_Student;
                ucTeacherAcceptRegisterSingle.Regist = "Select";
                ucNotificationSendStudentAll1.flpNotificationGroup.Controls.Add(ucTeacherAcceptRegisterSingle);
            }

        }
        #endregion

        #region OnclickedGroupEventHandler 

        private void OnClicked_UcGroup(object sender, EventArgs e)
        {
            
            List_Load_Student(sender, e);
        }

        private void List_Load_Student(object sender, EventArgs e)
        {   
            ucNotificationSendStudentAll1.flpNotificationStudent.Controls.Clear();
            UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle1 = sender as UcTeacherAcceptRegisterSingle;
            var students = _studentRepository.GetAllByGroupId(ucTeacherAcceptRegisterSingle1.Id);
            foreach (var student in students)
            {
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = student.student_name;
                ucTeacherAcceptRegisterSingle.IdStudent = Convert.ToString(student.student_id);
                ucTeacherAcceptRegisterSingle.Regist = "Select";
                //if (student.group_id == ucTeacherAcceptRegisterSingle1.Id)
                //{ 
                //    ucTeacherAcceptRegisterSingle.cbxRegist.Checked = ucTeacherAcceptRegisterSingle1.cbxRegist.Checked;
                //}

                if (_students.Contains(student))
                {
                    ucTeacherAcceptRegisterSingle.cbxRegist.Checked = true;
                }
                else
                {
                    ucTeacherAcceptRegisterSingle.cbxRegist.Checked = false;
                }
                ucTeacherAcceptRegisterSingle.cbxRegist.Checked = ucTeacherAcceptRegisterSingle1.cbxRegist.Checked;
                ucTeacherAcceptRegisterSingle.CheckClicked += PickStudent;
                ucNotificationSendStudentAll1.flpNotificationStudent.Controls.Add(ucTeacherAcceptRegisterSingle);
            }

        }

        #endregion

        #region CheckboxGroupEventHandler
        private void Choose_Student(object sender, EventArgs e)
        {   
            Load_Student(sender);
            PickStudentByGroupCheckbox(sender);
        }
        private void Load_Student(object sender)
        {   
            UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = sender as UcTeacherAcceptRegisterSingle;
            foreach(Control uc in ucNotificationSendStudentAll1.flpNotificationStudent.Controls)
            {
                if(uc is UserControl)
                {
                    try
                    {
                        UcTeacherAcceptRegisterSingle ucSmall = (UcTeacherAcceptRegisterSingle)uc;
                        var student = _studentRepository.GetById(int.Parse(ucSmall.IdStudent));
                        if (student.group_id == ucTeacherAcceptRegisterSingle.Id)
                        {
                            ucSmall.cbxRegist.Checked = ucTeacherAcceptRegisterSingle.cbxRegist.Checked;
                            //if student is already in list, don't add again
                            if (!_students.Contains(student))
                            {
                                _students.Add(student);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }    
            }
        }

        //function to add all student in group to list student to send notification. dont add student already in list.
        //this function when user click on group checkbox and dont need to load usercontrol student
        private void PickStudentByGroupCheckbox(object sender)
        {
            UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = sender as UcTeacherAcceptRegisterSingle;
            var students = _studentRepository.GetAllByGroupId(ucTeacherAcceptRegisterSingle.Id);
            foreach (var student in students)
            {
                if (ucTeacherAcceptRegisterSingle.cbxRegist.Checked)
                {
                    if (!_students.Contains(student))
                    {
                        _students.Add(student);
                    }
                }
                else
                {
                    if (_students.Contains(student))
                    {
                        _students.Remove(student);
                    }
                }
            }
        }

        #endregion

        #region CheckboxStudentEventHandler

        void PickStudent(object sender, EventArgs e)
        {
            UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = sender as UcTeacherAcceptRegisterSingle;
            var student = _studentRepository.GetById(int.Parse(ucTeacherAcceptRegisterSingle.IdStudent));
            if (ucTeacherAcceptRegisterSingle.cbxRegist.Checked)
            {
                if (!_students.Contains(student))
                {
                    _students.Add(student);
                }
            }
            else
            {
                if (_students.Contains(student))
                {
                    _students.Remove(student);
                }
            }
        }

        #endregion

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Send(object sender, EventArgs e)
        {
            
            _notificationService.SendToStudent(_students, _notificationMessage);

            if(_notificationService.CheckSendNotification(_students))
            {
                MessageBox.Show("Send To Student Success");
            }
            else MessageBox.Show("Send To Student Failture");

        }
    }
}
