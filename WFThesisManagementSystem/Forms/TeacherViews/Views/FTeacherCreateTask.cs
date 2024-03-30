using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherCreateTask : Form
    {
        public FTeacherCreateTask()
        {
            InitializeComponent();
            ucTeacherCreateTask1.btnClose.Click += Close;
            ucTeacherCreateTask1.btnSave.Click += Save;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Save(object sender, EventArgs e)
        {

        }

    }
}
