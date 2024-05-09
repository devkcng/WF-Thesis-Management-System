using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllMark : UserControl
    {
        public event EventHandler cbxStudentbutton;
        public UcTeacherAllMark()
        {
            InitializeComponent();
            cbxStudent.SelectedValueChanged += cbxStudent_SelectedIndexChanged;
        }

        private void cbxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxStudentbutton?.Invoke(this, EventArgs.Empty);
        }
    }
}
