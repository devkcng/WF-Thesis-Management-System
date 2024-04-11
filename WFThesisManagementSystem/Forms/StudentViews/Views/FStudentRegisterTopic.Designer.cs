namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    partial class FStudentRegisterTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudentRegisterTopic));
            this.sdpTitle = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.ptbReload = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.flpAllTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.sdpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // sdpTitle
            // 
            this.sdpTitle.BackColor = System.Drawing.Color.Transparent;
            this.sdpTitle.Controls.Add(this.btnDashBoard);
            this.sdpTitle.Controls.Add(this.ptbReload);
            this.sdpTitle.Controls.Add(this.btnSearch);
            this.sdpTitle.Controls.Add(this.label2);
            this.sdpTitle.Controls.Add(this.label1);
            this.sdpTitle.Controls.Add(this.txtDescribe);
            this.sdpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdpTitle.FillColor = System.Drawing.Color.White;
            this.sdpTitle.Location = new System.Drawing.Point(0, 0);
            this.sdpTitle.Name = "sdpTitle";
            this.sdpTitle.ShadowColor = System.Drawing.Color.Black;
            this.sdpTitle.Size = new System.Drawing.Size(1915, 316);
            this.sdpTitle.TabIndex = 10;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(1525, 169);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(384, 115);
            this.btnDashBoard.TabIndex = 15;
            this.btnDashBoard.Text = "Back to DashBoard";
            // 
            // ptbReload
            // 
            this.ptbReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbReload.Image = ((System.Drawing.Image)(resources.GetObject("ptbReload.Image")));
            this.ptbReload.ImageRotate = 0F;
            this.ptbReload.Location = new System.Drawing.Point(1358, 194);
            this.ptbReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ptbReload.Name = "ptbReload";
            this.ptbReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbReload.Size = new System.Drawing.Size(74, 83);
            this.ptbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReload.TabIndex = 14;
            this.ptbReload.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::WFThesisManagementSystem.Properties.Resources.Search1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(1195, 194);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 87);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 81);
            this.label2.TabIndex = 12;
            this.label2.Text = "Topic List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 62);
            this.label1.TabIndex = 11;
            this.label1.Text = "Describe topic";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(379, 194);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(757, 84);
            this.txtDescribe.TabIndex = 10;
            // 
            // flpAllTopics
            // 
            this.flpAllTopics.AutoScroll = true;
            this.flpAllTopics.BackColor = System.Drawing.Color.White;
            this.flpAllTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllTopics.Location = new System.Drawing.Point(0, 316);
            this.flpAllTopics.Name = "flpAllTopics";
            this.flpAllTopics.Padding = new System.Windows.Forms.Padding(130, 60, 30, 0);
            this.flpAllTopics.Size = new System.Drawing.Size(1915, 712);
            this.flpAllTopics.TabIndex = 13;
            // 
            // FStudentRegisterTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1915, 1028);
            this.Controls.Add(this.flpAllTopics);
            this.Controls.Add(this.sdpTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FStudentRegisterTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentRegisterTopic";
            this.Load += new System.EventHandler(this.FStudentRegisterTopic_Load);
            this.sdpTitle.ResumeLayout(false);
            this.sdpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel sdpTitle;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.FlowLayoutPanel flpAllTopics;
    }
}