using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCDay : UserControl
    {
        public UCDay()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lblDay.Text = numday.ToString();
        }
    }
}
