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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(25, 105);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(346, 63);
            this.lblTasks.TabIndex = 38;
            this.lblTasks.Text = "Group Tasks";
            // 
            // flpAllInvidualTasksView
            // 
            this.flpAllInvidualTasksView.AutoScroll = true;
            this.flpAllInvidualTasksView.Location = new System.Drawing.Point(1384, 197);
            this.flpAllInvidualTasksView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllInvidualTasksView.Name = "flpAllInvidualTasksView";
            this.flpAllInvidualTasksView.Size = new System.Drawing.Size(1427, 1217);
            this.flpAllInvidualTasksView.TabIndex = 37;
            // 
            // flpGroupTaskView
            // 
            this.flpGroupTaskView.AutoScroll = true;
            this.flpGroupTaskView.Location = new System.Drawing.Point(5, 197);
            this.flpGroupTaskView.Margin = new System.Windows.Forms.Padding(5);
            this.flpGroupTaskView.Name = "flpGroupTaskView";
            this.flpGroupTaskView.Size = new System.Drawing.Size(1369, 1217);
            this.flpGroupTaskView.TabIndex = 39;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2231, 31);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 43;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1411, 31);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 42;
            this.lblFrom.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1409, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 63);
            this.label1.TabIndex = 44;
            this.label1.Text = "Invidual Tasks";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(1593, 25);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 70);
            this.dtpFrom.TabIndex = 45;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(2348, 25);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 46;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // UCStudentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllInvidualTasksView);
            this.Controls.Add(this.flpGroupTaskView);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCStudentTask";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        public System.Windows.Forms.FlowLayoutPanel flpAllInvidualTasksView;
        public System.Windows.Forms.FlowLayoutPanel flpGroupTaskView;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
    }
}
