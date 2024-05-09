using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCSubTasks : UserControl
    {
        public event EventHandler submitTaskBtnClicked;

        public int _id;
        public UCSubTasks()
        {

            InitializeComponent();
            btnSubmit.Click += btnSubmit_Click;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmitOnClicked(EventArgs.Empty);
        }

        protected virtual void btnSubmitOnClicked(EventArgs e)
        {
            submitTaskBtnClicked?.Invoke(this, e);
        }
    }
}
