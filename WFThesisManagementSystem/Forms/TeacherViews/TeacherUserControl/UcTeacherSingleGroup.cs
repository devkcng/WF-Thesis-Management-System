using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleGroup : UserControl
    {
        public event EventHandler Clicked;
        public UcTeacherSingleGroup()
        {
            InitializeComponent();
            this.Click += UcTeacherSingleGroup_Click;
        }
        private void UcTeacherSingleGroup_Click(object sender, EventArgs e)
        {
            OnClicked(EventArgs.Empty);
        }

        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
        #region Properties
        private string name;
        private int id;
        public string Name
        {
            set { name = value; lblNameGroup.Text = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; lblIdGroup.Text = Convert.ToString(value); }
        }

        #endregion
    }
}
