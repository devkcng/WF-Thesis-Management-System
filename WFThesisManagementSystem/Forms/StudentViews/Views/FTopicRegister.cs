using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{

    public partial class FTopicRegister : Form
    {
        private Topic _topic;
        StudentRepository _studentRepository;
        StudentGroupRepository _studentGroupRepository;
        RegisterQueueRepository _registerQueue;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        private ThesisManagementContext _context;
        public FTopicRegister(Topic topic, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(600, 400);
            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            this._topic = topic;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please enter group name");
                return;
            }
            if(CountDataRows(dgvrRegisterMember) > _topic.max_members)
            {
                MessageBox.Show("Your group can only have " + _topic.max_members + " members");
                return;
            }
            if (CountDataRows(dgvrRegisterMember) == 0)
            {
                MessageBox.Show("Please enter the your group member info in the table");
                return;
            }
            foreach (DataGridViewRow row in dgvrRegisterMember.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng header và có dữ liệu
                if (!row.IsNewRow && row.Cells["student_id"].Value != null)
                {
                    // Lấy giá trị của cột "student_id" từ hàng hiện tại
                    int studentId = Convert.ToInt32(row.Cells["student_id"].Value);
                    var student = _studentRepository.GetById(studentId);
                    RegistrationService registrationService = new
    RegistrationService(student, _topic, txtGroupName.Text);
                    if (!registrationService.Register())
                    {
                        MessageBox.Show("Register failed, please check carefully that your group member info is correct");
                        return;
                    }
                }
            }
            MessageBox.Show("Register successfully");
            this.Close();
            FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
            fStudentRegisterTopic.Show();
        }
        private int CountDataRows(DataGridView dataGridView)
        {
            int count = 0;

            // Lặp qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng header và có dữ liệu
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    count++; // Tăng số lượng dòng có dữ liệu
                }
            }

            return count;
        }


    }
}
