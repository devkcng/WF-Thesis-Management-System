namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherSingleMark
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
            this.lblTurnIn = new System.Windows.Forms.Label();
            this.txtMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxCheckTurnIn = new System.Windows.Forms.CheckBox();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.cpxStudent = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cxbCheckStudent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(216, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Mai Đức Kiên";
            // 
            // lblTurnIn
            // 
            this.lblTurnIn.AutoSize = true;
            this.lblTurnIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnIn.Location = new System.Drawing.Point(429, 42);
            this.lblTurnIn.Name = "lblTurnIn";
            this.lblTurnIn.Size = new System.Drawing.Size(72, 28);
            this.lblTurnIn.TabIndex = 1;
            this.lblTurnIn.Text = "Turn in";
            // 
            // txtMark
            // 
            this.txtMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMark.DefaultText = "";
            this.txtMark.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.FillColor = System.Drawing.Color.DarkGray;
            this.txtMark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMark.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Location = new System.Drawing.Point(839, 32);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMark.Name = "txtMark";
            this.txtMark.PasswordChar = '\0';
            this.txtMark.PlaceholderText = "";
            this.txtMark.SelectedText = "";
            this.txtMark.Size = new System.Drawing.Size(49, 45);
            this.txtMark.TabIndex = 4;
            // 
            // cbxCheckTurnIn
            // 
            this.cbxCheckTurnIn.AutoSize = true;
            this.cbxCheckTurnIn.Location = new System.Drawing.Point(385, 43);
            this.cbxCheckTurnIn.Name = "cbxCheckTurnIn";
            this.cbxCheckTurnIn.Size = new System.Drawing.Size(22, 21);
            this.cbxCheckTurnIn.TabIndex = 6;
            this.cbxCheckTurnIn.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChat.FillColor = System.Drawing.Color.Transparent;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat1;
            this.btnChat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChat.Location = new System.Drawing.Point(696, 32);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(40, 40);
            this.btnChat.TabIndex = 3;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // cpxStudent
            // 
            this.cpxStudent.Image = global::WFThesisManagementSystem.Properties.Resources.Student_Male;
            this.cpxStudent.ImageRotate = 0F;
            this.cpxStudent.Location = new System.Drawing.Point(129, 25);
            this.cpxStudent.Name = "cpxStudent";
            this.cpxStudent.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpxStudent.Size = new System.Drawing.Size(51, 52);
            this.cpxStudent.TabIndex = 2;
            this.cpxStudent.TabStop = false;
            // 
            // cxbCheckStudent
            // 
            this.cxbCheckStudent.AutoSize = true;
            this.cxbCheckStudent.Location = new System.Drawing.Point(49, 43);
            this.cxbCheckStudent.Name = "cxbCheckStudent";
            this.cxbCheckStudent.Size = new System.Drawing.Size(22, 21);
            this.cxbCheckStudent.TabIndex = 7;
            this.cxbCheckStudent.UseVisualStyleBackColor = true;
            // 
            // UcTeacherSingleMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cxbCheckStudent);
            this.Controls.Add(this.cbxCheckTurnIn);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.cpxStudent);
            this.Controls.Add(this.lblTurnIn);
            this.Controls.Add(this.lblName);
            this.Name = "UcTeacherSingleMark";
            this.Size = new System.Drawing.Size(939, 108);
            ((System.ComponentModel.ISupportInitialize)(this.cpxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTurnIn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpxStudent;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        private Guna.UI2.WinForms.Guna2TextBox txtMark;
        private System.Windows.Forms.CheckBox cbxCheckTurnIn;
        private System.Windows.Forms.CheckBox cxbCheckStudent;
    }
}
