namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAllTopics
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
            this.lblTopics = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flpTopicView = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTeacherSingleTopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.flpTopicView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(74, 46);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(55, 20);
            this.lblTopics.TabIndex = 2;
            this.lblTopics.Text = "Topics";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(761, 30);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Create";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flpTopicView
            // 
            this.flpTopicView.AutoScroll = true;
            this.flpTopicView.Controls.Add(this.ucTeacherSingleTopic1);
            this.flpTopicView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTopicView.Location = new System.Drawing.Point(78, 108);
            this.flpTopicView.Name = "flpTopicView";
            this.flpTopicView.Size = new System.Drawing.Size(919, 494);
            this.flpTopicView.TabIndex = 10;
            this.flpTopicView.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ucTeacherSingleTopic1
            // 
            this.ucTeacherSingleTopic1.BackColor = System.Drawing.Color.White;
            this.ucTeacherSingleTopic1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTopic1.Name = "ucTeacherSingleTopic1";
            this.ucTeacherSingleTopic1.Size = new System.Drawing.Size(883, 267);
            this.ucTeacherSingleTopic1.TabIndex = 0;
            this.ucTeacherSingleTopic1.Load += new System.EventHandler(this.ucTeacherSingleTopic1_Load);
            // 
            // UcTeacherAllTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTopicView);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblTopics);
            this.Name = "UcTeacherAllTopics";
            this.Size = new System.Drawing.Size(1082, 809);
            this.Load += new System.EventHandler(this.UcTeacherAllTopics_Load);
            this.flpTopicView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopics;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel flpTopicView;
        private UcTeacherSingleTopic ucTeacherSingleTopic1;
    }
}
