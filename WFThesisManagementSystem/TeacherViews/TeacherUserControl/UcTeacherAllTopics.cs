﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTopics : UserControl
    {
        public UcTeacherAllTopics()
        {
            InitializeComponent();
            UcTeacheCreateTopic uc = new UcTeacheCreateTopic();
            uc.Hide();
        }

        private void ucSingletopic1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControl uc = new UcTeacheCreateTopic();
            uc.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void ucTeacherSingleTopic1_Load(object sender, EventArgs e)
        {

        }

        private void UcTeacherAllTopics_Load(object sender, EventArgs e)
        {
            TopicCreated();
        }

        private void TopicCreated()
        {
        }
    }
}
