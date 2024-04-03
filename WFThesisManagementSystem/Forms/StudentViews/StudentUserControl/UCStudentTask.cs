using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentTask : UserControl
    {
        public UCStudentTask()
        {
            InitializeComponent();
            //addUserControl();
            //this.SizeChanged += UCStudentTask_SizeChanged;

        }

        //    private void UCStudentTask_SizeChanged(object sender, EventArgs e)
        //    {
        //        int marginX = flowLayoutPanelContainer.Width / 5;
        //        foreach (UserControl uc in flowLayoutPanelContainer.Controls)
        //        {
        //            // Gán giá trị Margin cho UserControl
        //            uc.Margin = new Padding(marginX, 10, marginX, 10);
        //        }
        //    }

        //    private void addUserControl()
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            UCTask uc = new UCTask();
        //            flowLayoutPanelContainer.Controls.Add(uc);
        //        }
        //    }
        //}

    }
}
