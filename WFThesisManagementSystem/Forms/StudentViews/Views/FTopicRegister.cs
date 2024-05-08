using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
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
            this.Size = new Size(550, 450);
            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            this._topic = topic;
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

        private void FTopicRegister_Load(object sender, EventArgs e)
        {
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroupList = _studentGroupRepository.GetAllByTopicID(_topic.topic_id);
            List<Student> studentList = new List<Student>();
            RegistrationService registrationService = new
        RegistrationService(student, _topic, txtGroupName.Text);

            //load member group onto dgv and group name
            foreach (var studentgroup in studentGroupList)
            {
                studentList.AddRange(_studentRepository.GetAllByGroupId(studentgroup.group_id).ToList());
                if (studentList.Count() > 0)
                {
                    txtGroupName.Text = studentgroup.group_name;
                    txtGroupName.ReadOnly = true;
                    break;
                }
            }

            foreach(var member in studentList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvrRegisterMember); 

                // Gán giá trị id và name vào các ô của row
                row.Cells[1].Value = member.student_id;
                row.Cells[0].Value = member.student_name;
                // Thiết lập các ô của hàng là chỉ đọc
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = true;
                }
                // Thêm row vào DataGridView
                dgvrRegisterMember.Rows.Add(row);
            }


            //check if member is full => cannot register

            if (CountDataRows(dgvrRegisterMember) >= _topic.max_members)
            {
                btnRegister.Enabled = false;
            }
            //add data of user onto datagridview, if they already register that topic, it will not add
            else if(registrationService.Unregistered())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvrRegisterMember);
                newRow.Cells[1].Value = _userSessionHelper.UserID;
                newRow.Cells[0].Value = _studentRepository.GetById(_userSessionHelper.UserID).student_name;
                dgvrRegisterMember.Rows.Add(newRow);
            }
            else if (!registrationService.Unregistered())
            {
                btnRegister.Enabled = false;
            }

            //

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            //
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroup = _studentGroupRepository.GetByTopicId(_topic.topic_id);
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please enter group name");
                return;
            }
            if (CountDataRows(dgvrRegisterMember) > _topic.max_members)
            {
                MessageBox.Show("Your group can only have " + _topic.max_members + " members");
                return;
            }
            if (CountDataRows(dgvrRegisterMember) == 0)
            {
                MessageBox.Show("Please enter the your group member info in the table");
                return;
            }


            //
            List<Student> memberGroup = new List<Student>();
            foreach (DataGridViewRow row in dgvrRegisterMember.Rows)
            {
                int studentId = Convert.ToInt32(row.Cells["student_id"].Value);
                var member = _studentRepository.GetById(studentId);
                RegistrationService registrationService = new
        RegistrationService(member, _topic, txtGroupName.Text);

                // Kiểm tra nếu hàng không phải là hàng header và có dữ liệu
                if (!row.IsNewRow && row.Cells["student_id"].Value != null && row.Cells["student_id"].ReadOnly == false)
                {
                    if (member  == null)
                    {
                        MessageBox.Show("Student have the ID: " + studentId + " does not exist");
                        return;
                    }
                    else if (!registrationService.CanRegist())
                    {
                        MessageBox.Show("Student have the ID: " + studentId + " don't have permission to regist");
                        return;
                    }
                    else if(registrationService.AlreadyRegistered())
                    {
                        MessageBox.Show("Student have the ID: " + studentId + " already have a group");
                        return;
                    }
                    else if (registrationService.InQueue())
                    {
                        MessageBox.Show("Student have the ID: " + studentId + " already in queue");
                        return;
                    }

                    //check the row which user has enter the data
                    bool rowIsReadOnly = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!cell.ReadOnly)
                        {
                            rowIsReadOnly = false;
                            break;
                        }
                    }

                    if (!rowIsReadOnly)
                    {
                        memberGroup.Add(member);
                    }
                }
            }

            foreach(var member in memberGroup)
            {
                RegistrationService registrationService = new
        RegistrationService(member, _topic, txtGroupName.Text);
                registrationService.Register();
            }
            MessageBox.Show("Register successfully");
            this.Close();
            FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
            fStudentRegisterTopic.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FShowTopic fShowTopic = new FShowTopic(_topic, _context);
            this.Hide();
            fShowTopic.Show();
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
