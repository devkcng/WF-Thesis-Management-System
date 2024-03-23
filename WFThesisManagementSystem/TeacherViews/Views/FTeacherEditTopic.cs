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
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherEditTopic : Form
    {
        private readonly TopicDAO topicDAO = new TopicDAO();
        private readonly DBConnect dbConnect = new DBConnect();
        public FTeacherEditTopic()
        {
            InitializeComponent();
            ucTeacherEditTopic1.btnClose.Click += close;
            ucTeacherEditTopic1.btnUpdate.Click += update;

        }
        private void close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void update(object sender, EventArgs e)
        {
            if (ucTeacherEditTopic1.txtTopicId.Text != "" && ucTeacherEditTopic1.txtTopicId.Text != "" && ucTeacherEditTopic1.txtTopicName.Text != "" && ucTeacherEditTopic1.txtTopicDescription.Text != "" && ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString() != "" && ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString() != "" && ucTeacherEditTopic1.txtTopicRequirement.Text != "" && ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString() != "")
            {
                for (int i = 0; i <= ucTeacherEditTopic1.txtTopicId.Text.Length - 1; i++)
                {
                    if (ucTeacherEditTopic1.txtTopicId.Text[i] > '9' || ucTeacherEditTopic1.txtTopicId.Text[i] < '0')
                    {
                        MessageBox.Show("Error!!!");
                        return;
                    }
                }
                Topic topic = new Topic(int.Parse(ucTeacherEditTopic1.txtTopicId.Text), ucTeacherEditTopic1.txtTopicName.Text, ucTeacherEditTopic1.txtTopicDescription.Text, ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString(), ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString(), ucTeacherEditTopic1.txtTopicRequirement.Text, int.Parse(ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString()));
                //TopicDAO topicDAO = new TopicDAO();
                if (topicDAO.CheckData(topic))
                {
                    if (dbConnect.ExecuteSqlQuery(topicDAO.UpdateTopic(topic)))
                    {
                        MessageBox.Show("Update Success");
                        this.Hide();
                        //UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
                        //UcTeacherAllTopics_Load(sender, e);
                        //FTeacherDashboard fTeacherDashboard = new FTeacherDashboard();
                        //fTeacherDashboard_Load(sender, e);
                        //FTeacherCreateTopic_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }
    }
}
