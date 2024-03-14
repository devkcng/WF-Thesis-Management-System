namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcMenutop
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblAddress);
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Controls.Add(this.btnImage);
            this.guna2Panel1.Location = new System.Drawing.Point(980, 18);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(207, 39);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(25, 19);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 21);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "KH.VietNam";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Mai Duc Kien";
            // 
            // btnImage
            // 
            this.btnImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImage.FillColor = System.Drawing.Color.Transparent;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Image = global::WFThesisManagementSystem.Properties.Resources.kien;
            this.btnImage.ImageSize = new System.Drawing.Size(40, 40);
            this.btnImage.Location = new System.Drawing.Point(139, -9);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(50, 49);
            this.btnImage.TabIndex = 4;
            // 
            // btnNotification
            // 
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.Color.Transparent;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = global::WFThesisManagementSystem.Properties.Resources.bell;
            this.btnNotification.Location = new System.Drawing.Point(919, 18);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(41, 35);
            this.btnNotification.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::WFThesisManagementSystem.Properties.Resources.list;
            this.btnMenu.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMenu.Location = new System.Drawing.Point(12, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(93, 74);
            this.btnMenu.TabIndex = 0;
            // 
            // UcMenutop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.btnMenu);
            this.Name = "UcMenutop";
            this.Size = new System.Drawing.Size(1867, 90);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnImage;
    }
}
