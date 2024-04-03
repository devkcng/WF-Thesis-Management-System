namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCSTudentSubTasks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllGroupView = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ucStudentInformation1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCStudentInformation();
            this.ucStudentInformation2 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCStudentInformation();
            this.ucStudentInformation3 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCStudentInformation();
            this.ucSubTasks2 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCSubTasks();
            this.ucSubTasks1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCSubTasks();
            this.ucSubTasks3 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCSubTasks();
            this.ucSubTasks4 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCSubTasks();
            this.flpAllTasks.SuspendLayout();
            this.flpAllGroupView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1062, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 63);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sub Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "Members";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(32, 65);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(176, 63);
            this.lblTasks.TabIndex = 30;
            this.lblTasks.Text = "Tasks";
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTasks.Controls.Add(this.ucSubTasks1);
            this.flpAllTasks.Controls.Add(this.ucSubTasks2);
            this.flpAllTasks.Controls.Add(this.ucSubTasks3);
            this.flpAllTasks.Controls.Add(this.ucSubTasks4);
            this.flpAllTasks.Location = new System.Drawing.Point(1073, 249);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1686, 1217);
            this.flpAllTasks.TabIndex = 29;
            // 
            // flpAllGroupView
            // 
            this.flpAllGroupView.AutoScroll = true;
            this.flpAllGroupView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllGroupView.Controls.Add(this.ucStudentInformation1);
            this.flpAllGroupView.Controls.Add(this.ucStudentInformation2);
            this.flpAllGroupView.Controls.Add(this.ucStudentInformation3);
            this.flpAllGroupView.Location = new System.Drawing.Point(16, 249);
            this.flpAllGroupView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllGroupView.Name = "flpAllGroupView";
            this.flpAllGroupView.Size = new System.Drawing.Size(938, 1217);
            this.flpAllGroupView.TabIndex = 31;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2333, 71);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 35;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1761, 71);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 34;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(1976, 65);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 70);
            this.dtpFrom.TabIndex = 33;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(2484, 66);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 32;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // ucStudentInformation1
            // 
            this.ucStudentInformation1.Location = new System.Drawing.Point(3, 3);
            this.ucStudentInformation1.Name = "ucStudentInformation1";
            this.ucStudentInformation1.Size = new System.Drawing.Size(925, 163);
            this.ucStudentInformation1.TabIndex = 0;
            // 
            // ucStudentInformation2
            // 
            this.ucStudentInformation2.Location = new System.Drawing.Point(3, 172);
            this.ucStudentInformation2.Name = "ucStudentInformation2";
            this.ucStudentInformation2.Size = new System.Drawing.Size(925, 163);
            this.ucStudentInformation2.TabIndex = 1;
            // 
            // ucStudentInformation3
            // 
            this.ucStudentInformation3.Location = new System.Drawing.Point(3, 341);
            this.ucStudentInformation3.Name = "ucStudentInformation3";
            this.ucStudentInformation3.Size = new System.Drawing.Size(925, 163);
            this.ucStudentInformation3.TabIndex = 2;
            // 
            // ucSubTasks2
            // 
            this.ucSubTasks2.Location = new System.Drawing.Point(3, 331);
            this.ucSubTasks2.Name = "ucSubTasks2";
            this.ucSubTasks2.Size = new System.Drawing.Size(8, 8);
            this.ucSubTasks2.TabIndex = 1;
            // 
            // ucSubTasks1
            // 
            this.ucSubTasks1.Location = new System.Drawing.Point(3, 3);
            this.ucSubTasks1.Name = "ucSubTasks1";
            this.ucSubTasks1.Size = new System.Drawing.Size(1674, 322);
            this.ucSubTasks1.TabIndex = 0;
            // 
            // ucSubTasks3
            // 
            this.ucSubTasks3.Location = new System.Drawing.Point(3, 345);
            this.ucSubTasks3.Name = "ucSubTasks3";
            this.ucSubTasks3.Size = new System.Drawing.Size(1674, 322);
            this.ucSubTasks3.TabIndex = 2;
            // 
            // ucSubTasks4
            // 
            this.ucSubTasks4.Location = new System.Drawing.Point(3, 673);
            this.ucSubTasks4.Name = "ucSubTasks4";
            this.ucSubTasks4.Size = new System.Drawing.Size(1674, 322);
            this.ucSubTasks4.TabIndex = 3;
            // 
            // UCSTudentSubTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllTasks);
            this.Controls.Add(this.flpAllGroupView);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Name = "UCSTudentSubTasks";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.flpAllTasks.ResumeLayout(false);
            this.flpAllGroupView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllGroupView;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private UCStudentInformation ucStudentInformation1;
        private UCStudentInformation ucStudentInformation2;
        private UCStudentInformation ucStudentInformation3;
        private UCSubTasks ucSubTasks1;
        private UCSubTasks ucSubTasks2;
        private UCSubTasks ucSubTasks3;
        private UCSubTasks ucSubTasks4;
    }
}
