using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleGroup : UserControl
    {
        public UcTeacherSingleGroup()
        {
            InitializeComponent();
        }
        #region Properties
        private string name;
        private int id;
        public string Name
        {
            set { name = value; lblNameGroup.Text = value; }
        }
        public int Id
        { set { id = value;lblIdGroup.Text = Convert.ToString(value); } }
        #endregion

        private void lblNameGroup_Click(object sender, EventArgs e)
        {
           
               
        }
    }
}
