using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.StudentViews.Views;


namespace WFThesisManagementSystem.Views.StudentViews
{
    public partial class UCStudentProject : UserControl
    {
        public UCStudentProject()
        {
            InitializeComponent();
            addUserControl(); 
            this.SizeChanged += UCStudentProject_SizeChanged;

        }

        private void addUserControl()
        {
            for (int i = 0; i < 10; i++)
            {
                UCProject uc = new UCProject();
                flowLayoutPanelContainer.Controls.Add(uc);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
                   
        }
        private void UCStudentProject_SizeChanged(object sender, EventArgs e)
        {
            int marginX = flowLayoutPanelContainer.Width / 5;
            foreach (UserControl uc in flowLayoutPanelContainer.Controls)
            {
                // Gán giá trị Margin cho UserControl
                uc.Margin = new Padding(marginX, 10, marginX, 10);
            }
        }
    }
}
