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
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSubmitTask = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.txtProjectDetail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BorderColor = System.Drawing.Color.Black;
            this.panelTask.BorderRadius = 10;
            this.panelTask.BorderThickness = 2;
            this.panelTask.Controls.Add(this.btnEdit);
            this.panelTask.Controls.Add(this.lblOpenDay);
            this.panelTask.Controls.Add(this.lblDeadline);
            this.panelTask.Controls.Add(this.ptbStatus);
            this.panelTask.Controls.Add(this.lblSubmitTask);
            this.panelTask.Controls.Add(this.lblDueDate);
            this.panelTask.Controls.Add(this.lblOpenDate);
            this.panelTask.Controls.Add(this.txtProjectDetail);
            this.panelTask.Controls.Add(this.lblName);
            this.panelTask.CustomBorderColor = System.Drawing.Color.Black;
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTask.Location = new System.Drawing.Point(2, 2);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1335, 318);
            this.panelTask.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::WFThesisManagementSystem.Properties.Resources.Chat;
            this.btnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Location = new System.Drawing.Point(1163, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 102);
            this.btnEdit.TabIndex = 78;
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.BackColor = System.Drawing.Color.White;
            this.lblOpenDay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOpenDay.Location = new System.Drawing.Point(217, 260);
            this.lblOpenDay.Name = "lblOpenDay";
            this.lblOpenDay.Size = new System.Drawing.Size(164, 46);
            this.lblOpenDay.TabIndex = 77;
            this.lblOpenDay.Text = "3/4/2024";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.White;
            this.lblDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.Red;
            this.lblDeadline.Location = new System.Drawing.Point(600, 260);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(164, 46);
            this.lblDeadline.TabIndex = 76;
            this.lblDeadline.Text = "5/4/2024";
            // 
            // ptbStatus
            // 
            this.ptbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbStatus.BackColor = System.Drawing.Color.White;
            this.ptbStatus.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ptbStatus.ImageRotate = 0F;
            this.ptbStatus.Location = new System.Drawing.Point(1251, 260);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbStatus.Size = new System.Drawing.Size(50, 43);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStatus.TabIndex = 75;
            this.ptbStatus.TabStop = false;
            // 
            // lblSubmitTask
            // 
            this.lblSubmitTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubmitTask.AutoSize = true;
            this.lblSubmitTask.BackColor = System.Drawing.Color.White;
            this.lblSubmitTask.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTask.Location = new System.Drawing.Point(1128, 260);
            this.lblSubmitTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubmitTask.Name = "lblSubmitTask";
            this.lblSubmitTask.Size = new System.Drawing.Size(115, 46);
            this.lblSubmitTask.TabIndex = 74;
            this.lblSubmitTask.Text = "Status";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.White;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(429, 260);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(163, 46);
            this.lblDueDate.TabIndex = 73;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.BackColor = System.Drawing.Color.White;
            this.lblOpenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(37, 260);
            this.lblOpenDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(172, 46);
            this.lblOpenDate.TabIndex = 72;
            this.lblOpenDate.Text = "Open Day";
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
            this.txtProjectDetail.Location = new System.Drawing.Point(44, 99);
            this.txtProjectDetail.Margin = new System.Windows.Forms.Padding(5);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.ReadOnly = true;
            this.txtProjectDetail.Size = new System.Drawing.Size(1257, 136);
            this.txtProjectDetail.TabIndex = 71;
            this.txtProjectDetail.Text = "Project Detail: cjavebvveve";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(820, 62);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // UCTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTask);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCTask";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(1339, 322);
            this.Click += new System.EventHandler(this.UCTask_CLick);
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTask;
        public Guna.UI2.WinForms.Guna2Button btnEdit;
        public System.Windows.Forms.Label lblOpenDay;
        public System.Windows.Forms.Label lblDeadline;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        private System.Windows.Forms.Label lblSubmitTask;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOpenDate;
        public System.Windows.Forms.TextBox txtProjectDetail;
        public System.Windows.Forms.Label lblName;
    }
}
