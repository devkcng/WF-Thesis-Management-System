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
            this.splNotification = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblSendBy = new System.Windows.Forms.Label();
            this.dtpSendTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.icmCheckbox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblNotificationContent = new System.Windows.Forms.Label();
            this.lblNotificationName = new System.Windows.Forms.Label();
            this.splNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // splNotification
            // 
            this.splNotification.BackColor = System.Drawing.Color.Transparent;
            this.splNotification.Controls.Add(this.lblSendBy);
            this.splNotification.Controls.Add(this.dtpSendTime);
            this.splNotification.Controls.Add(this.icmCheckbox);
            this.splNotification.Controls.Add(this.lblNotificationContent);
            this.splNotification.Controls.Add(this.lblNotificationName);
            this.splNotification.FillColor = System.Drawing.Color.White;
            this.splNotification.Location = new System.Drawing.Point(0, 0);
            this.splNotification.Name = "splNotification";
            this.splNotification.ShadowColor = System.Drawing.Color.Black;
            this.splNotification.Size = new System.Drawing.Size(858, 161);
            this.splNotification.TabIndex = 0;
            // 
            // lblSendBy
            // 
            this.lblSendBy.AutoSize = true;
            this.lblSendBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendBy.Location = new System.Drawing.Point(588, 102);
            this.lblSendBy.Name = "lblSendBy";
            this.lblSendBy.Size = new System.Drawing.Size(155, 29);
            this.lblSendBy.TabIndex = 4;
            this.lblSendBy.Text = "Mai Đức Kiên";
            // 
            // dtpSendTime
            // 
            this.dtpSendTime.Checked = true;
            this.dtpSendTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSendTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSendTime.Location = new System.Drawing.Point(593, 34);
            this.dtpSendTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSendTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSendTime.Name = "dtpSendTime";
            this.dtpSendTime.Size = new System.Drawing.Size(167, 36);
            this.dtpSendTime.TabIndex = 3;
            this.dtpSendTime.Value = new System.DateTime(2024, 4, 4, 21, 29, 9, 316);
            // 
            // icmCheckbox
            // 
            this.icmCheckbox.CheckedState.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38__2_;
            this.icmCheckbox.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.icmCheckbox.ImageOffset = new System.Drawing.Point(0, 0);
            this.icmCheckbox.ImageRotate = 0F;
            this.icmCheckbox.ImageSize = new System.Drawing.Size(40, 40);
            this.icmCheckbox.Location = new System.Drawing.Point(21, 46);
            this.icmCheckbox.Name = "icmCheckbox";
            this.icmCheckbox.Size = new System.Drawing.Size(81, 63);
            this.icmCheckbox.TabIndex = 2;
            // 
            // lblNotificationContent
            // 
            this.lblNotificationContent.AutoSize = true;
            this.lblNotificationContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationContent.Location = new System.Drawing.Point(125, 102);
            this.lblNotificationContent.Name = "lblNotificationContent";
            this.lblNotificationContent.Size = new System.Drawing.Size(113, 32);
            this.lblNotificationContent.TabIndex = 1;
            this.lblNotificationContent.Text = "Làm Wed";
            // 
            // lblNotificationName
            // 
            this.lblNotificationName.AutoSize = true;
            this.lblNotificationName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationName.Location = new System.Drawing.Point(124, 32);
            this.lblNotificationName.Name = "lblNotificationName";
            this.lblNotificationName.Size = new System.Drawing.Size(417, 38);
            this.lblNotificationName.TabIndex = 0;
            this.lblNotificationName.Text = "Thông báo này cho bạn cường";
            // 
            // UcNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splNotification);
            this.Name = "UcNotification";
            this.Size = new System.Drawing.Size(861, 161);
            this.splNotification.ResumeLayout(false);
            this.splNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel splNotification;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSendTime;
        private Guna.UI2.WinForms.Guna2ImageCheckBox icmCheckbox;
        private System.Windows.Forms.Label lblNotificationContent;
        private System.Windows.Forms.Label lblNotificationName;
        private System.Windows.Forms.Label lblSendBy;
    }
}
