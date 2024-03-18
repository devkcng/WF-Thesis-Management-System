using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTopics : UserControl
    {
        public UcTeacherAllTopics()
        {
            InitializeComponent();
           
        }
        public void ListTopic()
        {
            UcTeacherSingleTopic[] topics = new UcTeacherSingleTopic[20];
            flpTopicView.Controls.Clear();
            for (int i = 0; i < topics.Length; i++)
            {
                topics[i] = new UcTeacherSingleTopic();
                topics[i].Name = "Kiến thức chuyên ngành";
                topics[i].Description = "Khó";
                flpTopicView.Controls.Add(topics[i]);
            }    

        }

        private void ucSingletopic1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void ucTeacherSingleTopic1_Load(object sender, EventArgs e)
        {

        }

        private void UcTeacherAllTopics_Load(object sender, EventArgs e)
        {
            ListTopic();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
