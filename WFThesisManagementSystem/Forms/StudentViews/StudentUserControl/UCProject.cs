using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using WFThesisManagementSystem.Models;

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
