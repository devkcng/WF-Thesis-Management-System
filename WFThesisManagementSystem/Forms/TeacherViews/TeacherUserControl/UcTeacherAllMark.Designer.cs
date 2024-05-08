namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAllMark
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
            this.ucTeacherSingleMark1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherSingleMark();
            this.ucTeacherSubTaskSmall2 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherSubTaskSmall();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cbxStudent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.ucTeacherSingleMark1);
            this.guna2CustomGradientPanel1.Controls.Add(this.ucTeacherSubTaskSmall2);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(31, 167);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1292, 622);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // ucTeacherSingleMark1
            // 
            this.ucTeacherSingleMark1.BackColor = System.Drawing.SystemColors.Control;
            this.ucTeacherSingleMark1.Location = new System.Drawing.Point(723, 5);
            this.ucTeacherSingleMark1.Name = "ucTeacherSingleMark1";
            this.ucTeacherSingleMark1.Size = new System.Drawing.Size(566, 614);
            this.ucTeacherSingleMark1.TabIndex = 1;
            // 
            // ucTeacherSubTaskSmall2
            // 
            this.ucTeacherSubTaskSmall2.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSubTaskSmall2.Name = "ucTeacherSubTaskSmall2";
            this.ucTeacherSubTaskSmall2.Size = new System.Drawing.Size(721, 616);
            this.ucTeacherSubTaskSmall2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(952, 819);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 61);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1146, 819);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 61);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(311, 110);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(97, 32);
            this.lblStudent.TabIndex = 5;
            this.lblStudent.Text = "Student";
            // 
            // cbxStudent
            // 
            this.cbxStudent.BackColor = System.Drawing.Color.Transparent;
            this.cbxStudent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxStudent.ItemHeight = 30;
            this.cbxStudent.Location = new System.Drawing.Point(480, 106);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Size = new System.Drawing.Size(447, 36);
            this.cbxStudent.TabIndex = 7;
            this.cbxStudent.SelectedIndexChanged += new System.EventHandler(this.cbxStudent_SelectedIndexChanged);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(633, 12);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(95, 37);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Mark";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(311, 55);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(129, 32);
            this.lblTaskName.TabIndex = 8;
            this.lblTaskName.Text = "Task Name";
            // 
            // UcTeacherAllMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.cbxStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.lblMark);
            this.Name = "UcTeacherAllMark";
            this.Size = new System.Drawing.Size(1349, 896);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblStudent;
        public  Guna.UI2.WinForms.Guna2ComboBox cbxStudent;
        private System.Windows.Forms.Label lblMark;
        public System.Windows.Forms.Label lblTaskName;
        public  UcTeacherSubTaskSmall ucTeacherSubTaskSmall2;
        public UcTeacherSingleMark ucTeacherSingleMark1;
    }
}
