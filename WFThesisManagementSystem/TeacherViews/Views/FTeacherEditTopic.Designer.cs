namespace WFThesisManagementSystem.TeacherViews.Views
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
            this.ucTeacherEditTopic1.Location = new System.Drawing.Point(-1, -4);
            this.ucTeacherEditTopic1.Name = "ucTeacherEditTopic1";
            this.ucTeacherEditTopic1.Size = new System.Drawing.Size(911, 993);
            this.ucTeacherEditTopic1.TabIndex = 0;
            // 
            // FTeacherEditTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 989);
            this.Controls.Add(this.ucTeacherEditTopic1);
            this.Name = "FTeacherEditTopic";
            this.Text = "FTeacherEditTopic";
            this.ResumeLayout(false);

        }

        #endregion

        public TeacherUserControl.UcTeacherEditTopic ucTeacherEditTopic1;
    }
}