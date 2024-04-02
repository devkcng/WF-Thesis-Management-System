using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCStudentSubTask : UserControl
    {
        public UCStudentSubTask()
        {
            InitializeComponent();
            addUserControl();
        }

        private void addUserControl()
        {
            for (int i = 0; i < 10; i++)
            {
                UCSubTask uc = new UCSubTask();
                flpAllSubTasksView.Controls.Add(uc);

                UCStudentInfo ucstudentinfo = new UCStudentInfo();
                flpMemberGroupView.Controls.Add(ucstudentinfo);
            }
        }
    }
}
