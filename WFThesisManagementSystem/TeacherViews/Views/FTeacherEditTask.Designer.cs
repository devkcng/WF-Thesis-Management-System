namespace WFThesisManagementSystem.TeacherViews.Views
{
    partial class FTeacherEditTask
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
            this.ucTeacherEditTask1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherEditTask();
            this.SuspendLayout();
            // 
            // ucTeacherEditTask1
            // 
            this.ucTeacherEditTask1.AutoScroll = true;
            this.ucTeacherEditTask1.BackColor = System.Drawing.Color.DimGray;
            this.ucTeacherEditTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherEditTask1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherEditTask1.Name = "ucTeacherEditTask1";
            this.ucTeacherEditTask1.Size = new System.Drawing.Size(885, 838);
            this.ucTeacherEditTask1.TabIndex = 0;
            // 
            // FTeacherEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(885, 838);
            this.Controls.Add(this.ucTeacherEditTask1);
            this.Name = "FTeacherEditTask";
            this.Text = "FTeacherEditTask";
            this.ResumeLayout(false);

        }

        #endregion

        private TeacherUserControl.UcTeacherEditTask ucTeacherEditTask1;
    }
}