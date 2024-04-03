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
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllMemberView = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1081, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 63);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 63);
            this.label1.TabIndex = 35;
            this.label1.Text = "Members";
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BackColor = System.Drawing.SystemColors.Control;
            this.flpAllTasks.Location = new System.Drawing.Point(1092, 255);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1701, 1217);
            this.flpAllTasks.TabIndex = 29;
            // 
            // flpAllMemberView
            // 
            this.flpAllMemberView.AutoScroll = true;
            this.flpAllMemberView.Location = new System.Drawing.Point(35, 255);
            this.flpAllMemberView.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllMemberView.Name = "flpAllMemberView";
            this.flpAllMemberView.Size = new System.Drawing.Size(938, 1217);
            this.flpAllMemberView.TabIndex = 30;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2063, 33);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 34;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1491, 33);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 33;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(1706, 27);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 70);
            this.dtpFrom.TabIndex = 32;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(2214, 28);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 31;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // UCSTudentSubTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpAllTasks);
            this.Controls.Add(this.flpAllMemberView);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Name = "UCSTudentSubTasks";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        public System.Windows.Forms.FlowLayoutPanel flpAllMemberView;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
    }
}
