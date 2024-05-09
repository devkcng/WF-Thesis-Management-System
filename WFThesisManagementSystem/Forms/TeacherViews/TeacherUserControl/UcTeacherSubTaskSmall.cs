using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSubTaskSmall : UserControl
    {
        public event EventHandler ClickLink;
        public UcTeacherSubTaskSmall()
        {
            InitializeComponent();
            lblLinkDocument.Click += Clicklink_Click;
        }
        private void Clicklink_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }
        protected virtual void OnButtonClicked(EventArgs e)
        {
            ClickLink?.Invoke(this, EventArgs.Empty);
        }
    }
}
