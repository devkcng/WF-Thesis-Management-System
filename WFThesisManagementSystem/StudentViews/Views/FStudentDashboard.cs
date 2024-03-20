using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Views.StudentViews;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {

        //private Rectangle panelOriginalRectangle;
        //private Rectangle originalFormSize;
        public FStudentDashboard()
        {
            InitializeComponent();
            //    originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            //    panelOriginalRectangle = new Rectangle(panelContainer.Location.X, panelContainer.Location.Y, panelContainer.Size.Width, panelContainer.Size.Height);
            //}
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCStudentProject uc = new UCStudentProject();
            addUserControl(uc);
        }

        private void task_Click(object sender, EventArgs e)
        {
            UCStudentTask uc = new UCStudentTask();
            addUserControl(uc);
        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            UCStudentWorkLogs uc = new UCStudentWorkLogs();
            addUserControl(uc);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UcTeacherInfor uc= new UcTeacherInfor();
            addUserControl(uc);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void resizeControl(Rectangle r, Control c)
        //{
        //    float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
        //    float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);
        //    int newX = (int)(r.Width * xRatio);
        //    int newY = (int)(r.Height * yRatio);
        //    //int newWidth = (int)(r.Width * xRatio);
        //    //int newHeight = (int)(r.Height * yRatio);
        //    int newWidth = (int)(c.Width * xRatio);
        //    int newHeight = (int)(c.Height * yRatio);
        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}
        //private void FStudentDashboard_Resize(object sender, EventArgs e)
        //{
        //    resizeControl(panelOriginalRectangle, panelContainer);

        //}

    }
}
