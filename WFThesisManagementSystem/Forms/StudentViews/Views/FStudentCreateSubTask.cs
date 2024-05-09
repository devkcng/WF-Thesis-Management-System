using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentCreateSubTask : Form
    {
        int _taskID;
        TaskRepository _taskRepository;
        SubTaskRepository _subTaskRepository;
        SubTaskService _subTaskService;
        private ThesisManagementContext _context;
        StudentRepository _studentRepository;
        NotificationService _notificationService;
        public FStudentCreateSubTask(int taskID, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(600, 500);
            _context = context;
            _taskID = taskID;
            _studentRepository = new StudentRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subTaskRepository = new SubTaskRepository(_context);
            _notificationService = new NotificationService(_context);
            ucTeacherCreateTask1.btnClose.Click += Close;
            ucTeacherCreateTask1.btnSave.Click += Save;
            ucTeacherCreateTask1.Load += ucTeacherCreateTask1_Load;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save(object sender, EventArgs e)
        {       
            var student= _studentRepository.GetByStudentName(ucTeacherCreateTask1.cboGroupList.Text);
            if (_subTaskRepository.GetByStudentIdAndTaskId(student.student_id, _taskID) == null)
            {
                SubTask subTask = new SubTask();
                subTask.subtask_name = ucTeacherCreateTask1.txtTaskName.Text;
                subTask.subtask_description = ucTeacherCreateTask1.txtTaskDescription.Text;
                subTask.due_date = ucTeacherCreateTask1.dtpEndDate.Value.Date;
                subTask.student_id = student.student_id;
                subTask.task_id = _taskID;
                _subTaskService = new SubTaskService(subTask, _context);
                _subTaskService.CreateSubTask();

                //Create Notification when create subtask
                var message = new NotificationMessage
                {
                    Title = subTask.subtask_name,
                    Message = subTask.subtask_description,
                    Type = "Subtask Assignment"
                };
                _notificationService.SendToStudent(student, message);
                this.Close(); 
            }
            else MessageBox.Show("Each student can by assigned only 1 subtask of each task");
        }
        private void ucTeacherCreateTask1_Load(object sender, EventArgs e)
        {
            var task = _taskRepository.GetById(_taskID);
            ucTeacherCreateTask1.dtpEndDate.Value = DateTime.Now;
            ucTeacherCreateTask1.dtpEndDate.MaxDate = task.due_date.Value;
            ucTeacherCreateTask1.dtpEndDate.MinDate = task.open_day.Value;

            ucTeacherCreateTask1.lblGroup.Text = "Member";
            var students = _studentRepository.GetAllByGroupId(task.group_id.Value);
            foreach (var student in students)
            {
                ucTeacherCreateTask1.cboGroupList.Items.Add(student.student_name);
            }
        }
    }
}
