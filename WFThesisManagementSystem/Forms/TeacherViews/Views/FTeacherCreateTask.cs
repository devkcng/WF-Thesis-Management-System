using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherCreateTask : Form
    {
        public FTeacherCreateTask()
        {
            InitializeComponent();
            ucTeacherCreateTask1.btnClose.Click += Close;
            ucTeacherCreateTask1.btnSave.Click += Save;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Save(object sender, EventArgs e)
        {

        }

    }
}
