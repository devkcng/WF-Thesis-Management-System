using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentInformation : UserControl
    {
        public event EventHandler Clicked;
        public int _id;
        public int _taskID;

        public UCStudentInformation()
        {
            InitializeComponent();
            panelContainer.Click += UCStudentInformation_CLick;
        }
        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
        public void UCStudentInformation_CLick(object sender, EventArgs e)
        {
            OnClicked(EventArgs.Empty);
        }

    }
}
