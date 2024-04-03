using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using UserControl = System.Windows.Forms.UserControl;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        ThesisManagementContext _context;
        StudentRepository _studentRepository;
        TaskRepository _taskRepository;
        SubTaskRepository _subtaskRepository;
        StudentGroupRepository _studentgroupRepository;
        public FStudentDashboard()
        {
            _context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subtaskRepository = new SubTaskRepository(_context);
            _studentgroupRepository = new StudentGroupRepository(_context);
            InitializeComponent();
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Hide();

            

            ucStudentTask1.Show();
        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Show();
            ucStudentWorkLogs1.Hide();
        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Show();
        }

 

        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Close();
        }

        private void performance_Click(object sender, EventArgs e)
        {

        }

        private void ucStudentTask1_Load(object sender, EventArgs e)
        {
            ListTasks();
        }

        #region ucStudentTask1-Components

        private void ListTasks()
        {
            ucStudentTask1.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetAll().Where(t => t.group_id.Value == groupID);
            foreach (var groupTask in groupTaskList)
            {

                UCTask uCTask = new UCTask();
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.GroupID = groupID.Value;
                uCTask.lblOpenDay.Text = groupTask.open_day.ToString();
                uCTask.lblDeadline.Text = groupTask.due_date.ToString();
                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCTask.Clicked += ucTask_Clicked;
                ucStudentTask1.flpGroupTaskView.Controls.Add(uCTask);
            }


            var subTaskList = _subtaskRepository.GetAll().Where(t => t.student_id == _userSessionHelper.UserID);
            //add data to subtask flow layout panel
            ucStudentTask1.flpAllInvidualTasksView.Controls.Clear();
            foreach (var subTask in subTaskList)
            {

                UCInvidualTask uCInvidualTask = new UCInvidualTask();
                uCInvidualTask.lblName.Text = subTask.subtask_name;
                //uCInvidualTask.SubmitDate = subTask.submit_day.Value;
                uCInvidualTask.Id = subTask.subtask_id;
                uCInvidualTask._StudentID = subTask.student_id.Value;
                uCInvidualTask.txtProjectDetail.Text = subTask.subtask_description;
                uCInvidualTask.lblOpenDay.Text = subTask.open_day.ToString();
                uCInvidualTask.lblDeadline.Text = subTask.due_date.ToString();
                if (subTask.submit_day != null) { uCInvidualTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_; }
                else { uCInvidualTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCInvidualTask.Clicked += ucInvidual_Clicked;
                ucStudentTask1.flpAllInvidualTasksView.Controls.Add(uCInvidualTask);
            }
        }
        #endregion

        #region ucTask-Events

        // when click on a Group task -> show subtask 

        private void ucTask_Clicked(object sender, EventArgs e)
        {
            UCTask uCTask = sender as UCTask;
            var taskID = uCTask.Id;
            var groupID = uCTask.GroupID;

            ucStudentTask1.Hide();
            ucsTudentSubTasks2.Show();

            var subTaskList = _subtaskRepository.GetAll().Where(t => t.task_id == taskID);
            //add data to subtask flow layout panel
            ucsTudentSubTasks2.flpAllTasks.Controls.Clear();
            foreach (var subTask in subTaskList)
            {
                UCSubTasks uCSubTask = new UCSubTasks();
                uCSubTask.lblName.Text = subTask.subtask_name;
                uCSubTask.txtProjectDetail.Text = subTask.subtask_description;
                uCSubTask.lblOpenDay.Text = subTask.open_day.ToString();
                uCSubTask.lblDeadline.Text = subTask.due_date.ToString();
                uCSubTask.lblMember.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                if (subTask.submit_day != null) { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                ucsTudentSubTasks2.flpAllTasks.Controls.Add(uCSubTask);
            }

            //add data student member group
            ucsTudentSubTasks2.flpAllMemberView.Controls.Clear();
            var memberList = _studentRepository.GetAll().Where(t => t.group_id == groupID);
            foreach (var member in memberList)
            {
                UCStudentInformation uCStudentInformation = new UCStudentInformation();
                uCStudentInformation.lblName.Text = member.student_name;
                ucsTudentSubTasks2.flpAllMemberView.Controls.Add(uCStudentInformation);
            }
        }

        #endregion

        #region uCInvidualTask-Events
        //when click on a submit button --> show a submit form
        private void ucInvidual_Clicked(object sender, EventArgs e)
        {
            UCInvidualTask uCInvidualTask = sender as UCInvidualTask;
            FStudentTaskPopUp fStudentTaskPopUp = new FStudentTaskPopUp();
            fStudentTaskPopUp.Id = uCInvidualTask.Id;
            fStudentTaskPopUp.lblSubTaskName.Text = uCInvidualTask.lblName.Text;
            fStudentTaskPopUp.lblStudentname.Text = _studentRepository.GetById(uCInvidualTask._StudentID).student_name;
            //if (uCInvidualTask.SubmitDate != null) { fStudentTaskPopUp.ptbStatus1.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
            //else { fStudentTaskPopUp.ptbStatus1.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
            fStudentTaskPopUp.lblSubmitDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            fStudentTaskPopUp.ShowDialog();
        }
        #endregion



    }
}
