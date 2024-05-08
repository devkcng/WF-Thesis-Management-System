using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{

    public partial class UCProgress : UserControl
    {
        public event EventHandler _cbDateTimeChanged;
        public event EventHandler _cbGroupCategoryChanged;
        public event EventHandler _cbMemberCategoryChanged;


        public UCProgress()
        {
            InitializeComponent();
            cbxDateTime.SelectedValueChanged += cbxDateTime_SelectedIndexChanged;
            cbxGroupCategory.SelectedValueChanged += cbxGroupCategory_SelectedIndexChanged;
            cbxMemberCategory.SelectedValueChanged += cbxMemberCategory_SelectedIndexChanged;
        }

        private void cbxDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbDateTimeChanged?.Invoke(this, e);

        }

        private void cbxMemberCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbMemberCategoryChanged?.Invoke(this, e);

        }

        private void cbxGroupCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbGroupCategoryChanged?.Invoke(this, e);

        }
    }
}
