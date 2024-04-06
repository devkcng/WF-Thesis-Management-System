using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.UC;

namespace WFThesisManagementSystem.Forms
{
    public partial class FNotification : Form
    {
        public FNotification()
        {
            InitializeComponent();
        }

        private void tsmiCompose_Click(object sender, EventArgs e)
        {
            FTeacherCreateNotification fTeacherCreateNotification = new FTeacherCreateNotification();
            fTeacherCreateNotification.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
