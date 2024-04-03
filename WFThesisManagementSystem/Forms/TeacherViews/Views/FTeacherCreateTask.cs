using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Services;
using Task = WFThesisManagementSystem.Models.Task;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherCreateTask : Form
    {
        int GroupId;
        TaskService _taskService;
        private ThesisManagementContext _context;
        public FTeacherCreateTask(int Id, ThesisManagementContext context)
        {
            InitializeComponent();
            GroupId = Id;
            //_taskService = new TaskService(task);
            _context = context;
            ucTeacherCreateTask1.btnClose.Click += Close;
            ucTeacherCreateTask1.btnSave.Click += Save;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Save(object sender, EventArgs e)
        {
            Task task = new Task();
            task.task_name = ucTeacherCreateTask1.txtTaskName.Text;
            task.task_description = ucTeacherCreateTask1.txtTaskDescription.Text;
            task.due_date = ucTeacherCreateTask1.dtpEndDate.Value;
            task.group_id = GroupId;
            _taskService = new TaskService(task, _context);
            _taskService.CreateTask();
            this.Hide();
        }

    }
}
