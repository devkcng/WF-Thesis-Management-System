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
            this.lblTasks = new System.Windows.Forms.Label();
            this.ucTeacherSingleTask1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherSingleTask();
            this.flpAllTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.Controls.Add(this.ucTeacherSingleTask1);
            this.flpAllTasks.Location = new System.Drawing.Point(129, 113);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1378, 786);
            this.flpAllTasks.TabIndex = 6;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(125, 36);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(98, 38);
            this.lblTasks.TabIndex = 12;
            this.lblTasks.Text = "Tasks";
            // 
            // ucTeacherSingleTask1
            // 
            this.ucTeacherSingleTask1.Chat = null;
            this.ucTeacherSingleTask1.Image = null;
            this.ucTeacherSingleTask1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTask1.Name = "ucTeacherSingleTask1";
            this.ucTeacherSingleTask1.NameTeacher = null;
            this.ucTeacherSingleTask1.Size = new System.Drawing.Size(840, 133);
            this.ucTeacherSingleTask1.TabIndex = 0;
            this.ucTeacherSingleTask1.Time = null;
            // 
            // UcTeacherAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllTasks);
            this.Name = "UcTeacherAllTask";
            this.Size = new System.Drawing.Size(1584, 978);
            this.Load += new System.EventHandler(this.UcTeacherAllTask_Load);
            this.flpAllTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private UcTeacherSingleTask ucTeacherSingleTask1;
        public System.Windows.Forms.Label lblTasks;
    }
}
