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
            this.dtpEndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(31, 23);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(69, 26);
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
            this.btnCreate.Location = new System.Drawing.Point(916, 23);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 29);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllTasks.Location = new System.Drawing.Point(495, 73);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(2);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(511, 512);
            this.flpAllTasks.TabIndex = 6;
            // 
            // flpAllGroupView
            // 
            this.flpAllGroupView.AutoScroll = true;
            this.flpAllGroupView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllGroupView.Location = new System.Drawing.Point(35, 73);
            this.flpAllGroupView.Margin = new System.Windows.Forms.Padding(2);
            this.flpAllGroupView.Name = "flpAllGroupView";
            this.flpAllGroupView.Size = new System.Drawing.Size(424, 512);
            this.flpAllGroupView.TabIndex = 14;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.BorderRadius = 10;
            this.dtpEndDay.Checked = true;
            this.dtpEndDay.FillColor = System.Drawing.Color.Tomato;
            this.dtpEndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(752, 24);
            this.dtpEndDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(109, 29);
            this.dtpEndDay.TabIndex = 15;
            this.dtpEndDay.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.BorderRadius = 10;
            this.dtpStartDay.Checked = true;
            this.dtpStartDay.FillColor = System.Drawing.Color.Green;
            this.dtpStartDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(561, 23);
            this.dtpStartDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(104, 29);
            this.dtpStartDay.TabIndex = 16;
            this.dtpStartDay.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(481, 26);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 22);
            this.lblFrom.TabIndex = 17;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(695, 26);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 22);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To";
            // 
            // UcTeacherAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.flpAllGroupView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.flpAllTasks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcTeacherAllTask";
            this.Size = new System.Drawing.Size(1056, 636);
            this.Load += new System.EventHandler(this.UcTeacherAllTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTasks;
        public Guna.UI2.WinForms.Guna2Button btnCreate;
        public System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        public System.Windows.Forms.FlowLayoutPanel flpAllGroupView;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDay;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }
}
