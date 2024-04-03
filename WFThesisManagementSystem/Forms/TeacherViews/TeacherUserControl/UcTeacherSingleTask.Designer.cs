namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherSingleTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTeacherSingleTask));
            this.lblName = new System.Windows.Forms.Label();
            this.sdpsingletask = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblSubmitTask = new System.Windows.Forms.Label();
            this.ICBSubmitTask = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.sdpsingletask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(108, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(494, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // sdpsingletask
            // 
            this.sdpsingletask.BackColor = System.Drawing.Color.Transparent;
            this.sdpsingletask.Controls.Add(this.ICBSubmitTask);
            this.sdpsingletask.Controls.Add(this.lblSubmitTask);
            this.sdpsingletask.Controls.Add(this.lblDueDate);
            this.sdpsingletask.Controls.Add(this.lblOpenDate);
            this.sdpsingletask.Controls.Add(this.dtpFrom);
            this.sdpsingletask.Controls.Add(this.dtpTo);
            this.sdpsingletask.Controls.Add(this.ptbImage);
            this.sdpsingletask.Controls.Add(this.btnChat);
            this.sdpsingletask.Controls.Add(this.lblName);
            this.sdpsingletask.FillColor = System.Drawing.Color.White;
            this.sdpsingletask.Location = new System.Drawing.Point(0, 0);
            this.sdpsingletask.Name = "sdpsingletask";
            this.sdpsingletask.ShadowColor = System.Drawing.Color.Black;
            this.sdpsingletask.Size = new System.Drawing.Size(764, 207);
            this.sdpsingletask.TabIndex = 7;
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(241, 64);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(169, 60);
            this.dtpFrom.TabIndex = 18;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(241, 130);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(169, 60);
            this.dtpTo.TabIndex = 17;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(110, 75);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(102, 28);
            this.lblOpenDate.TabIndex = 19;
            this.lblOpenDate.Text = "Open Day";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(110, 145);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 28);
            this.lblDueDate.TabIndex = 20;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblSubmitTask
            // 
            this.lblSubmitTask.AutoSize = true;
            this.lblSubmitTask.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTask.Location = new System.Drawing.Point(469, 81);
            this.lblSubmitTask.Name = "lblSubmitTask";
            this.lblSubmitTask.Size = new System.Drawing.Size(122, 28);
            this.lblSubmitTask.TabIndex = 21;
            this.lblSubmitTask.Text = "Submit Task";
            // 
            // ICBSubmitTask
            // 
            this.ICBSubmitTask.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.ICBSubmitTask.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ICBSubmitTask.ImageOffset = new System.Drawing.Point(0, 0);
            this.ICBSubmitTask.ImageRotate = 0F;
            this.ICBSubmitTask.ImageSize = new System.Drawing.Size(40, 40);
            this.ICBSubmitTask.Location = new System.Drawing.Point(495, 113);
            this.ICBSubmitTask.Name = "ICBSubmitTask";
            this.ICBSubmitTask.Size = new System.Drawing.Size(57, 60);
            this.ICBSubmitTask.TabIndex = 22;
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::WFThesisManagementSystem.Properties.Resources.Idea;
            this.ptbImage.Location = new System.Drawing.Point(15, 81);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(68, 62);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 2;
            this.ptbImage.TabStop = false;
            // 
            // btnChat
            // 
            this.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChat.FillColor = System.Drawing.Color.Transparent;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat;
            this.btnChat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChat.Location = new System.Drawing.Point(639, 75);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(72, 77);
            this.btnChat.TabIndex = 6;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // UcTeacherSingleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdpsingletask);
            this.Name = "UcTeacherSingleTask";
            this.Size = new System.Drawing.Size(767, 207);
            this.sdpsingletask.ResumeLayout(false);
            this.sdpsingletask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox ptbImage;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpsingletask;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblSubmitTask;
        private Guna.UI2.WinForms.Guna2ImageCheckBox ICBSubmitTask;
    }
}
