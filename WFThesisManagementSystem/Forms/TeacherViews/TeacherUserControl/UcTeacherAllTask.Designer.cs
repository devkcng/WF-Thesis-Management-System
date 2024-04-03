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
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllGroupView = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ucTeacherSingleTask1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherSingleTask();
            this.ucSingleGroup1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcSingleGroup();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.flpAllTasks.SuspendLayout();
            this.flpAllGroupView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(46, 36);
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
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTasks.Controls.Add(this.ucTeacherSingleTask1);
            this.flpAllTasks.Location = new System.Drawing.Point(727, 113);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(811, 786);
            this.flpAllTasks.TabIndex = 6;
            // 
            // flpAllGroupView
            // 
            this.flpAllGroupView.AutoScroll = true;
            this.flpAllGroupView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllGroupView.Controls.Add(this.ucSingleGroup1);
            this.flpAllGroupView.Location = new System.Drawing.Point(53, 113);
            this.flpAllGroupView.Name = "flpAllGroupView";
            this.flpAllGroupView.Size = new System.Drawing.Size(635, 786);
            this.flpAllGroupView.TabIndex = 14;
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(1128, 37);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(163, 44);
            this.dtpTo.TabIndex = 15;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(842, 36);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(156, 45);
            this.dtpFrom.TabIndex = 16;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // ucTeacherSingleTask1
            // 
            this.ucTeacherSingleTask1.Chat = null;
            this.ucTeacherSingleTask1.Image = null;
            this.ucTeacherSingleTask1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherSingleTask1.Name = "ucTeacherSingleTask1";
            this.ucTeacherSingleTask1.NameTeacher = null;
            this.ucTeacherSingleTask1.Size = new System.Drawing.Size(810, 156);
            this.ucTeacherSingleTask1.TabIndex = 0;
            this.ucTeacherSingleTask1.Time = null;
            // 
            // ucSingleGroup1
            // 
            this.ucSingleGroup1.Location = new System.Drawing.Point(3, 3);
            this.ucSingleGroup1.Name = "ucSingleGroup1";
            this.ucSingleGroup1.Size = new System.Drawing.Size(626, 150);
            this.ucSingleGroup1.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(721, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(81, 34);
            this.lblFrom.TabIndex = 17;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(1043, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 34);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To";
            // 
            // UcTeacherAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.flpAllGroupView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllTasks);
            this.Name = "UcTeacherAllTask";
            this.Size = new System.Drawing.Size(1584, 978);
            this.Load += new System.EventHandler(this.UcTeacherAllTask_Load);
            this.flpAllTasks.ResumeLayout(false);
            this.flpAllGroupView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTasks;
        public Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllGroupView;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private UcTeacherSingleTask ucTeacherSingleTask1;
        private UcSingleGroup ucSingleGroup1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }
}
