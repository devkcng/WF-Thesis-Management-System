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
    public partial class UCTopicDetail : UserControl
    {
        public UCTopicDetail()
        {
            InitializeComponent();
            // Tính toán chiều cao cần thiết để hiển thị toàn bộ văn bản
            int newHeight = TextRenderer.MeasureText(txtDescription.Text, txtDescription.Font, txtDescription.ClientSize, TextFormatFlags.WordBreak).Height;

            // Đặt chiều cao mới cho TextBox
            txtDescription.Height = newHeight;
        }
        private void txtDescrssiption_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
