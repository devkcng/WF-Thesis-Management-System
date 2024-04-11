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
            this.lblContentTask = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.Label();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.sdpsingletask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(92, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(494, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // sdpsingletask
            // 
            this.sdpsingletask.BackColor = System.Drawing.Color.Transparent;
            this.sdpsingletask.Controls.Add(this.btnChat);
            this.sdpsingletask.Controls.Add(this.dtpTo);
            this.sdpsingletask.Controls.Add(this.dtpFrom);
            this.sdpsingletask.Controls.Add(this.lblContentTask);
            this.sdpsingletask.Controls.Add(this.ptbImage);
            this.sdpsingletask.Controls.Add(this.btnEdit);
            this.sdpsingletask.Controls.Add(this.lblName);
            this.sdpsingletask.FillColor = System.Drawing.Color.White;
            this.sdpsingletask.Location = new System.Drawing.Point(0, 0);
            this.sdpsingletask.Name = "sdpsingletask";
            this.sdpsingletask.ShadowColor = System.Drawing.Color.Black;
            this.sdpsingletask.Size = new System.Drawing.Size(891, 208);
            this.sdpsingletask.TabIndex = 7;
            // 
            // lblContentTask
            // 
            this.lblContentTask.AutoSize = true;
            this.lblContentTask.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentTask.Location = new System.Drawing.Point(104, 114);
            this.lblContentTask.Name = "lblContentTask";
            this.lblContentTask.Size = new System.Drawing.Size(137, 30);
            this.lblContentTask.TabIndex = 23;
            this.lblContentTask.Text = "Content Task";
            // 
            // dtpFrom
            // 
            this.dtpFrom.AutoSize = true;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(615, 53);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(72, 30);
            this.dtpFrom.TabIndex = 24;
            this.dtpFrom.Text = "label1";
            // 
            // dtpTo
            // 
            this.dtpTo.AutoSize = true;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(751, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(72, 30);
            this.dtpTo.TabIndex = 25;
            this.dtpTo.Text = "label2";
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
            this.btnChat.Image = global::WFThesisManagementSystem.Properties.Resources.Chat1;
            this.btnChat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChat.Location = new System.Drawing.Point(740, 114);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(83, 68);
            this.btnChat.TabIndex = 26;
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::WFThesisManagementSystem.Properties.Resources.Idea;
            this.ptbImage.Location = new System.Drawing.Point(18, 82);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(68, 62);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 2;
            this.ptbImage.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::WFThesisManagementSystem.Properties.Resources.pencil1;
            this.btnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Location = new System.Drawing.Point(615, 105);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 77);
            this.btnEdit.TabIndex = 6;
            // 
            // UcTeacherSingleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdpsingletask);
            this.Name = "UcTeacherSingleTask";
            this.Size = new System.Drawing.Size(892, 208);
            this.sdpsingletask.ResumeLayout(false);
            this.sdpsingletask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox ptbImage;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpsingletask;
        public System.Windows.Forms.Label lblContentTask;
        private System.Windows.Forms.Label dtpTo;
        private System.Windows.Forms.Label dtpFrom;
        private Guna.UI2.WinForms.Guna2Button btnChat;
    }
}
