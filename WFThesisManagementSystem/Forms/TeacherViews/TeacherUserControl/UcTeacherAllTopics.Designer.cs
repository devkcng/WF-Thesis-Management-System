using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherAllTopics
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtpEndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flpTopicView = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpEndDay);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpStartDay);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTo);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblFrom);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(130, 20);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(2556, 102);
            this.guna2CustomGradientPanel1.TabIndex = 16;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.BorderRadius = 10;
            this.dtpEndDay.Checked = true;
            this.dtpEndDay.FillColor = System.Drawing.Color.Tomato;
            this.dtpEndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(2199, 16);
            this.dtpEndDay.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEndDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(290, 68);
            this.dtpEndDay.TabIndex = 50;
            this.dtpEndDay.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.BorderRadius = 10;
            this.dtpStartDay.Checked = true;
            this.dtpStartDay.FillColor = System.Drawing.Color.Green;
            this.dtpStartDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(1444, 16);
            this.dtpStartDay.Margin = new System.Windows.Forms.Padding(5);
            this.dtpStartDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(277, 70);
            this.dtpStartDay.TabIndex = 49;
            this.dtpStartDay.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2082, 22);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 48;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1262, 22);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 47;
            this.lblFrom.Text = "From";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.BorderThickness = 2;
            this.guna2CustomGradientPanel2.Controls.Add(this.flpTopicView);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel5);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(130, 122);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Padding = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(2556, 1374);
            this.guna2CustomGradientPanel2.TabIndex = 18;
            // 
            // flpTopicView
            // 
            this.flpTopicView.AutoScroll = true;
            this.flpTopicView.BackColor = System.Drawing.Color.White;
            this.flpTopicView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTopicView.Location = new System.Drawing.Point(20, 144);
            this.flpTopicView.Name = "flpTopicView";
            this.flpTopicView.Size = new System.Drawing.Size(2516, 1210);
            this.flpTopicView.TabIndex = 3;
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Controls.Add(this.btnCreate);
            this.guna2CustomGradientPanel5.Controls.Add(this.label2);
            this.guna2CustomGradientPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(20, 20);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(2516, 124);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topics";
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderThickness = 2;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(2071, 21);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(206, 70);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            // 
            // UcTeacherAllTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UcTeacherAllTopics";
            this.Padding = new System.Windows.Forms.Padding(130, 20, 130, 20);
            this.Size = new System.Drawing.Size(2816, 1516);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public UcTeacherSingleTopic ucTeacherSingleTopic1;
        private UcTeacherSingleTopic ucTeacherSingleTopic2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDay;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        public System.Windows.Forms.FlowLayoutPanel flpTopicView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Button btnCreate;
    }
}
