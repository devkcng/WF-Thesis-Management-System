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
            this.panelContainer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.BorderThickness = 2;
            this.panelContainer.Controls.Add(this.lblName);
            this.panelContainer.Controls.Add(this.ptbAvatar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(715, 158);
            this.panelContainer.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(188, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(385, 62);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Nguyen Gia Huy";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.White;
            this.ptbAvatar.Image = global::WFThesisManagementSystem.Properties.Resources.kien;
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(16, 17);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAvatar.Size = new System.Drawing.Size(122, 121);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 67;
            this.ptbAvatar.TabStop = false;
            // 
            // UCStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCStudentInformation";
            this.Size = new System.Drawing.Size(715, 158);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelContainer;
        public System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbAvatar;
    }
}
