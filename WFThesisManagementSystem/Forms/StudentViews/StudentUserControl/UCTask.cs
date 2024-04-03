using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCTask : UserControl
    {
        public event EventHandler Clicked;
        private string _name;
        private int _id;
        private int _groupID;
        public string Name
        {
            set { _name = value; lblName.Text = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }
        public UCTask()
        {
            InitializeComponent();
            sdpsingletask.Click += UCTask_CLick;
        }
        public void UCTask_CLick(object sender, EventArgs e)
        {
            OnClicked(EventArgs.Empty);
        }

        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }






    }
}
