using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTask : UserControl
    {
        public UcTeacherAllTask()
        {
            InitializeComponent();
        }
        private void ListTasks()
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
            ListTasks();
        }
    }
}
