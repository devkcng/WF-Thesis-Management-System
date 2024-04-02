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
            this.lblName = new System.Windows.Forms.Label();
            this.sdpsingletask = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbSubmitTask = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblSubmitTask = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.lblName.Location = new System.Drawing.Point(72, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(330, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // sdpsingletask
            // 
            this.sdpsingletask.BackColor = System.Drawing.Color.Transparent;
            this.sdpsingletask.Controls.Add(this.cbSubmitTask);
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
            this.sdpsingletask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sdpsingletask.Name = "sdpsingletask";
            this.sdpsingletask.ShadowColor = System.Drawing.Color.Black;
            this.sdpsingletask.Size = new System.Drawing.Size(509, 135);
            this.sdpsingletask.TabIndex = 7;
            // 
            // cbSubmitTask
            // 
            this.cbSubmitTask.CheckedState.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38__2_;
            this.cbSubmitTask.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.cbSubmitTask.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.cbSubmitTask.ImageOffset = new System.Drawing.Point(0, 0);
            this.cbSubmitTask.ImageRotate = 0F;
            this.cbSubmitTask.ImageSize = new System.Drawing.Size(40, 40);
            this.cbSubmitTask.Location = new System.Drawing.Point(330, 73);
            this.cbSubmitTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSubmitTask.Name = "cbSubmitTask";
            this.cbSubmitTask.Size = new System.Drawing.Size(38, 39);
            this.cbSubmitTask.TabIndex = 22;
            // 
            // lblSubmitTask
            // 
            this.lblSubmitTask.AutoSize = true;
            this.lblSubmitTask.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTask.Location = new System.Drawing.Point(313, 53);
            this.lblSubmitTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubmitTask.Name = "lblSubmitTask";
            this.lblSubmitTask.Size = new System.Drawing.Size(85, 19);
            this.lblSubmitTask.TabIndex = 21;
            this.lblSubmitTask.Text = "Submit Task";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(73, 94);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(67, 19);
            this.lblDueDate.TabIndex = 20;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(73, 49);
            this.lblOpenDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(71, 19);
            this.lblOpenDate.TabIndex = 19;
            this.lblOpenDate.Text = "Open Day";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(161, 42);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(113, 39);
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
            this.dtpTo.Location = new System.Drawing.Point(161, 84);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(113, 39);
            this.dtpTo.TabIndex = 17;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::WFThesisManagementSystem.Properties.Resources.Idea;
            this.ptbImage.Location = new System.Drawing.Point(10, 53);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(45, 40);
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
            this.btnChat.Location = new System.Drawing.Point(426, 49);
            this.btnChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(48, 50);
            this.btnChat.TabIndex = 6;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // UcTeacherSingleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdpsingletask);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcTeacherSingleTask";
            this.Size = new System.Drawing.Size(511, 135);
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
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbSubmitTask;
    }
}
