using System.ComponentModel;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAcceptRegisterSingle : UserControl
    {
        public UcTeacherAcceptRegisterSingle()
        {
            InitializeComponent();
        }
        #region Properties
        private string namestudent;
        private string idstudent;
        private string regist;
        private CheckBox checkregist;
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
