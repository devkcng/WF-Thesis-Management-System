using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WFThesisManagementSystem.Forms.TeacherViews.Views;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
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
        
        public string Time
        {
            get { return time; }
            set { time = value; lblTimeAndOrdinalNumber.Text = value; }
        }
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

        private void btnChat_Click(object sender, EventArgs e)
        {
            //DBConnect dBConnect = new DBConnect();
            //DataTable dataTable = dBConnect.LoadData("Tasks");
            FTeacherEditTask fTeacherEditTask = new FTeacherEditTask();
            fTeacherEditTask.Show();
        }
    }
}
