namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCTask
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
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChat = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtProjectDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BorderColor = System.Drawing.Color.Black;
            this.panelTask.BorderRadius = 10;
            this.panelTask.BorderThickness = 2;
            this.panelTask.Controls.Add(this.txtProjectDetail);
            this.panelTask.Controls.Add(this.btnChat);
            this.panelTask.Controls.Add(this.lblOpenDay);
            this.panelTask.Controls.Add(this.lblDeadline);
            this.panelTask.Controls.Add(this.ptbStatus);
            this.panelTask.Controls.Add(this.lblStatus);
            this.panelTask.Controls.Add(this.lblDueDate);
            this.panelTask.Controls.Add(this.lblOpenDate);
            this.panelTask.Controls.Add(this.lblName);
            this.panelTask.CustomBorderColor = System.Drawing.Color.Black;
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTask.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTask.Location = new System.Drawing.Point(10, 20);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1319, 310);
            this.panelTask.TabIndex = 0;
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.BackColor = System.Drawing.Color.White;
            this.lblOpenDay.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDay.Location = new System.Drawing.Point(217, 252);
            this.lblOpenDay.Name = "lblOpenDay";
            this.lblOpenDay.Size = new System.Drawing.Size(171, 40);
            this.lblOpenDay.TabIndex = 77;
            this.lblOpenDay.Text = "3/4/2024";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.White;
            this.lblDeadline.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.Red;
            this.lblDeadline.Location = new System.Drawing.Point(642, 252);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(171, 40);
            this.lblDeadline.TabIndex = 76;
            this.lblDeadline.Text = "5/4/2024";
            // 
            // ptbStatus
            // 
            this.ptbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbStatus.BackColor = System.Drawing.Color.White;
            this.ptbStatus.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ptbStatus.ImageRotate = 0F;
            this.ptbStatus.Location = new System.Drawing.Point(1226, 252);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbStatus.Size = new System.Drawing.Size(36, 33);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStatus.TabIndex = 75;
            this.ptbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1112, 252);
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
            this.lblDueDate.Location = new System.Drawing.Point(471, 252);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(158, 40);
            this.lblDueDate.TabIndex = 73;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.BackColor = System.Drawing.Color.White;
            this.lblOpenDate.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(37, 252);
            this.lblOpenDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(166, 40);
            this.lblOpenDate.TabIndex = 72;
            this.lblOpenDate.Text = "Open Day";
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
            // btnChat
            // 
            this.btnChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChat.BackColor = System.Drawing.Color.White;
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat1;
            this.btnChat.ImageRotate = 0F;
            this.btnChat.Location = new System.Drawing.Point(1236, 19);
            this.btnChat.Name = "btnChat";
            this.btnChat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChat.Size = new System.Drawing.Size(50, 55);
            this.btnChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChat.TabIndex = 80;
            this.btnChat.TabStop = false;
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
            this.txtProjectDetail.Location = new System.Drawing.Point(44, 84);
            this.txtProjectDetail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtProjectDetail.MaximumSize = new System.Drawing.Size(1200, 150);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.PasswordChar = '\0';
            this.txtProjectDetail.PlaceholderText = "";
            this.txtProjectDetail.ReadOnly = true;
            this.txtProjectDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectDetail.SelectedText = "";
            this.txtProjectDetail.Size = new System.Drawing.Size(1200, 147);
            this.txtProjectDetail.TabIndex = 81;
            // 
            // UCTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTask);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCTask";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.Size = new System.Drawing.Size(1339, 350);
            this.Click += new System.EventHandler(this.UCTask_CLick);
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTask;
        public System.Windows.Forms.Label lblOpenDay;
        public System.Windows.Forms.Label lblDeadline;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        public System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2CirclePictureBox btnChat;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblOpenDate;
        public System.Windows.Forms.Label lblStatus;
        public Guna.UI2.WinForms.Guna2TextBox txtProjectDetail;
    }
}
