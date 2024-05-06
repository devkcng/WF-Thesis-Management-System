namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    partial class FStudentCreateSubTask
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
            this.ucTeacherCreateTask1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherCreateTask();
            this.SuspendLayout();
            // 
            // ucTeacherCreateTask1
            // 
            this.ucTeacherCreateTask1.AutoScroll = true;
            this.ucTeacherCreateTask1.BackColor = System.Drawing.Color.Turquoise;
            this.ucTeacherCreateTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherCreateTask1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherCreateTask1.Margin = new System.Windows.Forms.Padding(8);
            this.ucTeacherCreateTask1.Name = "ucTeacherCreateTask1";
            this.ucTeacherCreateTask1.Size = new System.Drawing.Size(1475, 1372);
            this.ucTeacherCreateTask1.TabIndex = 1;
            // 
            // FStudentCreateSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 1372);
            this.Controls.Add(this.ucTeacherCreateTask1);
            this.Name = "FStudentCreateSubTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentCreateSubTask";
            this.ResumeLayout(false);

        }

        #endregion

        private TeacherViews.TeacherUserControl.UcTeacherCreateTask ucTeacherCreateTask1;
    }
}