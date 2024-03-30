using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentWorkLogs : UserControl
    {
        public UCStudentWorkLogs()
        {
            InitializeComponent();
            addUserControl();
            this.SizeChanged += UCStudentWorkLogs_SizeChanged;
        }

        private void UCStudentWorkLogs_SizeChanged(object sender, EventArgs e)
        {
            int marginX = flowLayoutPanelContainer.Width / 5;
            foreach (UserControl uc in flowLayoutPanelContainer.Controls)
            {
                // Gán giá trị Margin cho UserControl
                uc.Margin = new Padding(marginX, 10, marginX, 10);
            }
        }

        private void addUserControl()
        {
            for (int i = 0; i < 10; i++)
            {
                UCWorkLog uc = new UCWorkLog();
                flowLayoutPanelContainer.Controls.Add(uc);
            }
        }
    }

}
