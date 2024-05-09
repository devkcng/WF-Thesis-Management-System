namespace WFThesisManagementSystem.Forms.UC
{
    partial class UcNotification
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblSendBy = new System.Windows.Forms.Label();
            this.dtpSendTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.icmCheckbox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblNotificationContent = new System.Windows.Forms.Label();
            this.lblNotificationName = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblSendBy);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpSendTime);
            this.guna2CustomGradientPanel1.Controls.Add(this.icmCheckbox);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNotificationContent);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNotificationName);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1531, 195);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // lblSendBy
            // 
            this.lblSendBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendBy.AutoSize = true;
            this.lblSendBy.BackColor = System.Drawing.Color.White;
            this.lblSendBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendBy.Location = new System.Drawing.Point(1188, 94);
            this.lblSendBy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSendBy.Name = "lblSendBy";
            this.lblSendBy.Size = new System.Drawing.Size(257, 46);
            this.lblSendBy.TabIndex = 9;
            this.lblSendBy.Text = "Mai Đức Kiên";
            // 
            // dtpSendTime
            // 
            this.dtpSendTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSendTime.Checked = true;
            this.dtpSendTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSendTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSendTime.Location = new System.Drawing.Point(1187, 17);
            this.dtpSendTime.Margin = new System.Windows.Forms.Padding(5);
            this.dtpSendTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSendTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSendTime.Name = "dtpSendTime";
            this.dtpSendTime.Size = new System.Drawing.Size(297, 56);
            this.dtpSendTime.TabIndex = 8;
            this.dtpSendTime.Value = new System.DateTime(2024, 4, 4, 21, 29, 9, 316);
            // 
            // icmCheckbox
            // 
            this.icmCheckbox.BackColor = System.Drawing.Color.White;
            this.icmCheckbox.CheckedState.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38__2_;
            this.icmCheckbox.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.icmCheckbox.ImageOffset = new System.Drawing.Point(0, 0);
            this.icmCheckbox.ImageRotate = 0F;
            this.icmCheckbox.ImageSize = new System.Drawing.Size(40, 40);
            this.icmCheckbox.Location = new System.Drawing.Point(23, 11);
            this.icmCheckbox.Margin = new System.Windows.Forms.Padding(5);
            this.icmCheckbox.Name = "icmCheckbox";
            this.icmCheckbox.Size = new System.Drawing.Size(144, 98);
            this.icmCheckbox.TabIndex = 7;
            // 
            // lblNotificationContent
            // 
            this.lblNotificationContent.AutoSize = true;
            this.lblNotificationContent.BackColor = System.Drawing.Color.White;
            this.lblNotificationContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationContent.Location = new System.Drawing.Point(190, 86);
            this.lblNotificationContent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotificationContent.Name = "lblNotificationContent";
            this.lblNotificationContent.Size = new System.Drawing.Size(187, 54);
            this.lblNotificationContent.TabIndex = 6;
            this.lblNotificationContent.Text = "Làm Wed";
            // 
            // lblNotificationName
            // 
            this.lblNotificationName.AutoSize = true;
            this.lblNotificationName.BackColor = System.Drawing.Color.White;
            this.lblNotificationName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationName.Location = new System.Drawing.Point(188, 11);
            this.lblNotificationName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotificationName.Name = "lblNotificationName";
            this.lblNotificationName.Size = new System.Drawing.Size(698, 62);
            this.lblNotificationName.TabIndex = 5;
            this.lblNotificationName.Text = "Thông báo này cho bạn cường";
            // 
            // UcNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UcNotification";
            this.Size = new System.Drawing.Size(1531, 195);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lblSendBy;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSendTime;
        public Guna.UI2.WinForms.Guna2ImageCheckBox icmCheckbox;
        private System.Windows.Forms.Label lblNotificationContent;
        private System.Windows.Forms.Label lblNotificationName;
    }
}
