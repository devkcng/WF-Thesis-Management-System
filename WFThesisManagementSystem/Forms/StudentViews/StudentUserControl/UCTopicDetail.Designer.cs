namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCTopicDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTopicDetail));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblMaxMembers = new System.Windows.Forms.Label();
            this.lblMaxMember = new System.Windows.Forms.Label();
            this.txtTechnology = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTeacherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTechnology = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtRequirement = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRequirement = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.guna2GradientPanel1.Controls.Add(this.panelContainer);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1550, 942);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(166)))));
            this.panelContainer.Controls.Add(this.txtRequirement);
            this.panelContainer.Controls.Add(this.lblRequirement);
            this.panelContainer.Controls.Add(this.lblMaxMembers);
            this.panelContainer.Controls.Add(this.lblMaxMember);
            this.panelContainer.Controls.Add(this.txtTechnology);
            this.panelContainer.Controls.Add(this.txtTeacherName);
            this.panelContainer.Controls.Add(this.lblTopicName);
            this.panelContainer.Controls.Add(this.txtCategory);
            this.panelContainer.Controls.Add(this.lblTeacherName);
            this.panelContainer.Controls.Add(this.txtDescription);
            this.panelContainer.Controls.Add(this.lblTechnology);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.lblCategory);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1550, 942);
            this.panelContainer.TabIndex = 49;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // lblMaxMembers
            // 
            this.lblMaxMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxMembers.AutoSize = true;
            this.lblMaxMembers.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMembers.Location = new System.Drawing.Point(1400, 39);
            this.lblMaxMembers.Name = "lblMaxMembers";
            this.lblMaxMembers.Size = new System.Drawing.Size(113, 40);
            this.lblMaxMembers.TabIndex = 70;
            this.lblMaxMembers.Text = "label1";
            // 
            // lblMaxMember
            // 
            this.lblMaxMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxMember.AutoSize = true;
            this.lblMaxMember.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMember.ForeColor = System.Drawing.Color.White;
            this.lblMaxMember.Location = new System.Drawing.Point(1173, 39);
            this.lblMaxMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxMember.Name = "lblMaxMember";
            this.lblMaxMember.Size = new System.Drawing.Size(211, 40);
            this.lblMaxMember.TabIndex = 69;
            this.lblMaxMember.Text = "Max Member:";
            // 
            // txtTechnology
            // 
            this.txtTechnology.AutoSize = true;
            this.txtTechnology.BorderRadius = 10;
            this.txtTechnology.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTechnology.DefaultText = resources.GetString("txtTechnology.DefaultText");
            this.txtTechnology.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTechnology.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTechnology.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTechnology.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTechnology.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTechnology.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.txtTechnology.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTechnology.Location = new System.Drawing.Point(17, 295);
            this.txtTechnology.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTechnology.Multiline = true;
            this.txtTechnology.Name = "txtTechnology";
            this.txtTechnology.PasswordChar = '\0';
            this.txtTechnology.PlaceholderText = "Type here";
            this.txtTechnology.ReadOnly = true;
            this.txtTechnology.SelectedText = "";
            this.txtTechnology.Size = new System.Drawing.Size(1501, 104);
            this.txtTechnology.TabIndex = 67;
            this.txtTechnology.TextChanged += new System.EventHandler(this.txtTechnology_TextChanged);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.AutoSize = true;
            this.txtTeacherName.BorderRadius = 10;
            this.txtTeacherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeacherName.DefaultText = resources.GetString("txtTeacherName.DefaultText");
            this.txtTeacherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeacherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeacherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeacherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeacherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.txtTeacherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeacherName.Location = new System.Drawing.Point(17, 146);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTeacherName.Multiline = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.PasswordChar = '\0';
            this.txtTeacherName.PlaceholderText = "Type here";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.SelectedText = "";
            this.txtTeacherName.Size = new System.Drawing.Size(388, 91);
            this.txtTeacherName.TabIndex = 64;
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicName.ForeColor = System.Drawing.Color.White;
            this.lblTopicName.Location = new System.Drawing.Point(-1, 12);
            this.lblTopicName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(349, 67);
            this.lblTopicName.TabIndex = 56;
            this.lblTopicName.Text = "TOPIC LABEL";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.BorderRadius = 10;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.DefaultText = resources.GetString("txtCategory.DefaultText");
            this.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.Location = new System.Drawing.Point(742, 146);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PlaceholderText = "Type here";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(777, 91);
            this.txtCategory.TabIndex = 65;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.White;
            this.lblTeacherName.Location = new System.Drawing.Point(4, 103);
            this.lblTeacherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(232, 40);
            this.lblTeacherName.TabIndex = 57;
            this.lblTeacherName.Text = "Teacher Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = resources.GetString("txtDescription.DefaultText");
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(17, 666);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Type here";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(1502, 231);
            this.txtDescription.TabIndex = 63;
            // 
            // lblTechnology
            // 
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnology.ForeColor = System.Drawing.Color.White;
            this.lblTechnology.Location = new System.Drawing.Point(4, 246);
            this.lblTechnology.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(188, 40);
            this.lblTechnology.TabIndex = 59;
            this.lblTechnology.Text = "Technology:";
            this.lblTechnology.Click += new System.EventHandler(this.lblTechnology_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 605);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 40);
            this.label5.TabIndex = 62;
            this.label5.Text = "Description:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(745, 103);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(155, 40);
            this.lblCategory.TabIndex = 61;
            this.lblCategory.Text = "Category:";
            // 
            // txtRequirement
            // 
            this.txtRequirement.AutoSize = true;
            this.txtRequirement.BorderRadius = 10;
            this.txtRequirement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequirement.DefaultText = resources.GetString("txtRequirement.DefaultText");
            this.txtRequirement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequirement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequirement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequirement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequirement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequirement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.txtRequirement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequirement.Location = new System.Drawing.Point(28, 451);
            this.txtRequirement.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtRequirement.Multiline = true;
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.PasswordChar = '\0';
            this.txtRequirement.PlaceholderText = "Type here";
            this.txtRequirement.ReadOnly = true;
            this.txtRequirement.SelectedText = "";
            this.txtRequirement.Size = new System.Drawing.Size(1491, 145);
            this.txtRequirement.TabIndex = 72;
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirement.ForeColor = System.Drawing.Color.White;
            this.lblRequirement.Location = new System.Drawing.Point(21, 402);
            this.lblRequirement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(209, 40);
            this.lblRequirement.TabIndex = 71;
            this.lblRequirement.Text = "Requirement:";
            // 
            // UCTopicDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UCTopicDetail";
            this.Size = new System.Drawing.Size(1550, 942);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        public Guna.UI2.WinForms.Guna2TextBox txtTechnology;
        public Guna.UI2.WinForms.Guna2TextBox txtTeacherName;
        public Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private System.Windows.Forms.Label lblTeacherName;
        public Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblTopicName;
        public System.Windows.Forms.Label lblMaxMembers;
        private System.Windows.Forms.Label lblMaxMember;
        public Guna.UI2.WinForms.Guna2GradientPanel panelContainer;
        public Guna.UI2.WinForms.Guna2TextBox txtRequirement;
        private System.Windows.Forms.Label lblRequirement;
    }
}
