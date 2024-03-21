using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.StudentViews.Views;
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;


namespace WFThesisManagementSystem.Views.StudentViews
{
    public partial class UCStudentProject : UserControl
    {
        private Student student;
        public UCStudentProject(int student_id)
        {
            InitializeComponent();
            student = new Student();
            student.Id = student_id;
            addUserControl(); 
            this.SizeChanged += UCStudentProject_SizeChanged;
        }

        private void addUserControl()
        {
            DBConnect dBConnect = new DBConnect();
            StudentDAO studentDAO = new StudentDAO();
            DataTable dataTable = dBConnect.GetData(studentDAO.Student_LoadTopics(student));
            flowLayoutPanelContainer.Controls.Clear();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                UCProject uCProject = new UCProject();
                Topic topic = new Topic();
                topic.Name = row["topic_name"].ToString();
                topic.Description = row["topic_description"].ToString();
                //topic.Requirement = row["requirement"].ToString();
                //topic.Category = row["category"].ToString();
                //topic.Technology = row["technology"].ToString();
                // singletopic.Button.Click += edit;
                uCProject.SetTopic(topic);
                flowLayoutPanelContainer.Controls.Add(uCProject);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
                   
        }
        private void UCStudentProject_SizeChanged(object sender, EventArgs e)
        {
            int marginX = flowLayoutPanelContainer.Width / 5;
            foreach (UserControl uc in flowLayoutPanelContainer.Controls)
            {
                // Gán giá trị Margin cho UserControl
                uc.Margin = new Padding(marginX, 10, marginX, 10);
            }
        }
    }
}
