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
            this.lblCheck = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.cpxStudent = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpxStudent)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(686, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Mai Đức Kiên";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(686, 14);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(123, 28);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "Hoàn thành";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderRadius = 3;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1018, 205);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel3.BorderThickness = 2;
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMark);
            this.guna2CustomGradientPanel3.Controls.Add(this.lblName);
            this.guna2CustomGradientPanel3.Controls.Add(this.lblTaskDescription);
            this.guna2CustomGradientPanel3.Controls.Add(this.cpxStudent);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Moccasin;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(41, 83);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(917, 106);
            this.guna2CustomGradientPanel3.TabIndex = 12;
            // 
            // txtMark
            // 
            this.txtMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMark.DefaultText = "";
            this.txtMark.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMark.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Location = new System.Drawing.Point(519, 22);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMark.Name = "txtMark";
            this.txtMark.PasswordChar = '\0';
            this.txtMark.PlaceholderText = "";
            this.txtMark.SelectedText = "";
            this.txtMark.Size = new System.Drawing.Size(120, 52);
            this.txtMark.TabIndex = 10;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskDescription.Location = new System.Drawing.Point(16, 33);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(142, 28);
            this.lblTaskDescription.TabIndex = 9;
            this.lblTaskDescription.Text = "Description";
            // 
            // cpxStudent
            // 
            this.cpxStudent.Image = global::WFThesisManagementSystem.Properties.Resources.Student_Male;
            this.cpxStudent.ImageRotate = 0F;
            this.cpxStudent.Location = new System.Drawing.Point(843, 22);
            this.cpxStudent.Name = "cpxStudent";
            this.cpxStudent.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpxStudent.Size = new System.Drawing.Size(51, 52);
            this.cpxStudent.TabIndex = 2;
            this.cpxStudent.TabStop = false;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTaskName);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnEdit);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblCheck);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(41, 11);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(917, 53);
            this.guna2CustomGradientPanel2.TabIndex = 11;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(14, 10);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(144, 33);
            this.lblTaskName.TabIndex = 8;
            this.lblTaskName.Text = "Nhiệm vụ ";
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::WFThesisManagementSystem.Properties.Resources.Edit;
            this.btnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Location = new System.Drawing.Point(843, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UcTeacherSingleMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UcTeacherSingleMark";
            this.Size = new System.Drawing.Size(1018, 238);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpxStudent)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCheck;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpxStudent;
        public Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public System.Windows.Forms.Label lblTaskDescription;
        public System.Windows.Forms.Label lblTaskName;
        public Guna.UI2.WinForms.Guna2TextBox txtMark;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
    }
}
