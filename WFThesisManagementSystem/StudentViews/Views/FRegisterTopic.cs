using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
        private Topic topic;
        private int studentID;
        private string teacherName;
        private RegisterQueue registerQueue = new RegisterQueue();
        private StudentGroupDAO studentGroupDAO = new StudentGroupDAO();
        StudentGroup studentGroup = new StudentGroup();
        StudentDAO studentDAO = new StudentDAO();   

        public FRegisterTopic(Topic topic,int student_id, string teacher_name)
        {
            InitializeComponent();
            this.topic = topic;
            studentID = student_id;
            teacherName = teacher_name;
            FRegisterTopic_Load();
            LoadGroupInfo();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterQueueDAO registerQueueDAO = new RegisterQueueDAO();
            if (/*studentDAO.GetGroupIDOfStudent(studentID).Length != 0*/  !registerQueueDAO.IsStudentAvailable(studentID))
            {
                registerQueue.topic_id = topic.Id;
                registerQueue.student_id = studentID;
                studentGroup.Id = registerQueue.group_id = 10;
                studentGroup.Name = txtGroupName.Text;
                studentGroup.Size = topic.MaxMember;
                studentGroup.TopicID = topic.Id;

                //MessageBox.Show(registerQueue.student_id.ToString() + " " + registerQueue.group_id.ToString() + " " + registerQueue.topic_id.ToString());
                DBConnect dBConnect = new DBConnect();
                if (dgvrRegisterMember.Visible == true)
                {
                    string group_id;
                    group_id = dBConnect.GetData(registerQueueDAO.GetGroupIDFromTopicID(topic.Id)).Rows[0]["group_id"].ToString();
                    studentGroup.Id = registerQueue.group_id = int.Parse(group_id);
                }
                else
                {

                    dBConnect.ExecuteSqlQuery(studentGroupDAO.AddGroup(studentGroup));
                }
                //string str = RegisterQueueDAO.AddRegisterQueueData(registerQueue.student_id, registerQueue.group_id, registerQueue.topic_id);
                if (dBConnect.ExecuteSqlQuery(string.Format("INSERT INTO RegisterQueue (student_id, group_id, topic_id) " +
                                                "VALUES ('{0}', '{1}' ,'{2}')",
                                                            registerQueue.student_id, registerQueue.group_id, registerQueue.topic_id)))
                {
                    btnRegister.Enabled = false;
                    LoadGroupInfo();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("Cannot register because you have already registered");
            }
        }

        private void LoadGroupInfo()
        {
            RegisterQueueDAO registerQueueDAO = new RegisterQueueDAO();
            DBConnect dBConnect = new DBConnect();
            DataTable dt = new DataTable();
            if (registerQueueDAO.LoadGroupData(topic.Id, dgvrRegisterMember))
            {
                //datagridview visible;
                dgvrRegisterMember.Visible = true;
                // ô txtGroupName ko cho phép chỉnh sửa;
                studentDAO = new StudentDAO();
                txtGroupName.Enabled = false;
                txtGroupName.Text = studentGroup.Name;
                txtGroupName.Text = dBConnect.GetData(registerQueueDAO.GetGroupName(topic.Id)).Rows[0]["group_name"].ToString();
            }
            else
            {
                //datagridview visible;
                dgvrRegisterMember.Visible = false;
                // ô txtGroupName ko cho phép chỉnh sửa;
                txtGroupName.Enabled = true;
            }
        }
        private void FRegisterTopic_Load()
        {
            lblTopicName.Text = topic.Name;
            txtDescription.Text = topic.Description;
            lblLoadTechnology.Text = topic.Technology;
            lblLoadRequirement.Text = topic.Requirement;
            lblLoadCategory.Text = topic.Category;
            lblLoadMaxMember.Text = topic.MaxMember.ToString();
            lblLoadTeacherName.Text = teacherName;


        }
    }
}
