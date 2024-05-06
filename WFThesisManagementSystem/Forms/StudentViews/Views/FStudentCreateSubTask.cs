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

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentCreateSubTask : Form
    {
        int _taskID;
        TaskRepository _taskRepository;
        SubTaskService _subTaskService;
        private ThesisManagementContext _context;
        StudentRepository _studentRepository;
        public FStudentCreateSubTask(int taskID,ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(600, 500);
            _context = context;
            _taskID=taskID;
            _studentRepository = new StudentRepository(_context);
            _taskRepository= new TaskRepository(_context);
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
            SubTask subTask = new SubTask();
            subTask.subtask_name = ucTeacherCreateTask1.txtTaskName.Text;
            subTask.subtask_description = ucTeacherCreateTask1.txtTaskDescription.Text;
            subTask.due_date = ucTeacherCreateTask1.dtpEndDate.Value.Date;
            subTask.student_id = _studentRepository.GetByStudentName(ucTeacherCreateTask1.cboGroupList.Text).student_id;
            subTask.task_id = _taskID;
            _subTaskService = new SubTaskService(subTask, _context);
            _subTaskService.CreateSubTask();
            this.Close();
        }
        private void ucTeacherCreateTask1_Load(object sender, EventArgs e)
        {
            ucTeacherCreateTask1.dtpEndDate.Value = DateTime.Now;
            ucTeacherCreateTask1.lblGroup.Text = "Member";
            var task = _taskRepository.GetById(_taskID);
            var students = _studentRepository.GetAllByGroupId(task.group_id.Value);
            foreach (var student in students)
            {
                ucTeacherCreateTask1.cboGroupList.Items.Add(student.student_name);
            }
        }
    }
}
