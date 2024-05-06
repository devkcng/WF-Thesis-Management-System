namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCInvidualTask
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
            this.panelTask = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtProjectDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChat = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BorderColor = System.Drawing.Color.Black;
            this.panelTask.BorderRadius = 10;
            this.panelTask.BorderThickness = 2;
            this.panelTask.Controls.Add(this.btnSubmit);
            this.panelTask.Controls.Add(this.txtProjectDetail);
            this.panelTask.Controls.Add(this.btnChat);
            this.panelTask.Controls.Add(this.lblDeadline);
            this.panelTask.Controls.Add(this.ptbStatus);
            this.panelTask.Controls.Add(this.lblStatus);
            this.panelTask.Controls.Add(this.lblDueDate);
            this.panelTask.Controls.Add(this.lblName);
            this.panelTask.CustomBorderColor = System.Drawing.Color.Black;
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTask.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTask.Location = new System.Drawing.Point(10, 20);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1222, 282);
            this.panelTask.TabIndex = 1;
            // 
            // txtProjectDetail
            // 
            this.txtProjectDetail.BorderThickness = 0;
            this.txtProjectDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectDetail.DefaultText = "";
            this.txtProjectDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectDetail.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtProjectDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectDetail.Location = new System.Drawing.Point(7, 81);
            this.txtProjectDetail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtProjectDetail.MaximumSize = new System.Drawing.Size(1150, 150);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.PasswordChar = '\0';
            this.txtProjectDetail.PlaceholderText = "";
            this.txtProjectDetail.ReadOnly = true;
            this.txtProjectDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectDetail.SelectedText = "";
            this.txtProjectDetail.Size = new System.Drawing.Size(1150, 131);
            this.txtProjectDetail.TabIndex = 81;
            // 
            // btnChat
            // 
            this.btnChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChat.BackColor = System.Drawing.Color.White;
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat1;
            this.btnChat.ImageRotate = 0F;
            this.btnChat.Location = new System.Drawing.Point(1139, 19);
            this.btnChat.Name = "btnChat";
            this.btnChat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChat.Size = new System.Drawing.Size(50, 55);
            this.btnChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChat.TabIndex = 80;
            this.btnChat.TabStop = false;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.White;
            this.lblDeadline.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.Red;
            this.lblDeadline.Location = new System.Drawing.Point(207, 222);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(171, 40);
            this.lblDeadline.TabIndex = 76;
            this.lblDeadline.Text = "5/4/2024";
            // 
            // ptbStatus
            // 
            this.ptbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbStatus.BackColor = System.Drawing.Color.White;
            this.ptbStatus.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ptbStatus.ImageRotate = 0F;
            this.ptbStatus.Location = new System.Drawing.Point(608, 222);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbStatus.Size = new System.Drawing.Size(36, 33);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStatus.TabIndex = 75;
            this.ptbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(494, 222);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 40);
            this.lblStatus.TabIndex = 74;
            this.lblStatus.Text = "Status";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.White;
            this.lblDueDate.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(36, 222);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(158, 40);
            this.lblDueDate.TabIndex = 73;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Cambria", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 19);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(791, 55);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.BorderRadius = 2;
            this.btnSubmit.BorderThickness = 3;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(877, 209);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 53);
            this.btnSubmit.TabIndex = 85;
            this.btnSubmit.Text = "SUBMIT";
            // 
            // UCInvidualTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTask);
            this.Name = "UCInvidualTask";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.Size = new System.Drawing.Size(1242, 322);
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTask;
        public Guna.UI2.WinForms.Guna2TextBox txtProjectDetail;
        public Guna.UI2.WinForms.Guna2CirclePictureBox btnChat;
        public System.Windows.Forms.Label lblDeadline;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
    }
}
