﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FShowTopic : Form
    {
        private Topic _topic;
        StudentRepository _studentRepository;
        StudentGroupRepository _studentGroupRepository;
        RegisterQueueRepository _registerQueue;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        private ThesisManagementContext _context;
        public FShowTopic(Topic topic, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(600, 500);

            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            this._topic = topic;
        }

        private void FRegisterTopic_Load(object sender, EventArgs e)
        {
            //Topic information load
            ucTopicDetail1.lblTopicName.Text = _topic.topic_name;
            ucTopicDetail1.txtDescription.Text = _topic.topic_description;
            ucTopicDetail1.txtTechnology.Text = _topic.topic_technology;
            ucTopicDetail1.txtRequirement.Text = _topic.topic_requirement;
            ucTopicDetail1.txtCategory.Text = _topic.topic_category;
            ucTopicDetail1.lblMaxMembers.Text = _topic.max_members.ToString();
            ucTopicDetail1.txtTeacherName.Text = _topic.Teacher.teacher_name;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            FTopicRegister fTopicRegister = new FTopicRegister(_topic, _context);
            fTopicRegister.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
            fStudentRegisterTopic.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the reason for closing is the user clicking the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                    return;
                }
                Application.Exit();
            }
        }
    }
}
