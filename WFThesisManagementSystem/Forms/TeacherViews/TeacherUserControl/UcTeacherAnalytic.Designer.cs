﻿namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAnalytic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgvTeacherRanking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectTaught = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentExcellent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteSubTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTeacherRanking = new System.Windows.Forms.Label();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherRanking)).BeginInit();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.BorderThickness = 2;
            this.guna2CustomGradientPanel2.Controls.Add(this.dgvTeacherRanking);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel5);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1584, 978);
            this.guna2CustomGradientPanel2.TabIndex = 19;
            // 
            // dgvTeacherRanking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTeacherRanking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeacherRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeacherRanking.ColumnHeadersHeight = 22;
            this.dgvTeacherRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeacherRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTeacher,
            this.SubjectTaught,
            this.StudentAverage,
            this.StudentGood,
            this.StudentExcellent,
            this.CompleteSubTask,
            this.Classification});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeacherRanking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeacherRanking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeacherRanking.Location = new System.Drawing.Point(14, 109);
            this.dgvTeacherRanking.Name = "dgvTeacherRanking";
            this.dgvTeacherRanking.RowHeadersVisible = false;
            this.dgvTeacherRanking.RowHeadersWidth = 62;
            this.dgvTeacherRanking.RowTemplate.Height = 28;
            this.dgvTeacherRanking.Size = new System.Drawing.Size(1556, 801);
            this.dgvTeacherRanking.TabIndex = 0;
            this.dgvTeacherRanking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeacherRanking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTeacherRanking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTeacherRanking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTeacherRanking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTeacherRanking.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeacherRanking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeacherRanking.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvTeacherRanking.ThemeStyle.ReadOnly = false;
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeacherRanking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // NameTeacher
            // 
            this.NameTeacher.HeaderText = "Name Teacher";
            this.NameTeacher.MinimumWidth = 8;
            this.NameTeacher.Name = "NameTeacher";
            // 
            // SubjectTaught
            // 
            this.SubjectTaught.HeaderText = "Subject Taught";
            this.SubjectTaught.MinimumWidth = 8;
            this.SubjectTaught.Name = "SubjectTaught";
            // 
            // StudentAverage
            // 
            this.StudentAverage.HeaderText = "Student Average";
            this.StudentAverage.MinimumWidth = 8;
            this.StudentAverage.Name = "StudentAverage";
            // 
            // StudentGood
            // 
            this.StudentGood.HeaderText = "Student Good";
            this.StudentGood.MinimumWidth = 8;
            this.StudentGood.Name = "StudentGood";
            // 
            // StudentExcellent
            // 
            this.StudentExcellent.HeaderText = "Student Excellent";
            this.StudentExcellent.MinimumWidth = 8;
            this.StudentExcellent.Name = "StudentExcellent";
            // 
            // CompleteSubTask
            // 
            this.CompleteSubTask.HeaderText = "Complete SubTask";
            this.CompleteSubTask.MinimumWidth = 8;
            this.CompleteSubTask.Name = "CompleteSubTask";
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Controls.Add(this.lblTeacherRanking);
            this.guna2CustomGradientPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(11, 13);
            this.guna2CustomGradientPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(1562, 80);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // lblTeacherRanking
            // 
            this.lblTeacherRanking.AutoSize = true;
            this.lblTeacherRanking.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherRanking.Location = new System.Drawing.Point(675, 18);
            this.lblTeacherRanking.Name = "lblTeacherRanking";
            this.lblTeacherRanking.Size = new System.Drawing.Size(263, 37);
            this.lblTeacherRanking.TabIndex = 0;
            this.lblTeacherRanking.Text = "Teacher Ranking";
            // 
            // Classification
            // 
            this.Classification.HeaderText = "Classification";
            this.Classification.MinimumWidth = 8;
            this.Classification.Name = "Classification";
            // 
            // UcTeacherAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "UcTeacherAnalytic";
            this.Size = new System.Drawing.Size(1584, 978);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherRanking)).EndInit();
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        public Guna.UI2.WinForms.Guna2DataGridView dgvTeacherRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectTaught;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentExcellent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteSubTask;
        private System.Windows.Forms.Label lblTeacherRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
    }
}
