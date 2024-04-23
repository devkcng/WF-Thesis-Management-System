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
            // Điều chỉnh width của các TextBox khi nội dung thay đổi
            //txtTeacherName.TextChanged += (s, ev) => AdjustTextBoxWidth(txtTeacherName, 1500);
            //txtCategory.TextChanged += (s, ev) => AdjustTextBoxWidth(txtCategory, 1500);

            //// Điều chỉnh width của các TextBox ban đầu
            //AdjustTextBoxWidth(txtTeacherName,1500);
            //AdjustTextBoxWidth(txtCategory, 1500);

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

        private void AdjustTextBoxWidth(Guna2TextBox textBox, int maxWidth)
        {
            int textWidth = TextRenderer.MeasureText(textBox.Text, textBox.Font).Width+10;
            textBox.Width = Math.Min(textWidth, maxWidth);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTechnology_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTechnology_Click(object sender, EventArgs e)
        {

        }
    }
}
