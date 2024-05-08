using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTask : UserControl
    {

        public event EventHandler DateChanged;

        public UcTeacherAllTask()
        {
            InitializeComponent();
            dtpStartDay.ValueChanged += DtpStartDay_ValueChanged;
            dtpEndDay.ValueChanged += DtpEndDay_ValueChanged;
        }


        private void UcTeacherAllTask_Load(object sender, EventArgs e)
        {

        }

        private void DtpEndDay_ValueChanged(object sender, EventArgs e)
        {
            DateChanged?.Invoke(this, e);
        }

        private void DtpStartDay_ValueChanged(object sender, EventArgs e)
        {
            DateChanged?.Invoke(this, e);
        }

    }
}
