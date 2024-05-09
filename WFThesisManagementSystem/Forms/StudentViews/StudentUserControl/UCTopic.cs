using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{

    public partial class UCTopic : UserControl
    {
        public event EventHandler Clicked;
        private string _name;
        private int _id;
        private string _description;
        private string _technology;
        private string _category;
        private string _requirement;
        private int _maxMember;
        private int _teacherID;

        private string _teacherName;


        public string Name
        {
            set { _name = value; lblName.Text = value; }
            get { return _name; }

        }
        public string Description
        {
            set { _description = value; }
            get { return _description; }

        }
        public string Technology
        {
            set { _technology = value; lblTechnology.Text = value; }
            get { return _technology; }

        }
        public string Category
        {
            set { _category = value; lblCategory.Text = value; }
            get { return _category; }

        }
        public string Requirement
        {
            set { _requirement = value; }
            get { return _requirement; }

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int TeacherId
        {
            get { return _teacherID; }
            set { _teacherID = value; }
        }
        public int MaxMember
        {
            get { return _maxMember; }
            set { _maxMember = value; lblMaxmember.Text = _maxMember.ToString(); }

        }
        public string TeacherName
        {
            set { _teacherName = value; lblTeacherName.Text = value; }
            get { return _teacherName; }

        }

        public UCTopic()
        {
            InitializeComponent();
            sdpsingletask.Click += UCTopic_CLick;
        }

        private void sdpsingletask_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UCTopic_CLick(object sender, EventArgs e)
        {
            OnClicked(EventArgs.Empty);
        }

        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
    }
}
