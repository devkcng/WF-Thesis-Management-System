using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCDashBoard : UserControl
    {
        //cbDate
        public event EventHandler cbTaskDateChange;

        public UCDashBoard()
        {
            InitializeComponent();
            cbTaskDate.SelectedValueChanged += cbDate_ValueChanged;
        }

        private void cbDate_ValueChanged(object sender, EventArgs e)
        {
            cbTaskDateChange?.Invoke(this, e);
        }
    }
}
