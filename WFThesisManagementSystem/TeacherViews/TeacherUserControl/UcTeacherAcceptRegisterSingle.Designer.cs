namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAcceptRegisterSingle
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
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.lblIdStudent = new System.Windows.Forms.Label();
            this.cbxRegist = new System.Windows.Forms.CheckBox();
            this.lblRegist = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStudent.Location = new System.Drawing.Point(96, 32);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(140, 28);
            this.lblNameStudent.TabIndex = 0;
            this.lblNameStudent.Text = "Mai Đức Kiên";
            // 
            // lblIdStudent
            // 
            this.lblIdStudent.AutoSize = true;
            this.lblIdStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdStudent.Location = new System.Drawing.Point(96, 97);
            this.lblIdStudent.Name = "lblIdStudent";
            this.lblIdStudent.Size = new System.Drawing.Size(100, 28);
            this.lblIdStudent.TabIndex = 1;
            this.lblIdStudent.Text = "22110046";
            // 
            // cbxRegist
            // 
            this.cbxRegist.AutoSize = true;
            this.cbxRegist.Location = new System.Drawing.Point(357, 71);
            this.cbxRegist.Name = "cbxRegist";
            this.cbxRegist.Size = new System.Drawing.Size(22, 21);
            this.cbxRegist.TabIndex = 2;
            this.cbxRegist.UseVisualStyleBackColor = true;
            // 
            // lblRegist
            // 
            this.lblRegist.AutoSize = true;
            this.lblRegist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegist.Location = new System.Drawing.Point(399, 64);
            this.lblRegist.Name = "lblRegist";
            this.lblRegist.Size = new System.Drawing.Size(111, 28);
            this.lblRegist.TabIndex = 5;
            this.lblRegist.Text = "Đã đăng ký";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::WFThesisManagementSystem.Properties.Resources.Badge;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(24, 86);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(48, 48);
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WFThesisManagementSystem.Properties.Resources.Student_Male1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(23, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(49, 58);
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UcTeacherAcceptRegisterSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblRegist);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.cbxRegist);
            this.Controls.Add(this.lblIdStudent);
            this.Controls.Add(this.lblNameStudent);
            this.Name = "UcTeacherAcceptRegisterSingle";
            this.Size = new System.Drawing.Size(626, 150);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.Label lblIdStudent;
        private System.Windows.Forms.CheckBox cbxRegist;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblRegist;
    }
}
