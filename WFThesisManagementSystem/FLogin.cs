using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WFThesisManagementSystem.StudentViews.Views;
using WFThesisManagementSystem.Views.StudentViews;

namespace WFThesisManagementSystem
{
    public partial class FLogin : KryptonForm
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            KryptonForm kform = new FStudentDashboard();
            kform.Show();
        }
    }
}
