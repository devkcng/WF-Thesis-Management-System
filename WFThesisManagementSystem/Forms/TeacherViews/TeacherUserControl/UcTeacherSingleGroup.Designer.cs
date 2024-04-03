namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherSingleGroup
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
            this.lblIdGroup = new System.Windows.Forms.Label();
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTaskGroup = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdGroup
            // 
            this.lblIdGroup.AutoSize = true;
            this.lblIdGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGroup.Location = new System.Drawing.Point(143, 94);
            this.lblIdGroup.Name = "lblIdGroup";
            this.lblIdGroup.Size = new System.Drawing.Size(34, 28);
            this.lblIdGroup.TabIndex = 7;
            this.lblIdGroup.Text = "01";
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.Location = new System.Drawing.Point(143, 29);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(88, 28);
            this.lblNameGroup.TabIndex = 6;
            this.lblNameGroup.Text = "Group 1";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::WFThesisManagementSystem.Properties.Resources.Badge;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(71, 83);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(48, 48);
            this.guna2CirclePictureBox2.TabIndex = 10;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WFThesisManagementSystem.Properties.Resources.Student_Male1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(70, 19);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(49, 58);
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnTaskGroup
            // 
            this.btnTaskGroup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskGroup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskGroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskGroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskGroup.FillColor = System.Drawing.Color.Transparent;
            this.btnTaskGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskGroup.ForeColor = System.Drawing.Color.White;
            this.btnTaskGroup.Image = global::WFThesisManagementSystem.Properties.Resources.Chat1;
            this.btnTaskGroup.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTaskGroup.Location = new System.Drawing.Point(497, 53);
            this.btnTaskGroup.Name = "btnTaskGroup";
            this.btnTaskGroup.Size = new System.Drawing.Size(40, 40);
            this.btnTaskGroup.TabIndex = 11;
            // 
            // UcSingleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTaskGroup);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lblIdGroup);
            this.Controls.Add(this.lblNameGroup);
            this.Name = "UcSingleGroup";
            this.Size = new System.Drawing.Size(626, 150);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblIdGroup;
        private System.Windows.Forms.Label lblNameGroup;
        private Guna.UI2.WinForms.Guna2Button btnTaskGroup;
    }
}
