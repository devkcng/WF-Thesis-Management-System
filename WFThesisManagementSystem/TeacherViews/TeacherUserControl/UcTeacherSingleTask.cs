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

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleTask : UserControl
    {
        public UcTeacherSingleTask()
        {
            InitializeComponent();
        }
        #region Properties
        private string name;
        private string nameTeacher;
        private string time;
        private Guna2Button chat;
        private PictureBox image;

        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }
        }
        public string NameTeacher
        {
            get { return nameTeacher; }
            set { nameTeacher = value; lblNameTeacher.Text = value; }
        }
        public Guna2Button Chat
        {
            get { return chat; }
            set { chat = value;btnChat = value; }
            
        }
        public PictureBox Image
        {
            get { return image; }
            set { image = value; ptbImage = value; }
        }
        #endregion
    }
}
