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
            this.lblNameTopic = new System.Windows.Forms.Label();
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.spl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.spl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameTopic
            // 
            this.lblNameTopic.AutoSize = true;
            this.lblNameTopic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTopic.Location = new System.Drawing.Point(139, 27);
            this.lblNameTopic.Name = "lblNameTopic";
            this.lblNameTopic.Size = new System.Drawing.Size(216, 28);
            this.lblNameTopic.TabIndex = 7;
            this.lblNameTopic.Text = "cuong kim dep trai @";
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.Location = new System.Drawing.Point(139, 87);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(84, 28);
            this.lblNameGroup.TabIndex = 6;
            this.lblNameGroup.Text = "Group 1";
            // 
            // spl
            // 
            this.spl.BackColor = System.Drawing.Color.Transparent;
            this.spl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spl.Controls.Add(this.guna2CirclePictureBox2);
            this.spl.Controls.Add(this.lblNameGroup);
            this.spl.Controls.Add(this.guna2CirclePictureBox1);
            this.spl.Controls.Add(this.lblNameTopic);
            this.spl.FillColor = System.Drawing.Color.White;
            this.spl.Location = new System.Drawing.Point(0, 0);
            this.spl.Name = "spl";
            this.spl.ShadowColor = System.Drawing.Color.Black;
            this.spl.Size = new System.Drawing.Size(626, 150);
            this.spl.TabIndex = 12;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::WFThesisManagementSystem.Properties.Resources.multiple_users_silhouette;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(47, 87);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2CirclePictureBox2.TabIndex = 10;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WFThesisManagementSystem.Properties.Resources.open_book__3_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(47, 27);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UcTeacherSingleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spl);
            this.Name = "UcTeacherSingleGroup";
            this.Size = new System.Drawing.Size(626, 150);
            this.spl.ResumeLayout(false);
            this.spl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblNameTopic;
        private System.Windows.Forms.Label lblNameGroup;
        private Guna.UI2.WinForms.Guna2ShadowPanel spl;
    }
}
