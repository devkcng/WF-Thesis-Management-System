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
            panelContainer.Click += UcTeacherSingleGroup_Click;
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
        private string namegroup;
        private string nametopic;
        public int Id {  get; set; }
        public string NameGroup
        {
            set { namegroup = value; lblNameGroup.Text = value; }
        }
        public string NameTopic
        {
            get { return nametopic; }
            set { nametopic = value; lblNameTopic.Text = value; }
        }

        #endregion
    }
}
