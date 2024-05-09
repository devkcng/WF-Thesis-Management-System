using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleMark : UserControl
    {
        public event EventHandler EditButton;
        public UcTeacherSingleMark()
        {
            InitializeComponent();
            //btnEdit.Click += EditButton_Click;
        }
        #region Properties
        private string nameTask;
        private string descriptionTask;
        private string nameStudent;
        private double mark;
        //public string NameTask
        //{
        //    set { nameTask = value; lblPoint.Text = value; }
        //    get { return nameTask; }
        //}
        //public string DescriptionTask
        //{
        //    set { descriptionTask = value; lblReview.Text = value; }
        //}
        //public string NameStudent
        //{
        //    set { nameStudent = value; lblPoint.Text = value; }
        //}
        //public double Mark
        //{
        //    set { mark = value; }
        //}
        #endregion
        #region EventEditButton
        private void EditButton_Click(object sender, EventArgs e)
        {
            OnEditButtonClicked(EventArgs.Empty);
        }
        protected virtual void OnEditButtonClicked(EventArgs e)
        {
            EditButton?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
