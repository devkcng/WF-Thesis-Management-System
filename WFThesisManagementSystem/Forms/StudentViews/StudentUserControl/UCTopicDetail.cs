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
            //// Tính toán chiều cao cần thiết để hiển thị toàn bộ văn bản
            //int newHeight = TextRenderer.MeasureText(txtDescription.Text, txtDescription.Font, txtDescription.ClientSize, TextFormatFlags.WordBreak).Height;

            //// Đặt chiều cao mới cho TextBox
            //txtDescription.Height = newHeight;
        }
        public void SetColors(string textColorHex, string backColorHex)
        {
            Color textColor = ColorTranslator.FromHtml(textColorHex); // Chuyển đổi mã hex sang màu
            Color backColor = ColorTranslator.FromHtml(backColorHex); // Chuyển đổi mã hex sang màu

            // Đặt màu nền cho Panel bên trong
            foreach (Control ctrl in panelContainer.Controls)
            {
                ctrl.BackColor = backColor;
                ctrl.ForeColor = textColor;
            }

            // Đặt màu nền cho UserControl
            this.BackColor = backColor;
            panelContainer.BackColor=backColor;
        }
    }
}
