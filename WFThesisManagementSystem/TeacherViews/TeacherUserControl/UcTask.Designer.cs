namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTask
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
            this.lblNametopic = new System.Windows.Forms.Label();
            this.txtTopicname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxTopicrequire = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTopicrequire = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.dtpDateend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTopicdescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTopicdescription = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNametopic
            // 
            this.lblNametopic.AutoSize = true;
            this.lblNametopic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNametopic.Location = new System.Drawing.Point(14, 10);
            this.lblNametopic.Name = "lblNametopic";
            this.lblNametopic.Size = new System.Drawing.Size(153, 28);
            this.lblNametopic.TabIndex = 0;
            this.lblNametopic.Text = "Topic Name";
            // 
            // txtTopicname
            // 
            this.txtTopicname.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTopicname.BorderRadius = 8;
            this.txtTopicname.BorderThickness = 2;
            this.txtTopicname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTopicname.DefaultText = "";
            this.txtTopicname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTopicname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTopicname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopicname.ForeColor = System.Drawing.Color.White;
            this.txtTopicname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicname.Location = new System.Drawing.Point(0, 51);
            this.txtTopicname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTopicname.Name = "txtTopicname";
            this.txtTopicname.PasswordChar = '\0';
            this.txtTopicname.PlaceholderText = "";
            this.txtTopicname.SelectedText = "";
            this.txtTopicname.Size = new System.Drawing.Size(492, 52);
            this.txtTopicname.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtTopicname);
            this.guna2Panel1.Controls.Add(this.lblNametopic);
            this.guna2Panel1.Location = new System.Drawing.Point(33, 55);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(492, 102);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cbxTopicrequire);
            this.guna2Panel2.Controls.Add(this.lblTopicrequire);
            this.guna2Panel2.Location = new System.Drawing.Point(629, 55);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(492, 102);
            this.guna2Panel2.TabIndex = 3;
            // 
            // cbxTopicrequire
            // 
            this.cbxTopicrequire.BackColor = System.Drawing.Color.Transparent;
            this.cbxTopicrequire.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbxTopicrequire.BorderRadius = 8;
            this.cbxTopicrequire.BorderThickness = 2;
            this.cbxTopicrequire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTopicrequire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTopicrequire.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTopicrequire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTopicrequire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTopicrequire.ForeColor = System.Drawing.Color.White;
            this.cbxTopicrequire.ItemHeight = 30;
            this.cbxTopicrequire.Location = new System.Drawing.Point(0, 67);
            this.cbxTopicrequire.Name = "cbxTopicrequire";
            this.cbxTopicrequire.Size = new System.Drawing.Size(492, 36);
            this.cbxTopicrequire.TabIndex = 5;
            // 
            // lblTopicrequire
            // 
            this.lblTopicrequire.AutoSize = true;
            this.lblTopicrequire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicrequire.Location = new System.Drawing.Point(13, 10);
            this.lblTopicrequire.Name = "lblTopicrequire";
            this.lblTopicrequire.Size = new System.Drawing.Size(228, 28);
            this.lblTopicrequire.TabIndex = 5;
            this.lblTopicrequire.Text = "Topic Requirement";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblEnddate);
            this.guna2Panel3.Controls.Add(this.lblStartdate);
            this.guna2Panel3.Controls.Add(this.dtpDateend);
            this.guna2Panel3.Controls.Add(this.dtpStartdate);
            this.guna2Panel3.Location = new System.Drawing.Point(33, 192);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(603, 93);
            this.guna2Panel3.TabIndex = 4;
            // 
            // lblEnddate
            // 
            this.lblEnddate.AutoSize = true;
            this.lblEnddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnddate.Location = new System.Drawing.Point(312, 10);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(116, 28);
            this.lblEnddate.TabIndex = 8;
            this.lblEnddate.Text = "End Date";
            // 
            // lblStartdate
            // 
            this.lblStartdate.AutoSize = true;
            this.lblStartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartdate.Location = new System.Drawing.Point(3, 10);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(124, 28);
            this.lblStartdate.TabIndex = 7;
            this.lblStartdate.Text = "Start Date";
            // 
            // dtpDateend
            // 
            this.dtpDateend.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDateend.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpDateend.BorderRadius = 8;
            this.dtpDateend.BorderThickness = 2;
            this.dtpDateend.Checked = true;
            this.dtpDateend.FillColor = System.Drawing.Color.White;
            this.dtpDateend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateend.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateend.Location = new System.Drawing.Point(317, 40);
            this.dtpDateend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateend.Name = "dtpDateend";
            this.dtpDateend.Size = new System.Drawing.Size(283, 52);
            this.dtpDateend.TabIndex = 6;
            this.dtpDateend.Value = new System.DateTime(2024, 3, 13, 10, 7, 4, 277);
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
            this.dtpStartdate.Location = new System.Drawing.Point(0, 38);
            this.dtpStartdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(285, 52);
            this.dtpStartdate.TabIndex = 5;
            this.dtpStartdate.Value = new System.DateTime(2024, 3, 13, 10, 6, 52, 315);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtTopicdescription);
            this.guna2Panel4.Controls.Add(this.lblTopicdescription);
            this.guna2Panel4.Location = new System.Drawing.Point(33, 335);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1434, 147);
            this.guna2Panel4.TabIndex = 5;
            // 
            // txtTopicdescription
            // 
            this.txtTopicdescription.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTopicdescription.BorderRadius = 8;
            this.txtTopicdescription.BorderThickness = 3;
            this.txtTopicdescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTopicdescription.DefaultText = "";
            this.txtTopicdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTopicdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTopicdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicdescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTopicdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicdescription.Location = new System.Drawing.Point(0, 41);
            this.txtTopicdescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTopicdescription.Name = "txtTopicdescription";
            this.txtTopicdescription.PasswordChar = '\0';
            this.txtTopicdescription.PlaceholderText = "";
            this.txtTopicdescription.SelectedText = "";
            this.txtTopicdescription.Size = new System.Drawing.Size(1434, 106);
            this.txtTopicdescription.TabIndex = 7;
            // 
            // lblTopicdescription
            // 
            this.lblTopicdescription.AutoSize = true;
            this.lblTopicdescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicdescription.Location = new System.Drawing.Point(3, 0);
            this.lblTopicdescription.Name = "lblTopicdescription";
            this.lblTopicdescription.Size = new System.Drawing.Size(211, 28);
            this.lblTopicdescription.TabIndex = 6;
            this.lblTopicdescription.Text = "Topic Description";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.guna2Button2);
            this.guna2Panel5.Controls.Add(this.guna2Button1);
            this.guna2Panel5.Location = new System.Drawing.Point(1104, 619);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(254, 56);
            this.guna2Panel5.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(104, 56);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Create";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button1.Location = new System.Drawing.Point(132, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(122, 56);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Delete";
            // 
            // UcTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UcTask";
            this.Size = new System.Drawing.Size(1494, 726);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNametopic;
        private Guna.UI2.WinForms.Guna2TextBox txtTopicname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblTopicrequire;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblStartdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateend;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartdate;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTopicrequire;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTopicdescription;
        private System.Windows.Forms.Label lblTopicdescription;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
