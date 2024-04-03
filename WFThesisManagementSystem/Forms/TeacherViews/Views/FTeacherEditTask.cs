using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherEditTask : Form
    {
        private Task _task;
        private TaskService _taskService;
        public FTeacherEditTask(Task task)
        {
            InitializeComponent();
            var _context = new ThesisManagementContext();
            _task = task;
            _taskService = new TaskService(task);
            ucTeacherEditTask1.btnClose.Click += Close;
            ucTeacherEditTask1.btnUpdate.Click += Update;
            ucTeacherEditTask1.btnDelete.Click += Delete;
        }
        
        private void Close(object sender, EventArgs e) { 
            this.Hide(); }
        private void Update(object sender, EventArgs e) 
        {
            _taskService.UpdateTask();
            //_taskRepository.UpdateTask(_task);
        }
        private void Delete(object sender, EventArgs e) 
        { 
            _taskService.DeleteTask();
        }

        private void FTeacherEditTask_Load_1(object sender, EventArgs e)
        {
            ucTeacherEditTask1.txtTaskDescription.Text = _task.task_description;
            ucTeacherEditTask1.txtTaskName.Text = _task.task_name;
            ucTeacherEditTask1.dtpEndDate.Value = _task.due_date.Value;
        }
    }
}
