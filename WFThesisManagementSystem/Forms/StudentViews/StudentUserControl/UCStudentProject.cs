using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentProject : UserControl
    {
        public event EventHandler _cbDateChanged;

        public UCStudentProject()
        {
            InitializeComponent();
            CbTaskDate.SelectedValueChanged += CbTaskDate_SelectedIndexChanged;
        }

        private void CbTaskDate_SelectedIndexChanged(object sender, EventArgs e)
        {

            _cbDateChanged?.Invoke(this, e);

        }
    }
}
