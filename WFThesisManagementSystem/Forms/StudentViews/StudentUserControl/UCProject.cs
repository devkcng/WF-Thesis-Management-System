using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCProject : UserControl
    {
        private int _id;
        private int _groupID;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public UCProject()
        {
            InitializeComponent();

        }

    }
}
