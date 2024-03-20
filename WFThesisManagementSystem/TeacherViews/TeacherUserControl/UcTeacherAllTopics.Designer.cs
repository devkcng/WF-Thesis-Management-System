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
            this.flpTopicView = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTeacherSingleTopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.flpTopicView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopics.Location = new System.Drawing.Point(74, 37);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(113, 38);
            this.lblTopics.TabIndex = 2;
            this.lblTopics.Text = "Topics";
            // 
            // flpTopicView
            // 
            this.flpTopicView.AutoScroll = true;
            this.flpTopicView.Controls.Add(this.ucTeacherSingleTopic1);
            this.flpTopicView.Location = new System.Drawing.Point(73, 112);
            this.flpTopicView.Name = "flpTopicView";
            this.flpTopicView.Size = new System.Drawing.Size(1181, 617);
            this.flpTopicView.TabIndex = 10;
            this.flpTopicView.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ucTeacherSingleTopic1
            // 
            this.ucTeacherSingleTopic1.BackColor = System.Drawing.Color.White;
            this.ucTeacherSingleTopic1.Button = null;
            this.ucTeacherSingleTopic1.Description = null;
            this.ucTeacherSingleTopic1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTopic1.Name = "ucTeacherSingleTopic1";
            this.ucTeacherSingleTopic1.Size = new System.Drawing.Size(911, 230);
            this.ucTeacherSingleTopic1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1110, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 45);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            // 
            // UcTeacherAllTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.flpTopicView);
            this.Controls.Add(this.lblTopics);
            this.Name = "UcTeacherAllTopics";
            this.Size = new System.Drawing.Size(1311, 764);
            this.Load += new System.EventHandler(this.UcTeacherAllTopics_Load);
            this.flpTopicView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTopics;
        public System.Windows.Forms.FlowLayoutPanel flpTopicView;
        public UcTeacherSingleTopic ucTeacherSingleTopic1;
        public Guna.UI2.WinForms.Guna2Button btnCreate;
    }
}
