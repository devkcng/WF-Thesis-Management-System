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
    public partial class FTeacherCreateTopic : Form
    {   
        private readonly TopicDAO topicDAO = new TopicDAO();
        private readonly DBConnect dbConnect = new DBConnect();
        public FTeacherCreateTopic()
        {
            InitializeComponent();
            ucTeacherCreateTopic1.btnSave.Click += Save;
            ucTeacherCreateTopic1.btnClear.Click += Clear;
        }
        private void Save(object sender, EventArgs e)
        {
            if (ucTeacherCreateTopic1.txtTopicId.Text!="" && ucTeacherCreateTopic1.txtTopicId.Text!=""&& ucTeacherCreateTopic1.txtTopicName.Text!=""&& ucTeacherCreateTopic1.txtTopicDescription.Text!=""&& ucTeacherCreateTopic1.cbxTopicCategory.SelectedItem.ToString()!=""&& ucTeacherCreateTopic1.cbxTopicTechnology.SelectedItem.ToString()!=""&&ucTeacherCreateTopic1.txtTopicRequirement.Text!=""&& ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString()!="")
            {
                for (int i = 0; i <= ucTeacherCreateTopic1.txtTopicId.Text.Length - 1; i++)
                {
                    if (ucTeacherCreateTopic1.txtTopicId.Text[i] > '9' || ucTeacherCreateTopic1.txtTopicId.Text[i] < '0')
                    {
                        MessageBox.Show("Error!!!");
                        return;
                    }
                }
                Topic topic = new Topic(int.Parse(ucTeacherCreateTopic1.txtTopicId.Text), ucTeacherCreateTopic1.txtTopicName.Text, ucTeacherCreateTopic1.txtTopicDescription.Text, ucTeacherCreateTopic1.cbxTopicCategory.SelectedItem.ToString(), ucTeacherCreateTopic1.cbxTopicTechnology.SelectedItem.ToString(), ucTeacherCreateTopic1.txtTopicRequirement.Text, int.Parse(ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString()));
                //TopicDAO topicDAO = new TopicDAO();
                if (topicDAO.CheckData(topic))
                {
                    if (dbConnect.ExecuteSqlQuery(topicDAO.AddTopic(topic)))
                    {
                        //UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
                        //ucTeacherAllTopics.UcTeacherAllTopics_Load(sender, e);
                        MessageBox.Show("Add Success");
                        this.Hide();


                    }
                }
            }
            else
            {
                MessageBox.Show("Error!!!");
            } 
                
            
        }
        private void Clear(object sender, EventArgs e)
        {
            ucTeacherCreateTopic1.txtTopicRequirement.Clear();
            ucTeacherCreateTopic1.txtTopicDescription.Clear();
            ucTeacherCreateTopic1.txtTopicName.Clear();
            //ucTeacherCreateTopic1.cbxNumber.

        }
    }
}
