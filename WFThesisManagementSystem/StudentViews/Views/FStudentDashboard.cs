﻿using System;
using System.Drawing;
using System.Web.UI;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Views.StudentViews;
using UserControl = System.Windows.Forms.UserControl;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {
        private Student student;
        public FStudentDashboard(string student_id)
        {
            InitializeComponent();
            student = new Student();
            student.Id = int.Parse(student_id);
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
            UCStudentProject uc = new UCStudentProject(student.Id);
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

        private void performance_Click(object sender, EventArgs e)
        {
            
        }



        }
}
