using System;
using System.Drawing;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCProject : UserControl
    {
        public UCProject()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.SizeChanged += UCProject_SizeChanged;

        }
        private void UCProject_SizeChanged(object sender, EventArgs e)
        {
            txtProjectDetail.Width= this.Width;
            ptbLine.Width = this.Width;
            panelContainerlblComplete.Location = new Point((this.Width - 2*panelContainerlblComplete.Width), panelContainerlblComplete.Location.Y);
            ptbIssue.Location = new Point((panelContainerlblComplete.Location.X), ptbIssue.Location.Y);
            lblIssue.Location = new Point((ptbIssue.Location.X + ptbIssue.Width), lblIssue.Location.Y);
        }

        public void SetTopic(Topic topic) {
            lblProjectName.Text = topic.topic_name;
            txtProjectDetail.Text= topic.topic_description;
        }
    }
}
