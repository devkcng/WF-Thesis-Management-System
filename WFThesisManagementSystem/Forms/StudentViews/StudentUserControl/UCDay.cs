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
    public partial class UCDay : UserControl
    {
        public UCDay()
        {
            InitializeComponent();
        }
        public void days (int numday)
        {
            lblDay.Text = numday.ToString();
        }
    }
}
