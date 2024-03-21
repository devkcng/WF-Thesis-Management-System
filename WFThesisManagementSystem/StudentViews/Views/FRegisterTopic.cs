using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.StudentViews.Views
{
    public partial class FRegisterTopic : Form
    {
        Topic topic;
        public FRegisterTopic(Topic topic)
        {
            InitializeComponent();
            this.topic = topic;
            this.lblProject.Text = topic.Name;
            numericUpDownSize.Maximum = topic.MaxMember;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentGroup studentGroup = new StudentGroup();
            studentGroup.Id = topic.Id+1;
            studentGroup.Name = txtGroupName.ToString();
            studentGroup.Size = (int)numericUpDownSize.Value;
            studentGroup.TopicID = topic.Id;

            StudentGroupDAO studentGroupDAO = new StudentGroupDAO();
            DBConnect dBConnect = new DBConnect();
            dBConnect.ExecuteSqlQuery(studentGroupDAO.AddGroup(studentGroup));

            foreach (DataGridViewRow row in dgvrRegisterMember.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra nếu dòng không phải là dòng mới
                {
                    // Lấy giá trị của cột "student_id" từ từng dòng
                    int studentId = Convert.ToInt32(row.Cells["student_id"].Value); // Sử dụng Convert thay vì ép kiểu trực tiếp

                    StudentDAO studentDAO = new StudentDAO();
                    dBConnect.ExecuteSqlQuery(studentDAO.UpdateStudentGroup(studentGroup.Id, studentId));
                }
            }
            MessageBox.Show("Register Successfully");
            FStudentRegisterTopic.ActiveForm.Close();
            this.Close();
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các dòng hiện có trong DataGridView
            dgvrRegisterMember.Rows.Clear();

            // Lấy số lượng thành viên được chọn từ ComboBox
            int numberOfMembers = (int)(numericUpDownSize.Value);

            // Thêm số lượng dòng tương ứng vào DataGridView
            for (int i = 1; i < numberOfMembers; i++)
            {
                dgvrRegisterMember.Rows.Add(); // Thêm một dòng mới vào DataGridView
            }
        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }
    }
}
