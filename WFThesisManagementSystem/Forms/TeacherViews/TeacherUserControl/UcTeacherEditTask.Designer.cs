namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherEditTask
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
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTaskDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(54, 42);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(448, 21);
            this.lblNote.TabIndex = 62;
            this.lblNote.Text = "This form is for teachers only. Students are not allowed to use it";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(189, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 19);
            this.lblTitle.TabIndex = 61;
            this.lblTitle.Text = "EDITTING A TASK FOR THESIS";
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
            this.btnClose.Location = new System.Drawing.Point(501, 412);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(286, 412);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 36);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(394, 412);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 36);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtTaskDescription);
            this.guna2Panel4.Controls.Add(this.lblTaskDescription);
            this.guna2Panel4.Location = new System.Drawing.Point(90, 269);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(423, 97);
            this.guna2Panel4.TabIndex = 65;
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
            this.txtTaskDescription.Location = new System.Drawing.Point(13, 27);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.PasswordChar = '\0';
            this.txtTaskDescription.PlaceholderText = "";
            this.txtTaskDescription.SelectedText = "";
            this.txtTaskDescription.Size = new System.Drawing.Size(393, 60);
            this.txtTaskDescription.TabIndex = 7;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(18, 5);
            this.lblTaskDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(142, 19);
            this.lblTaskDescription.TabIndex = 6;
            this.lblTaskDescription.Text = "Task Description *";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblDueDate);
            this.guna2Panel3.Controls.Add(this.dtpDueDate);
            this.guna2Panel3.Location = new System.Drawing.Point(90, 177);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(424, 68);
            this.guna2Panel3.TabIndex = 64;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(18, 8);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(91, 19);
            this.lblDueDate.TabIndex = 56;
            this.lblDueDate.Text = "Due Date *";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDueDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpDueDate.BorderRadius = 8;
            this.dtpDueDate.BorderThickness = 2;
            this.dtpDueDate.Checked = true;
            this.dtpDueDate.FillColor = System.Drawing.Color.White;
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(21, 29);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(384, 34);
            this.dtpDueDate.TabIndex = 54;
            this.dtpDueDate.Value = new System.DateTime(2024, 3, 13, 10, 7, 4, 277);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtTaskName);
            this.guna2Panel1.Controls.Add(this.lblTaskName);
            this.guna2Panel1.Location = new System.Drawing.Point(90, 91);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(423, 60);
            this.guna2Panel1.TabIndex = 63;
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
            this.txtTaskName.ForeColor = System.Drawing.Color.Black;
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Location = new System.Drawing.Point(15, 31);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(393, 25);
            this.txtTaskName.TabIndex = 1;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(11, 9);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(106, 19);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name *";
            // 
            // UcTeacherEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcTeacherEditTask";
            this.Size = new System.Drawing.Size(605, 482);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTitle;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public Guna.UI2.WinForms.Guna2TextBox txtTaskDescription;
        public System.Windows.Forms.Label lblTaskDescription;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblDueDate;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpDueDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
    }
}
