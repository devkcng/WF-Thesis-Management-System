namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCSubTasks
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
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BorderColor = System.Drawing.Color.Black;
            this.panelTask.BorderRadius = 10;
            this.panelTask.BorderThickness = 2;
            this.panelTask.Controls.Add(this.lblMember);
            this.panelTask.Controls.Add(this.label1);
            this.panelTask.Controls.Add(this.txtProjectDetail);
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
            this.panelTask.Size = new System.Drawing.Size(1554, 282);
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
            this.txtProjectDetail.Location = new System.Drawing.Point(18, 81);
            this.txtProjectDetail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtProjectDetail.MaximumSize = new System.Drawing.Size(1500, 150);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.PasswordChar = '\0';
            this.txtProjectDetail.PlaceholderText = "";
            this.txtProjectDetail.ReadOnly = true;
            this.txtProjectDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectDetail.SelectedText = "";
            this.txtProjectDetail.Size = new System.Drawing.Size(1500, 138);
            this.txtProjectDetail.TabIndex = 81;
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.BackColor = System.Drawing.Color.White;
            this.lblOpenDay.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDay.Location = new System.Drawing.Point(217, 224);
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
            this.lblDeadline.Location = new System.Drawing.Point(642, 224);
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
            this.ptbStatus.Location = new System.Drawing.Point(1461, 224);
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
            this.lblStatus.Location = new System.Drawing.Point(1347, 224);
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
            this.lblDueDate.Location = new System.Drawing.Point(471, 224);
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
            this.lblOpenDate.Location = new System.Drawing.Point(37, 224);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1166, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 40);
            this.label1.TabIndex = 82;
            this.label1.Text = "Member";
            // 
            // lblMember
            // 
            this.lblMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMember.AutoSize = true;
            this.lblMember.BackColor = System.Drawing.Color.White;
            this.lblMember.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(1324, 19);
            this.lblMember.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(135, 40);
            this.lblMember.TabIndex = 83;
            this.lblMember.Text = "Member";
            // 
            // UCSubTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTask);
            this.Name = "UCSubTasks";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.Size = new System.Drawing.Size(1574, 322);
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTask;
        public Guna.UI2.WinForms.Guna2TextBox txtProjectDetail;
        public System.Windows.Forms.Label lblOpenDay;
        public System.Windows.Forms.Label lblDeadline;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblOpenDate;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblMember;
        public System.Windows.Forms.Label label1;
    }
}
