using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FStudentRegisterTopic : Form
    {
        public FStudentRegisterTopic()
        {
            InitializeComponent();
        }

        private void FStudentRegisterTopic_Load(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dt = new DataTable();
            TeacherDAO teacherDao = new TeacherDAO();
            dgvTopics.DataSource = dBConnect.LoadData("Topics");
            foreach (DataGridViewRow row in dgvTopics.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["teacher_name"].Value = teacherDao.GetTeacherNameFromTeacherID(row.Cells["teacher_id"].Value.ToString());
                }
            }
        }

        private void dgvTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Topic topic = new Topic();
                DataGridViewRow row = dgvTopics.Rows[e.RowIndex];
                topic.Id = (int)(row.Cells["topic_id"].Value);
                topic.Description = row.Cells["topic_description"].Value.ToString();
                topic.Category = row.Cells["topic_category"].Value.ToString();
                topic.Technology = row.Cells["topic_technology"].Value.ToString();
                topic.Requirement = row.Cells["topic_requirement"].Value.ToString();
                topic.MaxMember = (int)(row.Cells["max_members"].Value);
                //string topicDescription = row.Cells["topic_description"].Value.ToString();

                FRegisterTopic registerForm = new FRegisterTopic(topic);
                registerForm.ShowDialog();
            }
        }
    }
}
