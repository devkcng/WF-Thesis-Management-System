using Guna.UI2.WinForms;
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
using WFThesisManagementSystem.TeacherViews.Views;

namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleTopic : UserControl
    {
        public UcTeacherSingleTopic()
        {
            InitializeComponent();
        }

        private void UcTeacherSingleTopic_Load(object sender, EventArgs e)
        {

        }
        #region Properties
        private string name;
        private string description;
        private Guna2Button button;
        public void SetTopic(Topic topic)
        {
            lblName.Text = topic.Name;
            lblDescription.Text = topic.Description;
            Name = topic.Name;
            Description = topic.Description;

        }
        [Category("custom props")]
        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }

        }
        [Category("custom props")]
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = value; }
        }
        [Category("custom props")]
        public Guna2Button Button
        {
            get { return button; }
            set { button = value; btnEdit = value; }
        }
        #endregion
        //private void editTopic(object sender, EventArgs e)
        //{
            
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dataTable = dBConnect.LoadData("Topics");
            FTeacherEditTopic fTeacherEditTopic = new FTeacherEditTopic();
            fTeacherEditTopic.Show();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                if (Name == row["topic_name"].ToString())
                {
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicName.Text = row["topic_name"].ToString();
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicDescription.Text= row["topic_description"].ToString();
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicRequirement.Text= row["requirement"].ToString();
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicCategory.SelectedItem= row["category"].ToString();
                    fTeacherEditTopic.ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem = row["technology"].ToString();
                    fTeacherEditTopic.ucTeacherEditTopic1.cbxNumber.SelectedItem = "4";
                }

            }    
            
        }
    }
}
