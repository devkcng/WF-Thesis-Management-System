namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAllTask
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
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTeacherSingleTask1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTask();
            this.flpAllTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.Controls.Add(this.ucTeacherSingleTask1);
            this.flpAllTasks.Location = new System.Drawing.Point(75, 110);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(843, 512);
            this.flpAllTasks.TabIndex = 6;
            // 
            // ucTeacherSingleTask1
            // 
            this.ucTeacherSingleTask1.Chat = null;
            this.ucTeacherSingleTask1.Image = null;
            this.ucTeacherSingleTask1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTask1.Name = "ucTeacherSingleTask1";
            this.ucTeacherSingleTask1.NameTeacher = null;
            this.ucTeacherSingleTask1.Size = new System.Drawing.Size(840, 134);
            this.ucTeacherSingleTask1.TabIndex = 0;
            // 
            // UcTeacherAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.flpAllTasks);
            this.Name = "UcTeacherAllTask";
            this.Size = new System.Drawing.Size(985, 669);
            this.flpAllTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private UcTeacherSingleTask ucTeacherSingleTask1;
    }
}
