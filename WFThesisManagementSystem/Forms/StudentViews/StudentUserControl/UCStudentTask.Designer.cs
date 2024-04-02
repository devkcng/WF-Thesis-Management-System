namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCStudentTask
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
            this.flpAllInvidualTasksView = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGroupTaskView = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flpAllTaskView = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInvidualTasksView = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(83, 90);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(176, 63);
            this.lblTasks.TabIndex = 20;
            this.lblTasks.Text = "Tasks";
            // 
            // flpAllInvidualTasksView
            // 
            this.flpAllInvidualTasksView.AutoScroll = true;
            this.flpAllInvidualTasksView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllInvidualTasksView.Location = new System.Drawing.Point(1371, 294);
            this.flpAllInvidualTasksView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllInvidualTasksView.Name = "flpAllInvidualTasksView";
            this.flpAllInvidualTasksView.Size = new System.Drawing.Size(1421, 1182);
            this.flpAllInvidualTasksView.TabIndex = 19;
            // 
            // flpGroupTaskView
            // 
            this.flpGroupTaskView.AutoScroll = true;
            this.flpGroupTaskView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGroupTaskView.Location = new System.Drawing.Point(5, 294);
            this.flpGroupTaskView.Margin = new System.Windows.Forms.Padding(5);
            this.flpGroupTaskView.Name = "flpGroupTaskView";
            this.flpGroupTaskView.Size = new System.Drawing.Size(1317, 1182);
            this.flpGroupTaskView.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(1855, 96);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 26;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1283, 96);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 25;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(1498, 90);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 70);
            this.dtpFrom.TabIndex = 24;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(2006, 91);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 23;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // flpAllTaskView
            // 
            this.flpAllTaskView.AutoScroll = true;
            this.flpAllTaskView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTaskView.Location = new System.Drawing.Point(95, 209);
            this.flpAllTaskView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTaskView.Name = "flpAllTaskView";
            this.flpAllTaskView.Size = new System.Drawing.Size(1127, 1217);
            this.flpAllTaskView.TabIndex = 22;
            // 
            // flpInvidualTasksView
            // 
            this.flpInvidualTasksView.AutoScroll = true;
            this.flpInvidualTasksView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpInvidualTasksView.Location = new System.Drawing.Point(1293, 209);
            this.flpInvidualTasksView.Margin = new System.Windows.Forms.Padding(5);
            this.flpInvidualTasksView.Name = "flpInvidualTasksView";
            this.flpInvidualTasksView.Size = new System.Drawing.Size(1440, 1217);
            this.flpInvidualTasksView.TabIndex = 19;
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTasks.Location = new System.Drawing.Point(1293, 209);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1440, 1217);
            this.flpAllTasks.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 63);
            this.label1.TabIndex = 27;
            this.label1.Text = "Group Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1360, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 63);
            this.label2.TabIndex = 28;
            this.label2.Text = "Invidual Tasks";
            // 
            // UCStudentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllInvidualTasksView);
            this.Controls.Add(this.flpGroupTaskView);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCStudentTask";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllInvidualTasksView;
        private TeacherViews.TeacherUserControl.UcTeacherSingleTask ucTeacherSingleTask1;
        private System.Windows.Forms.FlowLayoutPanel flpGroupTaskView;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.FlowLayoutPanel flpAllTaskView;
        private System.Windows.Forms.FlowLayoutPanel flpInvidualTasksView;
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
