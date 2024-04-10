using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using System.Collections.Generic;

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
            ucDashBoard1.Hide();

            ucStudentTask1.DateChanged += DateTimePicker_ValueChanged;
            ucDashBoard1.cbTaskDateChange += CbTaskDate_ValueChanged;
        }
        private void CbTaskDate_ValueChanged(object sender, EventArgs e)
        {
            ucDashBoard1.flpGroupTask.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value).ToList();
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);

            DateTime startDay = DateTime.Today;
            DateTime endDay = DateTime.Today;

            if (ucDashBoard1.cbTaskDate.SelectedItem == "This week")
            {
                DateTime today = DateTime.Today;
                int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                startDay = today.AddDays(-1 * diff).Date;
                endDay = startDay.AddDays(6);
            }
            else if (ucDashBoard1.cbTaskDate.SelectedItem == "This month")
            {
                DateTime today = DateTime.Today;
                startDay = new DateTime(today.Year, today.Month, 1); // Ngày đầu tiên của tháng
                endDay = startDay.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng
            }

            var taskListFiltered = filterHelper.FilterByDay(startDay, endDay);
            LoadTask(taskListFiltered, ucDashBoard1.flpGroupTask, new Size(450, 140), groupID.Value);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ucStudentTask1.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value).ToList();
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            var taskListFiltered = filterHelper.FilterByDay(ucStudentTask1.dtpStartDay.Value, ucStudentTask1.dtpEndDay.Value);
            foreach (var groupTask in taskListFiltered)
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
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Hide();
            //ucStudentProject1.Show();
            ucDashBoard1.Show();

        }
        private void task_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Show();
            ucStudentTask1.flpAllInvidualTasksView.Visible = false;
            ucStudentWorkLogs1.Hide();
            ucStudentProject1.Hide();
            ucDashBoard1.Hide();

        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks2.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Show();
            ucStudentProject1.Hide();
            ucDashBoard1.Hide();

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
            //ListDashboardComponent();
        }
        private void ucDashBoard1_Load(object sender, EventArgs e)
        {
            ListDashboardComponent();
        }

        #region ucDashBoard1-Components
        private void ListDashboardComponent()
        {
            ucDashBoard1.sdpCalendar.Visible = false;
            ucDashBoard1.sdpTask.Visible = false;
            ucDashBoard1.sdpTaskChart.Visible = false;
            ucDashBoard1.sdpPerformanceChart.Visible = false;

            //load calendar
            ucDashBoard1.ucCalendar1.previousPtbClicked += PreviousPtb_Clicked;
            ucDashBoard1.ucCalendar1.nextPtbClicked += NextPtb_Clicked;
            LoadCalendar();

            //load task 
            ucDashBoard1.flpGroupTask.Hide();
            ucDashBoard1.flpGroupTask.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            LoadTask(groupTaskList.ToList(), ucDashBoard1.flpGroupTask, new Size(450, 140), groupID.Value);


            //load chart
            var unCompleteTask = _taskRepository.GetAllUncompletedTask(groupID.Value);
            ucDashBoard1.groupTaskChart.Series["s1"].Points.AddXY("Uncomplete Task", unCompleteTask.Count().ToString());
            ucDashBoard1.groupTaskChart.Series["s1"].Points.AddXY("Task", (groupTaskList.Count() - unCompleteTask.Count()).ToString());


            ucDashBoard1.sdpCalendar.Visible = true;
            ucDashBoard1.sdpTask.Visible = true;
            ucDashBoard1.sdpTaskChart.Visible = true;
            ucDashBoard1.sdpPerformanceChart.Visible = true;
        }

        private void LoadCalendar()
        {
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var submitDates = groupTaskList.Select(groupTask => groupTask.due_date).ToList();


            ucDashBoard1.ucCalendar1.flpDayContainer.Visible = false;
            ucDashBoard1.ucCalendar1.flpDayContainer.Controls.Clear();

            DateTime startOfTheMonth = new DateTime(ucDashBoard1.ucCalendar1.year, ucDashBoard1.ucCalendar1.month, 1);
            int days = DateTime.DaysInMonth(ucDashBoard1.ucCalendar1.year, ucDashBoard1.ucCalendar1.month);


            ucDashBoard1.ucCalendar1.lblMY.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(ucDashBoard1.ucCalendar1.month) + " " + ucDashBoard1.ucCalendar1.year;
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 2; i < dayoftheweek; i++)
            {
                UCBlank uCBlank = new UCBlank();
                ucDashBoard1.ucCalendar1.flpDayContainer.Controls.Add(uCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDay uCDay = new UCDay();
                uCDay.days(i);

                DateTime currentDate = new DateTime(ucDashBoard1.ucCalendar1.year, ucDashBoard1.ucCalendar1.month, i);
                if (submitDates.Contains(currentDate))
                {
                    uCDay.ptb1.FillColor = Color.Red;
                    uCDay.ptb1.Visible = true;
                }
                ucDashBoard1.ucCalendar1.flpDayContainer.Controls.Add(uCDay);
            }
            ucDashBoard1.ucCalendar1.flpDayContainer.Visible = true;
        }
        private void LoadTask(List<Task> Tasks, FlowLayoutPanel flp, Size size, int groupID)
        {
            flp.Visible = false;
            flp.Controls.Clear();
            foreach (var groupTask in Tasks)
            {

                UCTask uCTask = new UCTask();
                uCTask.Size = size;
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.GroupID = groupID;
                var openDay = groupTask.open_day.Value;
                var deadline = groupTask.due_date.Value;
                uCTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCTask.btnEdit.Visible = false;
                flp.Controls.Add(uCTask);
            }
            flp.Visible = true;
        }


        #endregion

        #region ucDashBoard1-Events
        private void PreviousPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            if (uCCalendar.month == 1)
            {
                uCCalendar.year--; 
                uCCalendar.month = 12; 
            }
            else
            {
                uCCalendar.month--; 
            }
            LoadCalendar();
        }
        private void NextPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            if (uCCalendar.month == 12)
            {
                uCCalendar.year++;
                uCCalendar.month = 1; 
            }
            else
            {
                uCCalendar.month++; 
            }
            LoadCalendar();
        }
        #endregion

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
                uCTask.Size = new Size(490, 150);
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
