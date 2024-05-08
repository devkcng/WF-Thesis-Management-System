using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;
using Task = WFThesisManagementSystem.Models.Task;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherCreateTask : Form
    {
        int GroupId;
        TaskService _taskService;
        private ThesisManagementContext _context;
        StudentGroupRepository _studentGroupRepository;
        public FTeacherCreateTask(int Id, ThesisManagementContext context)
        {
            InitializeComponent();
            GroupId = Id;
            _context = context;
            _studentGroupRepository = new StudentGroupRepository(_context);
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
            Task task = new Task();
            task.task_name = ucTeacherCreateTask1.txtTaskName.Text;
            task.task_description = ucTeacherCreateTask1.txtTaskDescription.Text;
            task.due_date = ucTeacherCreateTask1.dtpEndDate.Value.Date;
            task.group_id = _studentGroupRepository.GetByGroupName(ucTeacherCreateTask1.cboGroupList.Text).group_id;
            _taskService = new TaskService(task, _context);
            _taskService.CreateTask();
            this.Close();
        }

        private void ucTeacherCreateTask1_Load(object sender, EventArgs e)
        {
            ucTeacherCreateTask1.dtpEndDate.Value = DateTime.Now;
            var studentGroups = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroups)
            {
                ucTeacherCreateTask1.cboGroupList.Items.Add(studentGroup.group_name);
            }
        }
    }
}
