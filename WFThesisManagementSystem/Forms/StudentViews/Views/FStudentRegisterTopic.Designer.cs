namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    partial class FStudentRegisterTopic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudentRegisterTopic));
            this.dgvTopics = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ptbReload = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.topic_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_technology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopics
            // 
            this.dgvTopics.AllowUserToAddRows = false;
            this.dgvTopics.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTopics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTopics.ColumnHeadersHeight = 38;
            this.dgvTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTopics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic_id,
            this.topic_name,
            this.topic_description,
            this.topic_technology,
            this.topic_requirement,
            this.topic_category,
            this.max_members,
            this.teacher_name,
            this.status_check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopics.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTopics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTopics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTopics.Location = new System.Drawing.Point(0, 174);
            this.dgvTopics.Name = "dgvTopics";
            this.dgvTopics.ReadOnly = true;
            this.dgvTopics.RowHeadersVisible = false;
            this.dgvTopics.RowHeadersWidth = 62;
            this.dgvTopics.RowTemplate.Height = 28;
            this.dgvTopics.Size = new System.Drawing.Size(1077, 489);
            this.dgvTopics.TabIndex = 0;
            this.dgvTopics.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopics.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTopics.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTopics.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTopics.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTopics.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopics.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTopics.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTopics.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTopics.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopics.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTopics.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTopics.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvTopics.ThemeStyle.ReadOnly = true;
            this.dgvTopics.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopics.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopics.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopics.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTopics.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTopics.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTopics.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTopics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopics_CellContentClick_1);
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(209, 97);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(454, 72);
            this.txtDescribe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Describe topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Topic List";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::WFThesisManagementSystem.Properties.Resources.Search1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(662, 99);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 72);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ptbReload
            // 
            this.ptbReload.Image = ((System.Drawing.Image)(resources.GetObject("ptbReload.Image")));
            this.ptbReload.ImageRotate = 0F;
            this.ptbReload.Location = new System.Drawing.Point(738, 97);
            this.ptbReload.Margin = new System.Windows.Forms.Padding(2);
            this.ptbReload.Name = "ptbReload";
            this.ptbReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbReload.Size = new System.Drawing.Size(63, 70);
            this.ptbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReload.TabIndex = 8;
            this.ptbReload.TabStop = false;
            this.ptbReload.Click += new System.EventHandler(this.ptbReload_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(855, 97);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(215, 74);
            this.btnDashBoard.TabIndex = 9;
            this.btnDashBoard.Text = "Back to DashBoard";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // topic_id
            // 
            this.topic_id.HeaderText = "Topic Id";
            this.topic_id.MinimumWidth = 8;
            this.topic_id.Name = "topic_id";
            this.topic_id.ReadOnly = true;
            this.topic_id.Visible = false;
            // 
            // topic_name
            // 
            this.topic_name.HeaderText = "Topic Name";
            this.topic_name.MinimumWidth = 8;
            this.topic_name.Name = "topic_name";
            this.topic_name.ReadOnly = true;
            // 
            // topic_description
            // 
            this.topic_description.HeaderText = "Topic Description";
            this.topic_description.MinimumWidth = 8;
            this.topic_description.Name = "topic_description";
            this.topic_description.ReadOnly = true;
            // 
            // topic_technology
            // 
            this.topic_technology.HeaderText = "Topic Technology";
            this.topic_technology.MinimumWidth = 8;
            this.topic_technology.Name = "topic_technology";
            this.topic_technology.ReadOnly = true;
            // 
            // topic_requirement
            // 
            this.topic_requirement.HeaderText = "Topic Requirement";
            this.topic_requirement.MinimumWidth = 8;
            this.topic_requirement.Name = "topic_requirement";
            this.topic_requirement.ReadOnly = true;
            // 
            // topic_category
            // 
            this.topic_category.HeaderText = "Category";
            this.topic_category.MinimumWidth = 8;
            this.topic_category.Name = "topic_category";
            this.topic_category.ReadOnly = true;
            // 
            // max_members
            // 
            this.max_members.HeaderText = "Max Members";
            this.max_members.MinimumWidth = 8;
            this.max_members.Name = "max_members";
            this.max_members.ReadOnly = true;
            // 
            // teacher_name
            // 
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.MinimumWidth = 8;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // status_check
            // 
            this.status_check.HeaderText = "Status";
            this.status_check.MinimumWidth = 8;
            this.status_check.Name = "status_check";
            this.status_check.ReadOnly = true;
            // 
            // FStudentRegisterTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 663);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.ptbReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.dgvTopics);
            this.Name = "FStudentRegisterTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentRegisterTopic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FStudentRegisterTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTopics;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbReload;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_technology;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_requirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_members;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_check;
    }
}