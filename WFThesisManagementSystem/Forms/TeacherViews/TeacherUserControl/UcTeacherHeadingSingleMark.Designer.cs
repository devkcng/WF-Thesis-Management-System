namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherHeadingSingleMark
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.cbxCheckStudent = new System.Windows.Forms.CheckBox();
            this.btnDownName = new Guna.UI2.WinForms.Guna2Button();
            this.btnDownStatus = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(204, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(418, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBack.Location = new System.Drawing.Point(626, 39);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(86, 25);
            this.lblFeedBack.TabIndex = 2;
            this.lblFeedBack.Text = "FeedBack";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(814, 32);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(47, 28);
            this.lblMark.TabIndex = 3;
            this.lblMark.Text = " /10";
            // 
            // cbxCheckStudent
            // 
            this.cbxCheckStudent.AutoSize = true;
            this.cbxCheckStudent.Location = new System.Drawing.Point(86, 39);
            this.cbxCheckStudent.Name = "cbxCheckStudent";
            this.cbxCheckStudent.Size = new System.Drawing.Size(22, 21);
            this.cbxCheckStudent.TabIndex = 4;
            this.cbxCheckStudent.UseVisualStyleBackColor = true;
            // 
            // btnDownName
            // 
            this.btnDownName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownName.FillColor = System.Drawing.Color.Transparent;
            this.btnDownName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownName.ForeColor = System.Drawing.Color.White;
            this.btnDownName.Image = global::WFThesisManagementSystem.Properties.Resources.Down_Arrow1;
            this.btnDownName.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDownName.Location = new System.Drawing.Point(269, 39);
            this.btnDownName.Name = "btnDownName";
            this.btnDownName.Size = new System.Drawing.Size(39, 32);
            this.btnDownName.TabIndex = 8;
            // 
            // btnDownStatus
            // 
            this.btnDownStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownStatus.FillColor = System.Drawing.Color.Transparent;
            this.btnDownStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownStatus.ForeColor = System.Drawing.Color.White;
            this.btnDownStatus.Image = global::WFThesisManagementSystem.Properties.Resources.Down_Arrow1;
            this.btnDownStatus.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDownStatus.Location = new System.Drawing.Point(484, 39);
            this.btnDownStatus.Name = "btnDownStatus";
            this.btnDownStatus.Size = new System.Drawing.Size(39, 32);
            this.btnDownStatus.TabIndex = 9;
            // 
            // UcTeacherHeadingSingleMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDownStatus);
            this.Controls.Add(this.btnDownName);
            this.Controls.Add(this.cbxCheckStudent);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Name = "UcTeacherHeadingSingleMark";
            this.Size = new System.Drawing.Size(914, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFeedBack;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.CheckBox cbxCheckStudent;
        private Guna.UI2.WinForms.Guna2Button btnDownName;
        private Guna.UI2.WinForms.Guna2Button btnDownStatus;
    }
}
