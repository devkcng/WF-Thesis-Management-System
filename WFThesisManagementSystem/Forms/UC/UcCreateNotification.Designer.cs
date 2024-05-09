namespace WFThesisManagementSystem.Forms.UC
{
    partial class UcCreateNotification
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
            this.cbxNotificationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNotificationType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotificationContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotificationContent = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotificationTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotificationTitle = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNotificationType
            // 
            this.cbxNotificationType.BackColor = System.Drawing.Color.Transparent;
            this.cbxNotificationType.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbxNotificationType.BorderRadius = 8;
            this.cbxNotificationType.BorderThickness = 2;
            this.cbxNotificationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxNotificationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNotificationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxNotificationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxNotificationType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNotificationType.ForeColor = System.Drawing.Color.Black;
            this.cbxNotificationType.ItemHeight = 30;
            this.cbxNotificationType.Items.AddRange(new object[] {
            "Online meeting ",
            "Other"});
            this.cbxNotificationType.Location = new System.Drawing.Point(309, 496);
            this.cbxNotificationType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxNotificationType.Name = "cbxNotificationType";
            this.cbxNotificationType.Size = new System.Drawing.Size(952, 36);
            this.cbxNotificationType.TabIndex = 55;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(192, 133);
            this.lblNote.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(1149, 54);
            this.lblNote.TabIndex = 63;
            this.lblNote.Text = "This form is for teachers only. Students are not allowed to use it";
            // 
            // lblNotificationType
            // 
            this.lblNotificationType.AutoSize = true;
            this.lblNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationType.ForeColor = System.Drawing.Color.White;
            this.lblNotificationType.Location = new System.Drawing.Point(300, 418);
            this.lblNotificationType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotificationType.Name = "lblNotificationType";
            this.lblNotificationType.Size = new System.Drawing.Size(364, 46);
            this.lblNotificationType.TabIndex = 57;
            this.lblNotificationType.Text = "Notification Type *";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(462, 90);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(792, 46);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "CREATE A NOTIFICATION FOR THESIS";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtNotificationContent);
            this.guna2Panel4.Controls.Add(this.lblNotificationContent);
            this.guna2Panel4.Location = new System.Drawing.Point(309, 604);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(994, 434);
            this.guna2Panel4.TabIndex = 60;
            // 
            // txtNotificationContent
            // 
            this.txtNotificationContent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNotificationContent.BorderRadius = 8;
            this.txtNotificationContent.BorderThickness = 3;
            this.txtNotificationContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotificationContent.DefaultText = "";
            this.txtNotificationContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotificationContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotificationContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotificationContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotificationContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotificationContent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationContent.ForeColor = System.Drawing.Color.Black;
            this.txtNotificationContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotificationContent.Location = new System.Drawing.Point(14, 64);
            this.txtNotificationContent.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNotificationContent.Name = "txtNotificationContent";
            this.txtNotificationContent.PasswordChar = '\0';
            this.txtNotificationContent.PlaceholderText = "";
            this.txtNotificationContent.SelectedText = "";
            this.txtNotificationContent.Size = new System.Drawing.Size(955, 363);
            this.txtNotificationContent.TabIndex = 7;
            // 
            // lblNotificationContent
            // 
            this.lblNotificationContent.AutoSize = true;
            this.lblNotificationContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationContent.ForeColor = System.Drawing.Color.White;
            this.lblNotificationContent.Location = new System.Drawing.Point(5, 12);
            this.lblNotificationContent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotificationContent.Name = "lblNotificationContent";
            this.lblNotificationContent.Size = new System.Drawing.Size(419, 46);
            this.lblNotificationContent.TabIndex = 6;
            this.lblNotificationContent.Text = "Notification Content *";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtNotificationTitle);
            this.guna2Panel1.Controls.Add(this.lblNotificationTitle);
            this.guna2Panel1.Location = new System.Drawing.Point(309, 237);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(994, 130);
            this.guna2Panel1.TabIndex = 58;
            // 
            // txtNotificationTitle
            // 
            this.txtNotificationTitle.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNotificationTitle.BorderRadius = 8;
            this.txtNotificationTitle.BorderThickness = 2;
            this.txtNotificationTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotificationTitle.DefaultText = "";
            this.txtNotificationTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotificationTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotificationTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotificationTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotificationTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotificationTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationTitle.ForeColor = System.Drawing.Color.Black;
            this.txtNotificationTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotificationTitle.Location = new System.Drawing.Point(12, 60);
            this.txtNotificationTitle.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtNotificationTitle.Name = "txtNotificationTitle";
            this.txtNotificationTitle.PasswordChar = '\0';
            this.txtNotificationTitle.PlaceholderText = "";
            this.txtNotificationTitle.SelectedText = "";
            this.txtNotificationTitle.Size = new System.Drawing.Size(955, 60);
            this.txtNotificationTitle.TabIndex = 1;
            // 
            // lblNotificationTitle
            // 
            this.lblNotificationTitle.AutoSize = true;
            this.lblNotificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationTitle.ForeColor = System.Drawing.Color.White;
            this.lblNotificationTitle.Location = new System.Drawing.Point(5, 8);
            this.lblNotificationTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotificationTitle.Name = "lblNotificationTitle";
            this.lblNotificationTitle.Size = new System.Drawing.Size(352, 46);
            this.lblNotificationTitle.TabIndex = 0;
            this.lblNotificationTitle.Text = "Notification Title *";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnClear);
            this.guna2Panel5.Controls.Add(this.btnDone);
            this.guna2Panel5.Controls.Add(this.btnClose);
            this.guna2Panel5.Location = new System.Drawing.Point(802, 1088);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(644, 85);
            this.guna2Panel5.TabIndex = 64;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 7;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(197, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(217, 85);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 5;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(0, 0);
            this.btnDone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(185, 85);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Location = new System.Drawing.Point(427, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(217, 85);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            // 
            // UcCreateNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.cbxNotificationType);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblNotificationType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UcCreateNotification";
            this.Size = new System.Drawing.Size(1620, 1226);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ComboBox cbxNotificationType;
        private System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.Label lblNotificationType;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public Guna.UI2.WinForms.Guna2TextBox txtNotificationContent;
        public System.Windows.Forms.Label lblNotificationContent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2TextBox txtNotificationTitle;
        public System.Windows.Forms.Label lblNotificationTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        public Guna.UI2.WinForms.Guna2Button btnDone;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnClear;
    }
}
