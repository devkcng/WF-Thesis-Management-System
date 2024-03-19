using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Views.StudentViews
{
    public partial class UCProject : UserControl
    {
        public UCProject()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left /*| AnchorStyles.Bottom*/ /*| AnchorStyles.Right*/; // Gắn UserControl ở cả bốn góc
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
    }
}
