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
    public partial class UCStudentProject : UserControl
    {
        public UCStudentProject()
        {
            InitializeComponent();
            addUserControl();
        }
        private void addUserControl()
        {
            for (int i = 0; i < 10; i++)
            {
                UCProject uc = new UCProject();
                flowLayoutPanelContainer.Controls.Add(uc);
            }
        }
    }
}
