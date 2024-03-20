using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.TeacherViews.Views;

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleTopic : UserControl
    {
        public UcTeacherSingleTopic()
        {
            InitializeComponent();
        }

        private void UcTeacherSingleTopic_Load(object sender, EventArgs e)
        {

        }
        #region Properties
        private string name;
        private string description;
        private Guna2Button button;
        [Category("custom props")]
        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }

        }
        [Category("custom props")]
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = value; }
        }
        [Category("custom props")]
        public Guna2Button Button
        {
            get { return button; }
            set { button = value; btnEdit = value; }
        }
        #endregion
        //private void editTopic(object sender, EventArgs e)
        //{
            
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FTeacherEditTopic fTeacherEditTopic = new FTeacherEditTopic();
            fTeacherEditTopic.Show();
        }
    }
}
