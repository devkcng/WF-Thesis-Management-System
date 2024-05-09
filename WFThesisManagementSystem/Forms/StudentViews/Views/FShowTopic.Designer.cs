namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    partial class FShowTopic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ucTopicDetail1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCTopicDetail();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ucTopicDetail1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1529, 938);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // ucTopicDetail1
            // 
            this.ucTopicDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTopicDetail1.Location = new System.Drawing.Point(0, 0);
            this.ucTopicDetail1.Name = "ucTopicDetail1";
            this.ucTopicDetail1.Size = new System.Drawing.Size(1529, 938);
            this.ucTopicDetail1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.FillColor2 = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.btnClose.Location = new System.Drawing.Point(1003, 944);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(239, 74);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.White;
            this.btnRegister.FillColor2 = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Cambria", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.btnRegister.Location = new System.Drawing.Point(1273, 944);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(239, 74);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // FShowTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1529, 1046);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FShowTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRegisterTopic_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private StudentUserControl.UCTopicDetail ucTopicDetail1;
        private Guna.UI2.WinForms.Guna2GradientButton btnRegister;
        public Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}