using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCSTudentSubTasks : UserControl
    {
        public event EventHandler previousPtbClicked;
        public event EventHandler<int> AssignTaskBtnClicked;
        public int _taskID;
        public UCSTudentSubTasks()
        {
            InitializeComponent();
            this.btnPrevious.Click += btnPrevious_Click;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            OnPreviousPtbClicked(EventArgs.Empty);
        }
        protected virtual void OnPreviousPtbClicked(EventArgs e)
        {
            previousPtbClicked?.Invoke(this, e);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
                if (AssignTaskBtnClicked != null)
                {
                    AssignTaskBtnClicked(this, _taskID);
                }
        }
    }
}
