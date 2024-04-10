using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAcceptRegisterSingle : UserControl
    {
        public event EventHandler Clicked;
        public event EventHandler CheckClicked;
        public UcTeacherAcceptRegisterSingle()
        {
            InitializeComponent();
            this.Click += UcTeacherAcceptRegisterSingle_Click;
            this.cbxRegist.Click += Checkregist_Click;
        }

        private void Checkregist_Click(object sender, EventArgs e)
        {
            OnClickCheck(EventArgs.Empty);
        }
        protected virtual void OnClickCheck(EventArgs e)
        {
            CheckClicked?.Invoke(this, e);
        }
        private void UcTeacherAcceptRegisterSingle_Click(object sender, EventArgs e)
        {
            OnClick(EventArgs.Empty);
        }
        protected virtual void OnClick(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
        #region Properties
        private string namestudent;
        private string idstudent;
        private string regist;
        private CheckBox checkregist;
        public  int Id { get; set; }
        public string NameStudent
        {
            get { return namestudent; }
            set { namestudent = value; lblNameStudent.Text = value; }

        }
        [Category("custom props")]
        public string IdStudent
        {
            get { return idstudent; }
            set { idstudent = value; lblIdStudent.Text = value; }
        }
        [Category("custom props")]
        public string Regist
        {
            get { return regist; }
            set { regist = value; lblRegist.Text = value; }
        }
        public CheckBox CheckRegist
        {
            get { return checkregist; }
            set { checkregist = value; cbxRegist = value; }
        }
        #endregion
    }
}
