namespace WFThesisManagementSystem.TeacherViews.Views
{
    partial class FTeacherCreateTopic
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
            this.ucTeacherCreateTopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherCreateTopic();
            this.SuspendLayout();
            // 
            // ucTeacherCreateTopic1
            // 
            this.ucTeacherCreateTopic1.AutoScroll = true;
            this.ucTeacherCreateTopic1.BackColor = System.Drawing.Color.LightBlue;
            this.ucTeacherCreateTopic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherCreateTopic1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherCreateTopic1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTeacherCreateTopic1.Name = "ucTeacherCreateTopic1";
            this.ucTeacherCreateTopic1.Size = new System.Drawing.Size(906, 992);
            this.ucTeacherCreateTopic1.TabIndex = 0;
            // 
            // FTeacherCreateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(906, 992);
            this.Controls.Add(this.ucTeacherCreateTopic1);
            this.Name = "FTeacherCreateTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherCreateTopic";
            this.Load += new System.EventHandler(this.FTeacherCreateTopic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TeacherUserControl.UcTeacherCreateTopic ucTeacherCreateTopic1;
    }
}