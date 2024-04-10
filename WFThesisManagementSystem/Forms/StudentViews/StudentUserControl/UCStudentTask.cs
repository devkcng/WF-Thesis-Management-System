using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentTask : UserControl
    {
        public event EventHandler DateChanged;

        public UCStudentTask()
        {
            InitializeComponent();
            dtpStartDay.ValueChanged += DtpStartDay_ValueChanged;
            dtpEndDay.ValueChanged += DtpEndDay_ValueChanged;

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
