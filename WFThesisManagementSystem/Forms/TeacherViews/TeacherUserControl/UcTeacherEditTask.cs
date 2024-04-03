using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherEditTask : UserControl
    {   
        //create manual event handler for these buttons: Delete, Update, Close
        public event EventHandler DeleteButtonClicked;
        public event EventHandler UpdateButtonClicked;
        public event EventHandler CloseButtonClicked;
        public UcTeacherEditTask()
        {
            InitializeComponent();
            btnClose.Click += CloseButton_Click;
            btnUpdate.Click += UpdateButton_Click;
            btnDelete.Click += DeleteButton_Click;
        
        }
        
        public void CloseButton_Click(object sender, EventArgs e)
        {
            btnCloseOnClicked(EventArgs.Empty);
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            btnUpdateOnClicked(EventArgs.Empty);
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            btnDeleteOnClicked(EventArgs.Empty);
        }


        protected virtual void btnUpdateOnClicked(EventArgs e)
        {
            UpdateButtonClicked?.Invoke(this, e);
        }


        protected virtual void btnCloseOnClicked(EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, e);
        }



        protected virtual void btnDeleteOnClicked(EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, e);
        }

        //This function to get all information from the form
        public string TaskName
        {
            get { return txtTaskName.Text; }
            set { txtTaskName.Text = value; }
        }

        public string TaskDescription
        {
            get { return txtTaskDescription.Text; }
            set { txtTaskDescription.Text = value; }
        }

        public DateTime DueDate
        {
            get { return dtpDueDate.Value.Date; }
            set { dtpDueDate.Value = value.Date; }
        }

    }
}
