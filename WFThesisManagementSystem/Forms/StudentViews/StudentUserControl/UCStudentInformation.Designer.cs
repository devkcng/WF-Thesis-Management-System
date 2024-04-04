namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCStudentInformation
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblName);
            this.guna2ShadowPanel1.Controls.Add(this.ptbAvatar);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(925, 163);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(336, 56);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(385, 62);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Nguyen Gia Huy";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Image = global::WFThesisManagementSystem.Properties.Resources.kien;
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(34, 14);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAvatar.Size = new System.Drawing.Size(160, 135);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 65;
            this.ptbAvatar.TabStop = false;
            // 
            // UCStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UCStudentInformation";
            this.Size = new System.Drawing.Size(925, 163);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbAvatar;
    }
}
