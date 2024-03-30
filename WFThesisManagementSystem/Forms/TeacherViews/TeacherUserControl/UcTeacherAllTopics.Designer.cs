using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
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
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.ucTeacherSingleTopic1 = new UcTeacherSingleTopic();
            this.ucTeacherSingleTopic2 = new UcTeacherSingleTopic();
            this.ucTask1 = new UCTask();
            this.flpTopicView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopics.Location = new System.Drawing.Point(213, 37);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(113, 38);
            this.lblTopics.TabIndex = 2;
            this.lblTopics.Text = "Topics";
            // 
            // flpTopicView
            // 
            this.flpTopicView.AutoScroll = true;
            this.flpTopicView.Controls.Add(this.ucTeacherSingleTopic1);
            this.flpTopicView.Controls.Add(this.ucTeacherSingleTopic2);
            this.flpTopicView.Controls.Add(this.ucTask1);
            this.flpTopicView.Location = new System.Drawing.Point(217, 122);
            this.flpTopicView.Name = "flpTopicView";
            this.flpTopicView.Size = new System.Drawing.Size(1233, 777);
            this.flpTopicView.TabIndex = 10;
            this.flpTopicView.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.btnCreate.Location = new System.Drawing.Point(1334, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 45);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            // 
            // ucTeacherSingleTopic1
            // 
            this.ucTeacherSingleTopic1.BackColor = System.Drawing.Color.White;
            this.ucTeacherSingleTopic1.Button = null;
            this.ucTeacherSingleTopic1.Description = null;
            this.ucTeacherSingleTopic1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTopic1.Name = "ucTeacherSingleTopic1";
            this.ucTeacherSingleTopic1.Size = new System.Drawing.Size(1202, 230);
            this.ucTeacherSingleTopic1.TabIndex = 0;
            // 
            // ucTeacherSingleTopic2
            // 
            this.ucTeacherSingleTopic2.BackColor = System.Drawing.Color.White;
            this.ucTeacherSingleTopic2.Button = null;
            this.ucTeacherSingleTopic2.Description = null;
            this.ucTeacherSingleTopic2.Location = new System.Drawing.Point(1211, 3);
            this.ucTeacherSingleTopic2.Name = "ucTeacherSingleTopic2";
            this.ucTeacherSingleTopic2.Size = new System.Drawing.Size(8, 8);
            this.ucTeacherSingleTopic2.TabIndex = 1;
            // 
            // ucTask1
            // 
            this.ucTask1.Location = new System.Drawing.Point(3, 239);
            this.ucTask1.Name = "ucTask1";
            this.ucTask1.Size = new System.Drawing.Size(8, 8);
            this.ucTask1.TabIndex = 2;
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
            this.Size = new System.Drawing.Size(1584, 978);
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
        private UcTeacherSingleTopic ucTeacherSingleTopic2;
        private UCTask ucTask1;
    }
}
