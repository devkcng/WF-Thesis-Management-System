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
    public partial class UCInvidualTask : UserControl
    {
        public event EventHandler Clicked;
        public int _id;
        public UCInvidualTask()
        {
            InitializeComponent();
            btnSubmit.Click += UCInvidualTask_CLick;
        }
        public void UCInvidualTask_CLick(object sender, EventArgs e)
        {
            OnClicked(EventArgs.Empty);
        }

        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
    }
}
