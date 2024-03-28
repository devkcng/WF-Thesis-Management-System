namespace WFThesisManagementSystem.StudentViews.Views
{
    partial class FRegisterTopic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvrRegisterMember = new Guna.UI2.WinForms.Guna2DataGridView();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblLoadTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblRequirement = new System.Windows.Forms.Label();
            this.lblLoadRequirement = new System.Windows.Forms.Label();
            this.lblTechnology = new System.Windows.Forms.Label();
            this.lblLoadTechnology = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLoadCategory = new System.Windows.Forms.Label();
            this.lblMaxMember = new System.Windows.Forms.Label();
            this.lblLoadMaxMember = new System.Windows.Forms.Label();
            this.txtGroupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrRegisterMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrRegisterMember
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvrRegisterMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrRegisterMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvrRegisterMember.ColumnHeadersHeight = 20;
            this.dgvrRegisterMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrRegisterMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_name,
            this.student_id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrRegisterMember.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvrRegisterMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrRegisterMember.Location = new System.Drawing.Point(1813, 250);
            this.dgvrRegisterMember.Margin = new System.Windows.Forms.Padding(5);
            this.dgvrRegisterMember.Name = "dgvrRegisterMember";
            this.dgvrRegisterMember.RowHeadersVisible = false;
            this.dgvrRegisterMember.RowHeadersWidth = 62;
            this.dgvrRegisterMember.RowTemplate.Height = 28;
            this.dgvrRegisterMember.Size = new System.Drawing.Size(988, 375);
            this.dgvrRegisterMember.TabIndex = 0;
            this.dgvrRegisterMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrRegisterMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvrRegisterMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvrRegisterMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvrRegisterMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvrRegisterMember.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvrRegisterMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrRegisterMember.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvrRegisterMember.ThemeStyle.ReadOnly = false;
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.Height = 28;
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrRegisterMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // student_name
            // 
            this.student_name.HeaderText = "Student Name";
            this.student_name.MinimumWidth = 8;
            this.student_name.Name = "student_name";
            // 
            // student_id
            // 
            this.student_id.HeaderText = "Student ID";
            this.student_id.MinimumWidth = 8;
            this.student_id.Name = "student_id";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.Location = new System.Drawing.Point(2442, 1121);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(251, 108);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicName.Location = new System.Drawing.Point(12, 23);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(464, 76);
            this.lblTopicName.TabIndex = 3;
            this.lblTopicName.Text = "TOPIC LABEL";
            // 
            // lblLoadTeacherName
            // 
            this.lblLoadTeacherName.AutoSize = true;
            this.lblLoadTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoadTeacherName.Location = new System.Drawing.Point(492, 238);
            this.lblLoadTeacherName.Name = "lblLoadTeacherName";
            this.lblLoadTeacherName.Size = new System.Drawing.Size(126, 46);
            this.lblLoadTeacherName.TabIndex = 4;
            this.lblLoadTeacherName.Text = "label1";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTeacherName.Location = new System.Drawing.Point(133, 238);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(294, 46);
            this.lblTeacherName.TabIndex = 5;
            this.lblTeacherName.Text = "Teacher Name:";
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRequirement.Location = new System.Drawing.Point(128, 542);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(258, 46);
            this.lblRequirement.TabIndex = 7;
            this.lblRequirement.Text = "Requirement:";
            // 
            // lblLoadRequirement
            // 
            this.lblLoadRequirement.AutoSize = true;
            this.lblLoadRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoadRequirement.Location = new System.Drawing.Point(487, 542);
            this.lblLoadRequirement.Name = "lblLoadRequirement";
            this.lblLoadRequirement.Size = new System.Drawing.Size(126, 46);
            this.lblLoadRequirement.TabIndex = 6;
            this.lblLoadRequirement.Text = "label1";
            // 
            // lblTechnology
            // 
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTechnology.Location = new System.Drawing.Point(821, 343);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(239, 46);
            this.lblTechnology.TabIndex = 9;
            this.lblTechnology.Text = "Technology:";
            // 
            // lblLoadTechnology
            // 
            this.lblLoadTechnology.AutoSize = true;
            this.lblLoadTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoadTechnology.Location = new System.Drawing.Point(1175, 343);
            this.lblLoadTechnology.Name = "lblLoadTechnology";
            this.lblLoadTechnology.Size = new System.Drawing.Size(126, 46);
            this.lblLoadTechnology.TabIndex = 8;
            this.lblLoadTechnology.Text = "label1";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(821, 238);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(193, 46);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // lblLoadCategory
            // 
            this.lblLoadCategory.AutoSize = true;
            this.lblLoadCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoadCategory.Location = new System.Drawing.Point(1180, 238);
            this.lblLoadCategory.Name = "lblLoadCategory";
            this.lblLoadCategory.Size = new System.Drawing.Size(126, 46);
            this.lblLoadCategory.TabIndex = 16;
            this.lblLoadCategory.Text = "label1";
            // 
            // lblMaxMember
            // 
            this.lblMaxMember.AutoSize = true;
            this.lblMaxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaxMember.Location = new System.Drawing.Point(133, 343);
            this.lblMaxMember.Name = "lblMaxMember";
            this.lblMaxMember.Size = new System.Drawing.Size(263, 46);
            this.lblMaxMember.TabIndex = 15;
            this.lblMaxMember.Text = "Max Member:";
            // 
            // lblLoadMaxMember
            // 
            this.lblLoadMaxMember.AutoSize = true;
            this.lblLoadMaxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoadMaxMember.Location = new System.Drawing.Point(492, 343);
            this.lblLoadMaxMember.Name = "lblLoadMaxMember";
            this.lblLoadMaxMember.Size = new System.Drawing.Size(126, 46);
            this.lblLoadMaxMember.TabIndex = 14;
            this.lblLoadMaxMember.Text = "label1";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.DefaultText = "";
            this.txtGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.Location = new System.Drawing.Point(1813, 102);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PasswordChar = '\0';
            this.txtGroupName.PlaceholderText = "";
            this.txtGroupName.SelectedText = "";
            this.txtGroupName.Size = new System.Drawing.Size(988, 117);
            this.txtGroupName.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(1539, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 46);
            this.label13.TabIndex = 19;
            this.label13.Text = "Group Name:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(2150, 1121);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(251, 108);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(419, 753);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(825, 431);
            this.txtDescription.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(133, 753);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 46);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description:";
            // 
            // FRegisterTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2838, 1283);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLoadCategory);
            this.Controls.Add(this.lblMaxMember);
            this.Controls.Add(this.lblLoadMaxMember);
            this.Controls.Add(this.lblTechnology);
            this.Controls.Add(this.lblLoadTechnology);
            this.Controls.Add(this.lblRequirement);
            this.Controls.Add(this.lblLoadRequirement);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblLoadTeacherName);
            this.Controls.Add(this.lblTopicName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvrRegisterMember);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRegisterTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvrRegisterMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvrRegisterMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblLoadTeacherName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblRequirement;
        private System.Windows.Forms.Label lblLoadRequirement;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.Label lblLoadTechnology;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLoadCategory;
        private System.Windows.Forms.Label lblMaxMember;
        private System.Windows.Forms.Label lblLoadMaxMember;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label5;
    }
}