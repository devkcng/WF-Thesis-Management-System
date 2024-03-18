﻿using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Views.StudentViews;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {
        public FStudentDashboard()
        {
            InitializeComponent();
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
            UcInfor uc= new UcInfor();
            addUserControl(uc);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
