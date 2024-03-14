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
            this.ucSingletopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.ucSingletopic2 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.ucSingletopic3 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.ucSingletopic4 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTopic();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            // ucSingletopic1
            // 
            this.ucSingletopic1.BackColor = System.Drawing.Color.White;
            this.ucSingletopic1.Location = new System.Drawing.Point(3, 94);
            this.ucSingletopic1.Name = "ucSingletopic1";
            this.ucSingletopic1.Size = new System.Drawing.Size(488, 317);
            this.ucSingletopic1.TabIndex = 5;
            // 
            // ucSingletopic2
            // 
            this.ucSingletopic2.BackColor = System.Drawing.Color.White;
            this.ucSingletopic2.Location = new System.Drawing.Point(552, 94);
            this.ucSingletopic2.Name = "ucSingletopic2";
            this.ucSingletopic2.Size = new System.Drawing.Size(488, 317);
            this.ucSingletopic2.TabIndex = 6;
            // 
            // ucSingletopic3
            // 
            this.ucSingletopic3.BackColor = System.Drawing.Color.White;
            this.ucSingletopic3.Location = new System.Drawing.Point(17, 439);
            this.ucSingletopic3.Name = "ucSingletopic3";
            this.ucSingletopic3.Size = new System.Drawing.Size(488, 317);
            this.ucSingletopic3.TabIndex = 7;
            // 
            // ucSingletopic4
            // 
            this.ucSingletopic4.BackColor = System.Drawing.Color.White;
            this.ucSingletopic4.Location = new System.Drawing.Point(552, 439);
            this.ucSingletopic4.Name = "ucSingletopic4";
            this.ucSingletopic4.Size = new System.Drawing.Size(488, 317);
            this.ucSingletopic4.TabIndex = 8;
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
            // UcAllTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ucSingletopic4);
            this.Controls.Add(this.ucSingletopic3);
            this.Controls.Add(this.ucSingletopic2);
            this.Controls.Add(this.ucSingletopic1);
            this.Controls.Add(this.lblTopics);
            this.Name = "UcAllTopics";
            this.Size = new System.Drawing.Size(1082, 809);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopics;
        private UcTeacherSingleTopic ucSingletopic1;
        private UcTeacherSingleTopic ucSingletopic2;
        private UcTeacherSingleTopic ucSingletopic3;
        private UcTeacherSingleTopic ucSingletopic4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
