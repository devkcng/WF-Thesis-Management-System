using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Forms.UC;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using System.Collections.Generic;

using UserControl = System.Windows.Forms.UserControl;
using WFThesisManagementSystem.Services;

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
            btnNotification.Click += createNotification;
        }

        private void createNotification(object sender, EventArgs e)
        {   
            if(TopicRegisterReminder())
            {
                return;
            }
            FNotification fNotification = new FNotification(_context);
            fNotification.Show();
        }

        private void CbTaskDate_ValueChanged(object sender, EventArgs e)
        {
            if(TopicRegisterReminder())
            {
                return;
            }
            UCDashBoard uCDashBoard = sender as UCDashBoard;
            uCDashBoard.flpGroupTask.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);  
            var taskListFiltered = groupTaskList;
            if (uCDashBoard.cbTaskDate.SelectedItem == "This week")
            {
                taskListFiltered=filterHelper.FilterByWeek();
            }
            else if (uCDashBoard.cbTaskDate.SelectedItem == "This month")
            {
                taskListFiltered=filterHelper.FilterByMonth();
            }
            taskListFiltered = filterHelper.GetSortedTasks();
            LoadTask(taskListFiltered, uCDashBoard.flpGroupTask, new Size(465, 140), groupID.Value);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(TopicRegisterReminder())
            {
                return;
            }
            UCStudentTask uCStudentTask = sender as UCStudentTask;
            uCStudentTask.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            var taskListFiltered = filterHelper.FilterByDay(uCStudentTask.dtpStartDay.Value, uCStudentTask.dtpEndDay.Value);
            taskListFiltered = filterHelper.GetSortedTasks();
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
                uCStudentTask.flpGroupTaskView.Controls.Add(uCTask);
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if(TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCDashBoard ucDashBoard = new UCDashBoard();
            ucDashBoard.Dock = DockStyle.Fill;
            ucDashBoard.sdpPerformanceChart.Visible = false;
            UCDashBoard_Load(ucDashBoard);
            ucDashBoard.cbTaskDateChange += CbTaskDate_ValueChanged;
            panelContainer.Controls.Add(ucDashBoard);
        }
        private void task_Click(object sender, EventArgs e)
        {   
            if(TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCStudentTask uCStudentTask = new UCStudentTask();
            uCStudentTask.Dock = DockStyle.Fill;
            uCStudentTask.dtpStartDay.Value = _taskRepository.GetFirstTask().open_day.Value;
            uCStudentTask.dtpEndDay.Value = DateTime.Now; 
            UCStudentTask_Load(uCStudentTask);
            uCStudentTask.DateChanged += DateTimePicker_ValueChanged;
            panelContainer.Controls.Add(uCStudentTask);

        }

        private void worklogs_Click(object sender, EventArgs e)
        {   
            if(TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCStudentWorkLogs uCStudentWorkLogs = new UCStudentWorkLogs();
            uCStudentWorkLogs.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uCStudentWorkLogs);
        }



        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Close();
        }

        private void performance_Click(object sender, EventArgs e)
        {
            if(TopicRegisterReminder())
            {
                return;
            }
        }

        private void UCStudentTask_Load(UCStudentTask uCStudentTask)
        {
            ListTasks(uCStudentTask);
        }
        private void UCDashBoard_Load(UCDashBoard ucDashBoard)
        {
            ListDashboardComponent(ucDashBoard);
        }

        #region ucDashBoard1-Components
        private void ListDashboardComponent(UCDashBoard ucDashBoard)
        {
            ucDashBoard.sdpCalendar.Visible = false;
            ucDashBoard.sdpTask.Visible = false;
            ucDashBoard.sdpTaskChart.Visible = false;
            ucDashBoard.sdpPerformanceChart.Visible = false;

            //load calendar
            ucDashBoard.ucCalendar1.previousPtbClicked += PreviousPtb_Clicked;
            ucDashBoard.ucCalendar1.nextPtbClicked += NextPtb_Clicked;
            LoadCalendar(ucDashBoard);

            //load task 
            ucDashBoard.flpGroupTask.Hide();
            ucDashBoard.flpGroupTask.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            groupTaskList = filterHelper.GetSortedTasks();
            LoadTask(groupTaskList, ucDashBoard.flpGroupTask, new Size(465, 140), groupID.Value);


            //load chart
            var unCompleteTask = _taskRepository.GetAllUncompletedTask(groupID.Value);
            ucDashBoard.groupTaskChart.Series["s1"].Points.AddXY("Uncomplete Task", unCompleteTask.Count().ToString());
            ucDashBoard.groupTaskChart.Series["s1"].Points.AddXY("Task", (groupTaskList.Count() - unCompleteTask.Count()).ToString());


            ucDashBoard.sdpCalendar.Visible = true;
            ucDashBoard.sdpTask.Visible = true;
            ucDashBoard.sdpTaskChart.Visible = true;
            ucDashBoard.sdpPerformanceChart.Visible = true;
        }

        private void LoadCalendar(UCDashBoard ucDashBoard)
        {
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var submitDates = groupTaskList.Select(groupTask => groupTask.due_date);


            ucDashBoard.ucCalendar1.flpDayContainer.Visible = false;
            ucDashBoard.ucCalendar1.flpDayContainer.Controls.Clear();

            DateTime startOfTheMonth = new DateTime(ucDashBoard.ucCalendar1.year, ucDashBoard.ucCalendar1.month, 1);
            int days = DateTime.DaysInMonth(ucDashBoard.ucCalendar1.year, ucDashBoard.ucCalendar1.month);


            ucDashBoard.ucCalendar1.lblMY.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(ucDashBoard.ucCalendar1.month) + " " + ucDashBoard.ucCalendar1.year;
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 2; i < dayoftheweek; i++)
            {
                UCBlank uCBlank = new UCBlank();
                ucDashBoard.ucCalendar1.flpDayContainer.Controls.Add(uCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDay uCDay = new UCDay();
                uCDay.days(i);

                DateTime currentDate = new DateTime(ucDashBoard.ucCalendar1.year, ucDashBoard.ucCalendar1.month, i);
                if (submitDates.Contains(currentDate))
                {
                    uCDay.ptb1.FillColor = Color.Red;
                    uCDay.ptb1.Visible = true;
                }
                ucDashBoard.ucCalendar1.flpDayContainer.Controls.Add(uCDay);
            }
            ucDashBoard.ucCalendar1.flpDayContainer.Visible = true;
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
                flp.Controls.Add(uCTask);
            }

            flp.Visible = true;
        }


        #endregion

        #region ucDashBoard1-Events
        private void PreviousPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            UCDashBoard ucDashBoard = (UCDashBoard)uCCalendar.Parent.Parent.Parent; // Tìm UCDashBoard từ UCCalendar

            if (uCCalendar.month == 1)
            {
                uCCalendar.year--;
                uCCalendar.month = 12;
            }
            else
            {
                uCCalendar.month--;
            }
            LoadCalendar(ucDashBoard);
        }
        private void NextPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            UCDashBoard ucDashBoard = (UCDashBoard)uCCalendar.Parent.Parent.Parent; // Tìm UCDashBoard từ UCCalendar
            if (uCCalendar.month == 12)
            {
                uCCalendar.year++;
                uCCalendar.month = 1;
            }
            else
            {
                uCCalendar.month++;
            }
            LoadCalendar(ucDashBoard);
        }
        #endregion


        #region ucStudentTask1-Components

        private void ListTasks(UCStudentTask uCStudentTask)
        {
            uCStudentTask.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            groupTaskList = filterHelper.GetSortedTasks();
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
                uCStudentTask.flpGroupTaskView.Controls.Add(uCTask);
                
            }



            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);

            //add data to subtask flow layout panel
            uCStudentTask.flpAllInvidualTasksView.Hide();
            uCStudentTask.flpAllInvidualTasksView.Controls.Clear();
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
                uCStudentTask.flpAllInvidualTasksView.Controls.Add(uCInvidualTask);
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

            uCTask.Parent.Parent.Hide();

            UCSTudentSubTasks ucsTudentSubTasks2 = new UCSTudentSubTasks();
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
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ucsTudentSubTasks2);
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

        private void ucStudentProject1_Load(object sender, EventArgs e)
        {
            
        }

        private void ucStudentTask1_Load(object sender, EventArgs e)
        {
            
        }

        private bool TopicRegisterReminder()
        {   
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var registrationService = new RegistrationService(student,_context);
            if (registrationService.AlreadyRegistered())
            {
                return false;
            }

            string message = "You have not registered topic. Do you want to register one?";
            string title = "Topic Reminder";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                this.Close();
                FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
                fStudentRegisterTopic.Show();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
