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
        TopicRepository _topicRepository;
        TeacherRepository _teacherRepository;
        public FStudentDashboard()
        {
            _context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subtaskRepository = new SubTaskRepository(_context);
            _studentgroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            InitializeComponent();
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Hide();
            ucStudentProject1.Hide();
            
        }


        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Hide();
            ucStudentProject1.Show();
        }
        private void task_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Show();
            ucStudentWorkLogs1.Hide();
            ucStudentProject1.Hide();

        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Show();
            ucStudentProject1.Hide();

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
        private void ucStudentProject1_Load(object sender, EventArgs e)
        {
            ListTopics();
        }
        #region ucStudentProject1-Components
        private void ListTopics()
        {
            ucStudentProject1.flpAllTopics.Controls.Clear();
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroup = _studentgroupRepository.GetById(student.group_id.Value);
            var topic = _topicRepository.GetById(studentGroup.topic_id.Value);

            UCProject uCProject = new UCProject();
            uCProject.lblProjectName.Text = topic.topic_name;
            uCProject.lblTeacherName.Text = _teacherRepository.GetById(topic.teacher_id.Value).teacher_name;
            uCProject.lblGroupSize.Text = topic.max_members.Value.ToString();
            uCProject.lblUncompleteTask.Text = _taskRepository.GetAllUncompletedTask(studentGroup.group_id).Count().ToString();
            uCProject.txtProjectDetail.Text = topic.topic_description;
            ucStudentProject1.flpAllTopics.Controls.Add(uCProject);

        }
        #endregion

        #region ucStudentTask1-Components

        private void ListTasks()
        {
            ucStudentTask1.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            foreach (var groupTask in groupTaskList)
            {

                UCTask uCTask = new UCTask();
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.GroupID = groupID.Value;
                var openDay = groupTask.open_day.Value;
                var deadline = groupTask.due_date.Value;
                uCTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCTask.Clicked += ucTask_Clicked;
                ucStudentTask1.flpGroupTaskView.Controls.Add(uCTask);
            }


            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);
            
            //add data to subtask flow layout panel
            ucStudentTask1.flpAllInvidualTasksView.Controls.Clear();
            foreach (var subTask in subTaskList)
            {

                UCInvidualTask uCInvidualTask = new UCInvidualTask();
                uCInvidualTask.lblName.Text = subTask.subtask_name;
                uCInvidualTask.Id = subTask.subtask_id;
                uCInvidualTask.SubmitDate = subTask.submit_day;
                uCInvidualTask._StudentID = subTask.student_id.Value;
                uCInvidualTask.txtProjectDetail.Text = subTask.subtask_description;
                var openDay = subTask.open_day.Value;
                var deadline = subTask.due_date.Value;
                uCInvidualTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCInvidualTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (uCInvidualTask.SubmitDate != null) { uCInvidualTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_; }
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

            var subTaskList = _subtaskRepository.GetAllByTaskId(taskID);
            //add data to subtask flow layout panel
            ucsTudentSubTasks2.flpAllTasks.Controls.Clear();
            foreach (var subTask in subTaskList)
            {
                UCSubTasks uCSubTask = new UCSubTasks();
                uCSubTask.lblName.Text = subTask.subtask_name;
                uCSubTask.txtProjectDetail.Text = subTask.subtask_description;
                var openDay = subTask.open_day.Value;
                var deadline = subTask.due_date.Value;
                uCSubTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCSubTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                uCSubTask.lblMember.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                if (subTask.submit_day != null) { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                ucsTudentSubTasks2.flpAllTasks.Controls.Add(uCSubTask);
            }

            //add data student member group
            ucsTudentSubTasks2.flpAllMemberView.Controls.Clear();
            var memberList = _studentRepository.GetAllByGroupId(groupID);
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

            if (uCInvidualTask.SubmitDate != null)
            {
                MessageBox.Show("This task has been submitted");
            }
            else
            {
                FStudentTaskPopUp fStudentTaskPopUp = new FStudentTaskPopUp(uCInvidualTask.Id);
                fStudentTaskPopUp.lblSubTaskName.Text = uCInvidualTask.lblName.Text;
                fStudentTaskPopUp.lblStudentname.Text = _studentRepository.GetById(uCInvidualTask._StudentID).student_name;
                fStudentTaskPopUp.lblSubmitDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fStudentTaskPopUp.ShowDialog();
            }
        }


        #endregion

    }
}
