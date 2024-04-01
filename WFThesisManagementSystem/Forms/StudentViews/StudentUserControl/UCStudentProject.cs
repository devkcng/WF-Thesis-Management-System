using System;
using System.Data;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentProject : UserControl
    {
        private Student student;
        public UCStudentProject(int student_id)
        {
            InitializeComponent();
            student = new Student();
            student.student_id = student_id;
            addUserControl(); 
            this.SizeChanged += UCStudentProject_SizeChanged;
        }

        private void addUserControl()
        {
            
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
