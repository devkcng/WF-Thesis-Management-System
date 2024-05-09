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
            this.panelContainer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNameTopic = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderColor = System.Drawing.Color.Black;
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.BorderThickness = 2;
            this.panelContainer.Controls.Add(this.guna2CirclePictureBox2);
            this.panelContainer.Controls.Add(this.lblNameGroup);
            this.panelContainer.Controls.Add(this.guna2CirclePictureBox1);
            this.panelContainer.Controls.Add(this.lblNameTopic);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 20);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1113, 226);
            this.panelContainer.TabIndex = 0;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2CirclePictureBox2.Image = global::WFThesisManagementSystem.Properties.Resources.multiple_users_silhouette;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(32, 136);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(54, 47);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 14;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.BackColor = System.Drawing.Color.White;
            this.lblNameGroup.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.Location = new System.Drawing.Point(195, 136);
            this.lblNameGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(167, 47);
            this.lblNameGroup.TabIndex = 11;
            this.lblNameGroup.Text = "Group 1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2CirclePictureBox1.Image = global::WFThesisManagementSystem.Properties.Resources.open_book__3_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(32, 29);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(54, 46);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblNameTopic
            // 
            this.lblNameTopic.AutoSize = true;
            this.lblNameTopic.BackColor = System.Drawing.Color.White;
            this.lblNameTopic.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTopic.Location = new System.Drawing.Point(195, 43);
            this.lblNameTopic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNameTopic.Name = "lblNameTopic";
            this.lblNameTopic.Size = new System.Drawing.Size(412, 47);
            this.lblNameTopic.TabIndex = 12;
            this.lblNameTopic.Text = "cuong kim dep trai @";
            // 
            // UcTeacherSingleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UcTeacherSingleGroup";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.Size = new System.Drawing.Size(1113, 256);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelContainer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblNameGroup;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblNameTopic;
    }
}
