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
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllGroupView = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ucInvidualTaskView1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCInvidualTaskView();
            this.ucTask1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCTask();
            this.ucTask2 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCTask();
            this.ucInvidualTaskView2 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCInvidualTaskView();
            this.ucInvidualTaskView3 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCInvidualTaskView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpAllTasks.SuspendLayout();
            this.flpAllGroupView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(29, 39);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(176, 63);
            this.lblTasks.TabIndex = 20;
            this.lblTasks.Text = "Tasks";
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTasks.Controls.Add(this.ucInvidualTaskView1);
            this.flpAllTasks.Controls.Add(this.ucInvidualTaskView2);
            this.flpAllTasks.Controls.Add(this.ucInvidualTaskView3);
            this.flpAllTasks.Location = new System.Drawing.Point(1421, 209);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1366, 1217);
            this.flpAllTasks.TabIndex = 19;
            // 
            // flpAllGroupView
            // 
            this.flpAllGroupView.AutoScroll = true;
            this.flpAllGroupView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllGroupView.Controls.Add(this.ucTask1);
            this.flpAllGroupView.Controls.Add(this.ucTask2);
            this.flpAllGroupView.Location = new System.Drawing.Point(34, 209);
            this.flpAllGroupView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllGroupView.Name = "flpAllGroupView";
            this.flpAllGroupView.Size = new System.Drawing.Size(1366, 1217);
            this.flpAllGroupView.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2330, 45);
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
            this.lblFrom.Location = new System.Drawing.Point(1758, 45);
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
            this.dtpFrom.Location = new System.Drawing.Point(1973, 39);
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
            this.dtpTo.Location = new System.Drawing.Point(2481, 40);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 23;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // ucInvidualTaskView1
            // 
            this.ucInvidualTaskView1.Location = new System.Drawing.Point(3, 3);
            this.ucInvidualTaskView1.Name = "ucInvidualTaskView1";
            this.ucInvidualTaskView1.Size = new System.Drawing.Size(1357, 322);
            this.ucInvidualTaskView1.TabIndex = 0;
            // 
            // ucTask1
            // 
            this.ucTask1.Location = new System.Drawing.Point(5, 5);
            this.ucTask1.Margin = new System.Windows.Forms.Padding(5);
            this.ucTask1.Name = "ucTask1";
            this.ucTask1.Size = new System.Drawing.Size(1357, 322);
            this.ucTask1.TabIndex = 0;
            // 
            // ucTask2
            // 
            this.ucTask2.Location = new System.Drawing.Point(5, 337);
            this.ucTask2.Margin = new System.Windows.Forms.Padding(5);
            this.ucTask2.Name = "ucTask2";
            this.ucTask2.Size = new System.Drawing.Size(1357, 322);
            this.ucTask2.TabIndex = 1;
            // 
            // ucInvidualTaskView2
            // 
            this.ucInvidualTaskView2.Location = new System.Drawing.Point(3, 331);
            this.ucInvidualTaskView2.Name = "ucInvidualTaskView2";
            this.ucInvidualTaskView2.Size = new System.Drawing.Size(1357, 322);
            this.ucInvidualTaskView2.TabIndex = 1;
            // 
            // ucInvidualTaskView3
            // 
            this.ucInvidualTaskView3.Location = new System.Drawing.Point(3, 659);
            this.ucInvidualTaskView3.Name = "ucInvidualTaskView3";
            this.ucInvidualTaskView3.Size = new System.Drawing.Size(1357, 322);
            this.ucInvidualTaskView3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 141);
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
            this.label2.Location = new System.Drawing.Point(1414, 141);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllTasks);
            this.Controls.Add(this.flpAllGroupView);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UCStudentTask";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.flpAllTasks.ResumeLayout(false);
            this.flpAllGroupView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private System.Windows.Forms.FlowLayoutPanel flpAllGroupView;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private UCInvidualTaskView ucInvidualTaskView1;
        private UCInvidualTaskView ucInvidualTaskView2;
        private UCInvidualTaskView ucInvidualTaskView3;
        private UCTask ucTask1;
        private UCTask ucTask2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
