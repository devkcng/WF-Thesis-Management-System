using System;
using System.Globalization;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleTask : UserControl
    {
        public event EventHandler EditButtonClicked;
        public event EventHandler SubmitButtonClicked;
        public event EventHandler PointButtonClicked;
        public UcTeacherSingleTask()
        {
            InitializeComponent();
            btnEdit.Click += ButtonEdit_Click;
            //btnPoint.Click += Point_Click;
        }

        #region Properties
        private string name;
        private int task_id;
        private string content;
        private DateTime timeOpen;
        private DateTime timeEnd;

        public DateTime TimeOpen
        {
            get { return timeOpen; }
            set { timeOpen = value; dtpFrom.Text = value.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);/*lblTimeAndOrdinalNumber.Text = value;*/ }
        }
        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; dtpTo.Text = value.ToString("dd/M/yyyy", CultureInfo.InvariantCulture); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; lblContentTask.Text = value; }
        }
        public int TaskId
        {
            get { return task_id; }
            set { task_id = value; }
        }
        #endregion

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            OnEditButtonClicked(EventArgs.Empty);
        }
        protected virtual void OnEditButtonClicked(EventArgs e)
        {
            EditButtonClicked?.Invoke(this, e);
        }

        private void cbSubmitTask_CheckedChanged(object sender, EventArgs e)
        {
            OnSubmitButtonClicked(EventArgs.Empty);
        }
        protected virtual void OnSubmitButtonClicked(EventArgs e)
        {
            SubmitButtonClicked?.Invoke(this, e);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            OnPointButtonClicked(EventArgs.Empty);
        }
        protected virtual void OnPointButtonClicked(EventArgs e)
        {
            PointButtonClicked?.Invoke(this, e);
        }
    }
}
