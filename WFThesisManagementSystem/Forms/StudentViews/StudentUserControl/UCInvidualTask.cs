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
        private string _name;
        private int _id;
        private int _groupID;
        private int _studentID;
        DateTime? _submitDate;
        public string Name
        {
            set { _name = value; lblName.Text = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int _StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        public DateTime? SubmitDate
        {
            get { return _submitDate; }
            set { _submitDate = value; }
        }
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
