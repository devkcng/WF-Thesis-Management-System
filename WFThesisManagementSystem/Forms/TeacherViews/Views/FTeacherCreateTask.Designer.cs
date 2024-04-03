using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    partial class FTeacherCreateTask
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
            this.ucTeacherCreateTask1.Name = "ucTeacherCreateTask1";
            this.ucTeacherCreateTask1.Size = new System.Drawing.Size(885, 823);
            this.ucTeacherCreateTask1.TabIndex = 0;
            // 
            // FTeacherCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(885, 823);
            this.Controls.Add(this.ucTeacherCreateTask1);
            this.Name = "FTeacherCreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherCreateTask";
            this.ResumeLayout(false);

        }

        #endregion

        private UcTeacherCreateTask ucTeacherCreateTask1;
    }
}