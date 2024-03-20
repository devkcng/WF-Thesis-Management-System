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

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherCreateTopic : Form
    {
        public FTeacherCreateTopic()
        {
            InitializeComponent();
            ucTeacherCreateTopic1.btnSave.Click += Save;
            ucTeacherCreateTopic1.btnClear.Click += Clear;
        }
        private void Save(object sender, EventArgs e)
        {
            this.Hide();
            Topic topic = new Topic("1", ucTeacherCreateTopic1.txtTopicName.Text, ucTeacherCreateTopic1.txtTopicDescription.Text, ucTeacherCreateTopic1.cbxTopicCategory.Items.ToString(), ucTeacherCreateTopic1.cbxTopicTechnology.Items.ToString(), ucTeacherCreateTopic1.txtTopicRequirement.Text, ucTeacherCreateTopic1.cbxNumber.Items.ToString());
            TopicDAO topicDAO = new TopicDAO();
            if(topicDAO.Add(topic,"Topics"))
            {
                MessageBox.Show("Thêm thành công");
                //FTeacherCreateTopic_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi");
            } 
                
            
        }
        private void Clear(object sender, EventArgs e)
        {
            ucTeacherCreateTopic1.txtTopicRequirement.Clear();
            ucTeacherCreateTopic1.txtTopicDescription.Clear();
            ucTeacherCreateTopic1.txtTopicName.Clear();

        }
    }
}
