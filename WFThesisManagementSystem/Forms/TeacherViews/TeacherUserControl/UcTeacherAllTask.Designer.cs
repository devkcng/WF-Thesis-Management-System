namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
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
            this.ucTeacherSingleTask1 = new UcTeacherSingleTask();
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
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
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1374, 36);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 45);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            // 
            // UcTeacherAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnCreate);
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
        public Guna.UI2.WinForms.Guna2Button btnCreate;
    }
}
