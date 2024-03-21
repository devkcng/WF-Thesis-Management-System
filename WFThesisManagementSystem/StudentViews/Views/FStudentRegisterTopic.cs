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
        private void dgvTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FStudentRegisterTopic_Load_1(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dt = new DataTable();
            TeacherDAO teacherDao = new TeacherDAO();

            dt = dBConnect.LoadData("Topics");

            foreach (DataRow row in dt.Rows)
            {
                // Tạo một mảng các đối tượng để lưu trữ giá trị của mỗi cột trong dòng
                object[] rowData = new object[dt.Columns.Count];

                // Lặp qua từng cột trong DataTable
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    // Thêm giá trị của mỗi cột vào mảng
                    rowData[i] = row[i];
                }

                // Thêm dòng mới vào DataGridView với dữ liệu từ mảng rowData
                // dataGridView là tên của DataGridView của bạn
                dgvTopics.Rows.Add(rowData);
            }


            foreach (DataGridViewRow row in dgvTopics.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["teacher_name"].Value = teacherDao.GetTeacherNameFromTeacherID(row.Cells["teacher_id"].Value.ToString());
                }
            }
        }

        private void dgvTopics_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
