using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTask : UserControl
    {
        StudentGroupRepository _studentGroupRepository;
        TaskRepository _taskRepository;

        public UcTeacherAllTask()
        {
            InitializeComponent();
            var _context = new ThesisManagementContext();
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            flpAllGroupView.Click += ShowTask;
        }
        private void ListGroup()
        {
            flpAllGroupView.Controls.Clear();
            var TableStudentGroups = _studentGroupRepository.GetAll();
            foreach ( var StudentGroup in TableStudentGroups )
            {
                UcTeacherSingleGroup ucTeacherSingleGroup = new UcTeacherSingleGroup();
                ucTeacherSingleGroup.Name = StudentGroup.group_name;
                ucTeacherSingleGroup.Id = StudentGroup.group_id;
                flpAllGroupView.Controls.Add(ucTeacherSingleGroup);
            }    

        }
        private void ShowTask(object sender, EventArgs e)
        {
            for(int i = 0; i<flpAllGroupView.Controls.Count;i++)
            {
                foreach (Control c in flpAllGroupView.Controls[i].Controls)
                {
                    if (c is Label && c.Name == "lblIdGroup")
                    {
                        c.Click += ListTask;
                    }
                    //if(c is )
                        
                }    
            }    
        }
        private void ListTask(object sender, EventArgs e)
        {
            UcTeacherSingleTask[] tasks = new UcTeacherSingleTask[20];
            flpAllTasks.Controls.Clear();
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new UcTeacherSingleTask();
                tasks[i].NameTeacher = "Mai Đức Kiên";
                tasks[i].Name = "Làm Wed";
                tasks[i].Time = "Thời gian";
                //topics[i].Name = "Kiến thức chuyên ngành";
                //topics[i].Description = "Khó";
                //topics[i].Button.Click += editTopic;
                flpAllTasks.Controls.Add(tasks[i]);
            }
        }
        

        private void UcTeacherAllTask_Load(object sender, EventArgs e)
        {
            ListGroup();
        }
    }
}
