﻿namespace WFThesisManagementSystem.TeacherViews.Views
{
    partial class FTeacherEditTopic
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
            this.ucTeacherEditTopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherEditTopic();
            this.SuspendLayout();
            // 
            // ucTeacherEditTopic1
            // 
            this.ucTeacherEditTopic1.BackColor = System.Drawing.Color.Pink;
            this.ucTeacherEditTopic1.Location = new System.Drawing.Point(-1, -3);
            this.ucTeacherEditTopic1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucTeacherEditTopic1.Name = "ucTeacherEditTopic1";
            this.ucTeacherEditTopic1.Size = new System.Drawing.Size(607, 645);
            this.ucTeacherEditTopic1.TabIndex = 0;
            // 
            // FTeacherEditTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 643);
            this.Controls.Add(this.ucTeacherEditTopic1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FTeacherEditTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherEditTopic";
            this.ResumeLayout(false);

        }

        #endregion

        public TeacherUserControl.UcTeacherEditTopic ucTeacherEditTopic1;
    }
}