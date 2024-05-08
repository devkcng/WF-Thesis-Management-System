using System;
using System.Windows.Forms;

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
