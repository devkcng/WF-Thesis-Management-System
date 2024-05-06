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
            this.flpAllStudentMark = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMark = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucTeacherSingleMark1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherSingleMark();
            this.flpAllStudentMark.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAllStudentMark
            // 
            this.flpAllStudentMark.AutoScroll = true;
            this.flpAllStudentMark.Controls.Add(this.ucTeacherSingleMark1);
            this.flpAllStudentMark.Location = new System.Drawing.Point(24, 13);
            this.flpAllStudentMark.Name = "flpAllStudentMark";
            this.flpAllStudentMark.Size = new System.Drawing.Size(1038, 699);
            this.flpAllStudentMark.TabIndex = 0;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(31, 40);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(95, 37);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Mark";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.flpAllStudentMark);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(27, 95);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1096, 743);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(777, 876);
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
            this.btnClose.Location = new System.Drawing.Point(995, 876);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 61);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            // 
            // ucTeacherSingleMark1
            // 
            this.ucTeacherSingleMark1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherSingleMark1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleMark1.Name = "ucTeacherSingleMark1";
            this.ucTeacherSingleMark1.NameTask = null;
            this.ucTeacherSingleMark1.Size = new System.Drawing.Size(1018, 238);
            this.ucTeacherSingleMark1.TabIndex = 0;
            // 
            // UcTeacherAllMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.lblMark);
            this.Name = "UcTeacherAllMark";
            this.Size = new System.Drawing.Size(1584, 978);
            this.flpAllStudentMark.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpAllStudentMark;
        public UcTeacherSingleMark ucTeacherSingleMark1;
        private System.Windows.Forms.Label lblMark;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
