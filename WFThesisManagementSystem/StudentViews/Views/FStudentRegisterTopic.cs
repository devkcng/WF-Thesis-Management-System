﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Utilities.SearchEngine;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FStudentRegisterTopic : Form
    {
        DBConnect dBConnect = new DBConnect();
        private int studentID;
        public FStudentRegisterTopic(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            FStudentRegisterTopic_Load();
        }
        private void dgvTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void FStudentRegisterTopic_Load()
        {
            try
            {
                TopicDAO topicDAO = new TopicDAO();
                topicDAO.LoadTopic("SELECT *FROM Topics", dgvTopics);

                DBConnect dBConnect = new DBConnect();
                cbTeacherList.DataSource = dBConnect.GetColumnData("teacher_name", "Teacher");
                cbTeacherList.DisplayMember = "teacher_name";
                cbTeacherList.ValueMember = "teacher_name";

                cbTopicTechnologyList.DataSource = dBConnect.GetColumnData("topic_technology", "Topics");
                cbTopicTechnologyList.DisplayMember = "topic_technology";
                cbTopicTechnologyList.ValueMember = "topic_technology";

                //hiện màu cho row topic student đã đăng kí 
                DataTable dt = new DataTable();
                dt = dBConnect.GetData(string.Format("SELECT topic_id FROM RegisterQueue WHERE student_id = '{0}'", studentID));
                if (dt.Rows.Count > 0)
                {
                    string topicId = dt.Rows[0]["topic_id"].ToString();
                    if (topicId != null)
                    {
                        dgvTopics.ReadOnly = true;
                        foreach (DataGridViewRow row in dgvTopics.Rows)
                        {
                            if (row.Cells["topic_id"].Value != null)
                            {
                                if (row.Cells["topic_id"].Value.ToString() == topicId)
                                {
                                    row.DefaultCellStyle.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dgvTopics_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Topic topic = new Topic();
                    DataGridViewRow row = dgvTopics.Rows[e.RowIndex];
                    topic.Id = int.Parse(row.Cells["topic_id"].Value.ToString());
                    topic.Name = row.Cells["topic_name"].Value.ToString();
                    topic.Description = row.Cells["topic_description"].Value.ToString();
                    topic.Category = row.Cells["topic_category"].Value.ToString();
                    topic.Technology = row.Cells["topic_technology"].Value.ToString();
                    topic.Requirement = row.Cells["topic_requirement"].Value.ToString();
                    topic.MaxMember = int.Parse(row.Cells["max_members"].Value.ToString());

                    FRegisterTopic registerForm = new FRegisterTopic(topic, studentID, row.Cells["teacher_name"].Value.ToString());
                    registerForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void cbTeacherList_SelectedIndexChanged(object sender, EventArgs e)
        {

            TopicDAO topicDAO = new TopicDAO();
            //MessageBox.Show(cbTeacherList.SelectedValue.ToString());
            //topicDAO.LoadTopic(string.Format("SELECT *FROM Teacher WHERE teacher_name = {0}", cbTeacherList.SelectedValue.ToString()), dgvTopics);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtDescribe.Text;
            var searchEngine = new TFIDF();
            if (query != null)
            {
                List<Document> searchResults = searchEngine.Search(query);
                dgvTopics.Rows.Clear();
                foreach (var document in searchResults)
                {
                    // Add a row to the DataGridView for each document
                    dgvTopics.Rows.Add(
                        document.TopicId,
                        document.TopicName,
                        document.TopicDescription,
                        document.TopicTechnology,
                        document.TopicRequirement,
                        document.TopicCategory,
                        document.TopicMaxMembers,
                        document.TeacherId,
                        document.TeacherName
                    );
                }
            }
            else
            {
                dgvTopics.Rows.Clear();
                FStudentRegisterTopic_Load();
            }

        }

        private void ptbReload_Click(object sender, EventArgs e)
        {
            FStudentRegisterTopic_Load();
        }
    }
}
