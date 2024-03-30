namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
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
            this.lblTimeAndOrdinalNumber = new System.Windows.Forms.Label();
            this.lblNameTeacher = new System.Windows.Forms.Label();
            this.sdpsingletask = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.sdpsingletask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(233, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(559, 45);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Make an automatic payment system";
            // 
            // lblTimeAndOrdinalNumber
            // 
            this.lblTimeAndOrdinalNumber.AutoSize = true;
            this.lblTimeAndOrdinalNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAndOrdinalNumber.Location = new System.Drawing.Point(234, 134);
            this.lblTimeAndOrdinalNumber.Name = "lblTimeAndOrdinalNumber";
            this.lblTimeAndOrdinalNumber.Size = new System.Drawing.Size(402, 38);
            this.lblTimeAndOrdinalNumber.TabIndex = 1;
            this.lblTimeAndOrdinalNumber.Text = "#402235 Opens 10 day ago by ";
            // 
            // lblNameTeacher
            // 
            this.lblNameTeacher.AutoSize = true;
            this.lblNameTeacher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTeacher.Location = new System.Drawing.Point(704, 134);
            this.lblNameTeacher.Name = "lblNameTeacher";
            this.lblNameTeacher.Size = new System.Drawing.Size(192, 38);
            this.lblNameTeacher.TabIndex = 4;
            this.lblNameTeacher.Text = "Mai Duc Kien";
            // 
            // sdpsingletask
            // 
            this.sdpsingletask.BackColor = System.Drawing.Color.Transparent;
            this.sdpsingletask.Controls.Add(this.ptbImage);
            this.sdpsingletask.Controls.Add(this.btnChat);
            this.sdpsingletask.Controls.Add(this.lblName);
            this.sdpsingletask.Controls.Add(this.lblNameTeacher);
            this.sdpsingletask.Controls.Add(this.lblTimeAndOrdinalNumber);
            this.sdpsingletask.FillColor = System.Drawing.Color.White;
            this.sdpsingletask.Location = new System.Drawing.Point(0, 0);
            this.sdpsingletask.Name = "sdpsingletask";
            this.sdpsingletask.ShadowColor = System.Drawing.Color.Black;
            this.sdpsingletask.Size = new System.Drawing.Size(1175, 229);
            this.sdpsingletask.TabIndex = 7;
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::WFThesisManagementSystem.Properties.Resources.Idea;
            this.ptbImage.Location = new System.Drawing.Point(67, 66);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(99, 106);
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
            this.btnChat.Location = new System.Drawing.Point(1016, 66);
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
            this.Size = new System.Drawing.Size(1178, 229);
            this.sdpsingletask.ResumeLayout(false);
            this.sdpsingletask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimeAndOrdinalNumber;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label lblNameTeacher;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpsingletask;
    }
}
