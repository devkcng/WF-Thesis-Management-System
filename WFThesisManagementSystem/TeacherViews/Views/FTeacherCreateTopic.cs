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
    public partial class FTeacherCreateTopic : Form
    {
        public FTeacherCreateTopic()
        {
            InitializeComponent();
            ucTeacherCreateTopic1.btnSave.Click += Save;
            ucTeacherCreateTopic1.btnClear.Click += Clear;
        }
        private void Save(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Clear(object sender, EventArgs e)
        {
            ucTeacherCreateTopic1.txtTopicRequirement.Clear();
            ucTeacherCreateTopic1.txtTopicdescription.Clear();
            ucTeacherCreateTopic1.txtTopicname.Clear();

        }
    }
}
