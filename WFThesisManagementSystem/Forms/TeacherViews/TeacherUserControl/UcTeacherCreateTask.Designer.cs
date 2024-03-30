namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherCreateTask
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTaskDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTaskId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblEndDate);
            this.guna2Panel3.Controls.Add(this.lblStartdate);
            this.guna2Panel3.Controls.Add(this.dtpEndDate);
            this.guna2Panel3.Controls.Add(this.dtpStartdate);
            this.guna2Panel3.Location = new System.Drawing.Point(150, 278);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(636, 93);
            this.guna2Panel3.TabIndex = 14;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(328, 10);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(134, 28);
            this.lblEndDate.TabIndex = 56;
            this.lblEndDate.Text = "End Date *";
            // 
            // lblStartdate
            // 
            this.lblStartdate.AutoSize = true;
            this.lblStartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartdate.ForeColor = System.Drawing.Color.White;
            this.lblStartdate.Location = new System.Drawing.Point(18, 10);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(142, 28);
            this.lblStartdate.TabIndex = 7;
            this.lblStartdate.Text = "Start Date *";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpEndDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpEndDate.BorderRadius = 8;
            this.dtpEndDate.BorderThickness = 2;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(333, 41);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(281, 52);
            this.dtpEndDate.TabIndex = 54;
            this.dtpEndDate.Value = new System.DateTime(2024, 3, 13, 10, 7, 4, 277);
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpStartdate.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpStartdate.BorderRadius = 8;
            this.dtpStartdate.BorderThickness = 2;
            this.dtpStartdate.Checked = true;
            this.dtpStartdate.FillColor = System.Drawing.Color.White;
            this.dtpStartdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartdate.Location = new System.Drawing.Point(19, 41);
            this.dtpStartdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(294, 52);
            this.dtpStartdate.TabIndex = 5;
            this.dtpStartdate.Value = new System.DateTime(2024, 3, 13, 10, 6, 52, 315);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtTaskName);
            this.guna2Panel1.Controls.Add(this.lblTaskName);
            this.guna2Panel1.Location = new System.Drawing.Point(150, 162);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(635, 93);
            this.guna2Panel1.TabIndex = 13;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTaskName.BorderRadius = 8;
            this.txtTaskName.BorderThickness = 2;
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.ForeColor = System.Drawing.Color.White;
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Location = new System.Drawing.Point(22, 48);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(589, 39);
            this.txtTaskName.TabIndex = 1;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(18, 14);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(160, 28);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name *";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnSave);
            this.guna2Panel5.Controls.Add(this.btnClose);
            this.guna2Panel5.Location = new System.Drawing.Point(627, 756);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(254, 56);
            this.guna2Panel5.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 56);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Location = new System.Drawing.Point(132, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(112, 78);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(695, 32);
            this.lblNote.TabIndex = 53;
            this.lblNote.Text = "This form is for teachers only. Students are not allowed to use it";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(315, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 28);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "CREATE A TASK FOR THESIS";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtTaskDescription);
            this.guna2Panel4.Controls.Add(this.lblTaskDescription);
            this.guna2Panel4.Location = new System.Drawing.Point(150, 544);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(635, 149);
            this.guna2Panel4.TabIndex = 56;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTaskDescription.BorderRadius = 8;
            this.txtTaskDescription.BorderThickness = 3;
            this.txtTaskDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskDescription.DefaultText = "";
            this.txtTaskDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.ForeColor = System.Drawing.Color.Black;
            this.txtTaskDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskDescription.Location = new System.Drawing.Point(19, 41);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.PasswordChar = '\0';
            this.txtTaskDescription.PlaceholderText = "";
            this.txtTaskDescription.SelectedText = "";
            this.txtTaskDescription.Size = new System.Drawing.Size(589, 92);
            this.txtTaskDescription.TabIndex = 7;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(18, 8);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(218, 28);
            this.lblTaskDescription.TabIndex = 6;
            this.lblTaskDescription.Text = "Task Description *";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.txtTaskId);
            this.guna2Panel2.Controls.Add(this.lblTaskId);
            this.guna2Panel2.Location = new System.Drawing.Point(150, 415);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(635, 84);
            this.guna2Panel2.TabIndex = 58;
            // 
            // txtTaskId
            // 
            this.txtTaskId.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTaskId.BorderRadius = 8;
            this.txtTaskId.BorderThickness = 2;
            this.txtTaskId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskId.DefaultText = "";
            this.txtTaskId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskId.ForeColor = System.Drawing.Color.Black;
            this.txtTaskId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskId.Location = new System.Drawing.Point(19, 39);
            this.txtTaskId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.PasswordChar = '\0';
            this.txtTaskId.PlaceholderText = "";
            this.txtTaskId.SelectedText = "";
            this.txtTaskId.Size = new System.Drawing.Size(595, 39);
            this.txtTaskId.TabIndex = 1;
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskId.ForeColor = System.Drawing.Color.White;
            this.lblTaskId.Location = new System.Drawing.Point(14, 10);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(111, 28);
            this.lblTaskId.TabIndex = 0;
            this.lblTaskId.Text = "Task Id *";
            // 
            // UcTeacherCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UcTeacherCreateTask";
            this.Size = new System.Drawing.Size(907, 824);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblStartdate;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpStartdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTitle;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public Guna.UI2.WinForms.Guna2TextBox txtTaskDescription;
        public System.Windows.Forms.Label lblTaskDescription;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2TextBox txtTaskId;
        public System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.Label lblEndDate;
    }
}
