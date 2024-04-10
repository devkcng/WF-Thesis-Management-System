namespace WFThesisManagementSystem.Forms.UC
{
    partial class UcNotificationSendStudentAll
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
            this.flpNotificationStudent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNotificationStudent = new System.Windows.Forms.Label();
            this.ucTeacherAcceptRegisterSingle1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherAcceptRegisterSingle();
            this.flpNotificationGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.flpNotificationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpNotificationStudent
            // 
            this.flpNotificationStudent.AutoScroll = true;
            this.flpNotificationStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpNotificationStudent.Location = new System.Drawing.Point(586, 103);
            this.flpNotificationStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpNotificationStudent.Name = "flpNotificationStudent";
            this.flpNotificationStudent.Size = new System.Drawing.Size(419, 473);
            this.flpNotificationStudent.TabIndex = 15;
            // 
            // lblNotificationStudent
            // 
            this.lblNotificationStudent.AutoSize = true;
            this.lblNotificationStudent.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationStudent.Location = new System.Drawing.Point(67, 60);
            this.lblNotificationStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificationStudent.Name = "lblNotificationStudent";
            this.lblNotificationStudent.Size = new System.Drawing.Size(180, 26);
            this.lblNotificationStudent.TabIndex = 14;
            this.lblNotificationStudent.Text = "Send To Student";
            // 
            // ucTeacherAcceptRegisterSingle1
            // 
            this.ucTeacherAcceptRegisterSingle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAcceptRegisterSingle1.CheckRegist = null;
            this.ucTeacherAcceptRegisterSingle1.Id = 0;
            this.ucTeacherAcceptRegisterSingle1.IdStudent = null;
            this.ucTeacherAcceptRegisterSingle1.Location = new System.Drawing.Point(1, 1);
            this.ucTeacherAcceptRegisterSingle1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucTeacherAcceptRegisterSingle1.Name = "ucTeacherAcceptRegisterSingle1";
            this.ucTeacherAcceptRegisterSingle1.NameStudent = null;
            this.ucTeacherAcceptRegisterSingle1.Regist = null;
            this.ucTeacherAcceptRegisterSingle1.Size = new System.Drawing.Size(414, 98);
            this.ucTeacherAcceptRegisterSingle1.TabIndex = 0;
            // 
            // flpNotificationGroup
            // 
            this.flpNotificationGroup.AutoScroll = true;
            this.flpNotificationGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpNotificationGroup.Controls.Add(this.ucTeacherAcceptRegisterSingle1);
            this.flpNotificationGroup.Location = new System.Drawing.Point(53, 99);
            this.flpNotificationGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpNotificationGroup.Name = "flpNotificationGroup";
            this.flpNotificationGroup.Size = new System.Drawing.Size(424, 476);
            this.flpNotificationGroup.TabIndex = 13;
            // 
            // btnBackToEdit
            // 
            this.btnBackToEdit.BorderRadius = 7;
            this.btnBackToEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackToEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBackToEdit.Location = new System.Drawing.Point(857, 585);
            this.btnBackToEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToEdit.Name = "btnBackToEdit";
            this.btnBackToEdit.Size = new System.Drawing.Size(113, 36);
            this.btnBackToEdit.TabIndex = 17;
            this.btnBackToEdit.Text = "Back to edit";
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 5;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(762, 585);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 36);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            // 
            // UcNotificationSendStudentAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBackToEdit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.flpNotificationStudent);
            this.Controls.Add(this.lblNotificationStudent);
            this.Controls.Add(this.flpNotificationGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcNotificationSendStudentAll";
            this.Size = new System.Drawing.Size(1056, 633);
            this.flpNotificationGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpNotificationStudent;
        public System.Windows.Forms.Label lblNotificationStudent;
        public TeacherViews.TeacherUserControl.UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle1;
        public System.Windows.Forms.FlowLayoutPanel flpNotificationGroup;
        public Guna.UI2.WinForms.Guna2Button btnBackToEdit;
        public Guna.UI2.WinForms.Guna2Button btnSend;
    }
}
