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
            this.sdpsingletask = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtProjectDetail = new System.Windows.Forms.TextBox();
            this.lblSubmitTask = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.sdpsingletask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // sdpsingletask
            // 
            this.sdpsingletask.BackColor = System.Drawing.Color.Transparent;
            this.sdpsingletask.Controls.Add(this.btnSubmit);
            this.sdpsingletask.Controls.Add(this.lblOpenDay);
            this.sdpsingletask.Controls.Add(this.lblDeadline);
            this.sdpsingletask.Controls.Add(this.ptbStatus);
            this.sdpsingletask.Controls.Add(this.txtProjectDetail);
            this.sdpsingletask.Controls.Add(this.lblSubmitTask);
            this.sdpsingletask.Controls.Add(this.lblDueDate);
            this.sdpsingletask.Controls.Add(this.lblOpenDate);
            this.sdpsingletask.Controls.Add(this.btnChat);
            this.sdpsingletask.Controls.Add(this.lblName);
            this.sdpsingletask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdpsingletask.FillColor = System.Drawing.Color.White;
            this.sdpsingletask.Location = new System.Drawing.Point(0, 0);
            this.sdpsingletask.Margin = new System.Windows.Forms.Padding(5);
            this.sdpsingletask.Name = "sdpsingletask";
            this.sdpsingletask.Radius = 10;
            this.sdpsingletask.ShadowColor = System.Drawing.Color.Black;
            this.sdpsingletask.Size = new System.Drawing.Size(1410, 322);
            this.sdpsingletask.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.BorderRadius = 10;
            this.btnSubmit.BorderThickness = 3;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1164, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(243, 89);
            this.btnSubmit.TabIndex = 63;
            this.btnSubmit.Text = "SUBMIT";
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOpenDay.Location = new System.Drawing.Point(193, 266);
            this.lblOpenDay.Name = "lblOpenDay";
            this.lblOpenDay.Size = new System.Drawing.Size(164, 46);
            this.lblOpenDay.TabIndex = 62;
            this.lblOpenDay.Text = "3/4/2024";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.Red;
            this.lblDeadline.Location = new System.Drawing.Point(634, 266);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(164, 46);
            this.lblDeadline.TabIndex = 61;
            this.lblDeadline.Text = "5/4/2024";
            // 
            // ptbStatus
            // 
            this.ptbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbStatus.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ptbStatus.ImageRotate = 0F;
            this.ptbStatus.Location = new System.Drawing.Point(1006, 269);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbStatus.Size = new System.Drawing.Size(50, 43);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStatus.TabIndex = 60;
            this.ptbStatus.TabStop = false;
            // 
            // txtProjectDetail
            // 
            this.txtProjectDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectDetail.BackColor = System.Drawing.Color.White;
            this.txtProjectDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtProjectDetail.ForeColor = System.Drawing.Color.Silver;
            this.txtProjectDetail.Location = new System.Drawing.Point(21, 93);
            this.txtProjectDetail.Margin = new System.Windows.Forms.Padding(5);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.ReadOnly = true;
            this.txtProjectDetail.Size = new System.Drawing.Size(1356, 135);
            this.txtProjectDetail.TabIndex = 58;
            this.txtProjectDetail.Text = "Project Detail: cjavebvveve";
            // 
            // lblSubmitTask
            // 
            this.lblSubmitTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubmitTask.AutoSize = true;
            this.lblSubmitTask.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTask.Location = new System.Drawing.Point(883, 266);
            this.lblSubmitTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubmitTask.Name = "lblSubmitTask";
            this.lblSubmitTask.Size = new System.Drawing.Size(115, 46);
            this.lblSubmitTask.TabIndex = 21;
            this.lblSubmitTask.Text = "Status";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(449, 266);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(163, 46);
            this.lblDueDate.TabIndex = 20;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(13, 266);
            this.lblOpenDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(172, 46);
            this.lblOpenDate.TabIndex = 19;
            this.lblOpenDate.Text = "Open Day";
            // 
            // btnChat
            // 
            this.btnChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChat.FillColor = System.Drawing.Color.Transparent;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat;
            this.btnChat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChat.Location = new System.Drawing.Point(1249, 0);
            this.btnChat.Margin = new System.Windows.Forms.Padding(5);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(128, 119);
            this.btnChat.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(820, 62);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // UCInvidualTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdpsingletask);
            this.Name = "UCInvidualTask";
            this.Size = new System.Drawing.Size(1410, 322);
            this.sdpsingletask.ResumeLayout(false);
            this.sdpsingletask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel sdpsingletask;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        public System.Windows.Forms.Label lblOpenDay;
        public System.Windows.Forms.Label lblDeadline;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        public System.Windows.Forms.TextBox txtProjectDetail;
        private System.Windows.Forms.Label lblSubmitTask;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOpenDate;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        public System.Windows.Forms.Label lblName;
    }
}
