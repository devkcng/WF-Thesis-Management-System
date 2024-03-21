namespace WFThesisManagementSystem.StudentViews.Views
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
            this.dgvTopics = new Guna.UI2.WinForms.Guna2DataGridView();
            this.topic_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_technology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopics
            // 
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
            this.teacher_id,
            this.teacher_name});
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
            this.dgvTopics.Location = new System.Drawing.Point(0, 39);
            this.dgvTopics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTopics.Name = "dgvTopics";
            this.dgvTopics.RowHeadersVisible = false;
            this.dgvTopics.RowHeadersWidth = 62;
            this.dgvTopics.RowTemplate.Height = 28;
            this.dgvTopics.Size = new System.Drawing.Size(718, 392);
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
            this.dgvTopics.ThemeStyle.ReadOnly = false;
            this.dgvTopics.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopics.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopics.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopics.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTopics.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTopics.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTopics.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTopics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopics_CellContentClick_1);
            // 
            // topic_id
            // 
            this.topic_id.HeaderText = "Topic Id";
            this.topic_id.MinimumWidth = 8;
            this.topic_id.Name = "topic_id";
            this.topic_id.Visible = false;
            // 
            // topic_name
            // 
            this.topic_name.HeaderText = "Topic Name";
            this.topic_name.MinimumWidth = 8;
            this.topic_name.Name = "topic_name";
            // 
            // topic_description
            // 
            this.topic_description.HeaderText = "Topic Description";
            this.topic_description.MinimumWidth = 8;
            this.topic_description.Name = "topic_description";
            // 
            // topic_technology
            // 
            this.topic_technology.HeaderText = "Topic Technology";
            this.topic_technology.MinimumWidth = 8;
            this.topic_technology.Name = "topic_technology";
            // 
            // topic_requirement
            // 
            this.topic_requirement.HeaderText = "Topic Requirement";
            this.topic_requirement.MinimumWidth = 8;
            this.topic_requirement.Name = "topic_requirement";
            // 
            // topic_category
            // 
            this.topic_category.HeaderText = "Category";
            this.topic_category.MinimumWidth = 8;
            this.topic_category.Name = "topic_category";
            // 
            // max_members
            // 
            this.max_members.HeaderText = "Max Members";
            this.max_members.MinimumWidth = 8;
            this.max_members.Name = "max_members";
            // 
            // teacher_id
            // 
            this.teacher_id.HeaderText = "Teacher ID";
            this.teacher_id.MinimumWidth = 8;
            this.teacher_id.Name = "teacher_id";
            // 
            // teacher_name
            // 
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.MinimumWidth = 8;
            this.teacher_name.Name = "teacher_name";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(465, 9);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(119, 36);
            this.guna2ComboBox1.TabIndex = 2;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(587, 9);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(119, 36);
            this.guna2ComboBox2.TabIndex = 3;
            // 
            // FStudentRegisterTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.dgvTopics);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FStudentRegisterTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentRegisterTopic";
            this.Load += new System.EventHandler(this.FStudentRegisterTopic_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTopics;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_technology;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_requirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_members;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
    }
}