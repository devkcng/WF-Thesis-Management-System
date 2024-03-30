using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.StudentViews.StudentUserControl;

namespace WFThesisManagementSystem.Views.StudentViews
{
    public partial class UCStudentTask : UserControl
    {
        public UCStudentTask()
        {
            InitializeComponent();
            addUserControl();
            this.SizeChanged += UCStudentTask_SizeChanged;

        }

        private void UCStudentTask_SizeChanged(object sender, EventArgs e)
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
                UCTask uc = new UCTask();
                flowLayoutPanelContainer.Controls.Add(uc);
            }
        }
    }


}
