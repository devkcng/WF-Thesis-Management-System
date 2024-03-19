using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFThesisManagementSystem.Views.StudentViews
{
    public partial class UCStudentProject : UserControl
    {
        private Rectangle panelOriginalRectangle;
        private Rectangle originalFormSize;

        public UCStudentProject()
        {
            InitializeComponent();
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            panelOriginalRectangle = new Rectangle(flowLayoutPanelContainer.Location.X, flowLayoutPanelContainer.Location.Y, flowLayoutPanelContainer.Size.Width, flowLayoutPanelContainer.Size.Height);
            addUserControl(); // Gọi addUserControl trong sự kiện Load của form

        }

        private void addUserControl()
        {
            for (int i = 0; i < 10; i++)
            {
                UCProject uc = new UCProject();
                uc.Width = flowLayoutPanelContainer.Width; // Đặt Width của UserControl bằng Width của FlowLayoutPanel
                flowLayoutPanelContainer.Controls.Add(uc);
            }
        }
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width)/(float)(originalFormSize.Width);
            float yRatio = (float)(this.Height)/(float)(originalFormSize.Height);
            //int newX = (int)(r.Width * xRatio);
            //int newY = (int)(r.Height * yRatio);
            //int newWidth = (int)(r.Width * xRatio);
            //int newHeight = (int)(r.Height * yRatio);
            int newWidth = (int)(c.Width * xRatio);
            int newHeight = (int)(c.Height * yRatio);
            //c.Location=new Point (newX, newY);
            c.Size = new Size (newWidth, newHeight);
        }
        private void UCStudentProject_Resize(object sender, EventArgs e)
        {
            //resizeControl(panelOriginalRectangle, flowLayoutPanelContainer);
            foreach (Control control in flowLayoutPanelContainer.Controls)
            {
                // Thay đổi kích thước của từng UserControl
                control.Width = flowLayoutPanelContainer.Width; // Đặt Width của UserControl bằng Width của FlowLayoutPanel
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            resizeControl(panelOriginalRectangle, flowLayoutPanelContainer);

            //flowLayoutPanelContainer.Width = this.Width;
            foreach (Control control in flowLayoutPanelContainer.Controls)
            {
                // Thay đổi kích thước của từng UserControl
                control.Width = (flowLayoutPanelContainer.Width); // Đặt Width của UserControl bằng Width của FlowLayoutPanel
                
            }
            
        }
    }
}
