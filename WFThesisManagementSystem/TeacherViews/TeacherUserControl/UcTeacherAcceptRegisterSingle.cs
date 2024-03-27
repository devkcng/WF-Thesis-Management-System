using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
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
        #endregion
    }
}
