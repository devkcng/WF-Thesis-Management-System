using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTopics : UserControl
    {
        public event EventHandler _cbTopicTypeChanged;

        public UcTeacherAllTopics()
        {
            InitializeComponent();
            CbTopicType.SelectedValueChanged += CbTopicType_SelectedIndexChanged;
        }
        private void CbTopicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbTopicTypeChanged?.Invoke(this, e);

        }
    }
}
