namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCSTudentSubTasks
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
            this.btnPrevious = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dtpEndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panelMember = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flpAllMemberView = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelSubTasks = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel6 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnAssignTask = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            this.panelMember.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.panelSubTasks.SuspendLayout();
            this.guna2CustomGradientPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPrevious);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpEndDay);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpStartDay);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTo);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblFrom);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(70, 30);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(2676, 102);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::WFThesisManagementSystem.Properties.Resources.icons8_back_24;
            this.btnPrevious.ImageRotate = 0F;
            this.btnPrevious.Location = new System.Drawing.Point(20, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrevious.Size = new System.Drawing.Size(73, 81);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrevious.TabIndex = 51;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.BorderRadius = 10;
            this.dtpEndDay.Checked = true;
            this.dtpEndDay.FillColor = System.Drawing.Color.Tomato;
            this.dtpEndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(2373, 16);
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
            this.dtpStartDay.Location = new System.Drawing.Point(1618, 16);
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
            this.lblTo.Location = new System.Drawing.Point(2256, 22);
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
            this.lblFrom.Location = new System.Drawing.Point(1436, 22);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 47;
            this.lblFrom.Text = "From";
            // 
            // panelMember
            // 
            this.panelMember.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelMember.BorderRadius = 10;
            this.panelMember.BorderThickness = 2;
            this.panelMember.Controls.Add(this.flpAllMemberView);
            this.panelMember.Controls.Add(this.guna2CustomGradientPanel5);
            this.panelMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMember.Location = new System.Drawing.Point(70, 132);
            this.panelMember.Name = "panelMember";
            this.panelMember.Padding = new System.Windows.Forms.Padding(20);
            this.panelMember.Size = new System.Drawing.Size(824, 1364);
            this.panelMember.TabIndex = 2;
            // 
            // flpAllMemberView
            // 
            this.flpAllMemberView.AutoScroll = true;
            this.flpAllMemberView.BackColor = System.Drawing.Color.White;
            this.flpAllMemberView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllMemberView.Location = new System.Drawing.Point(20, 144);
            this.flpAllMemberView.Name = "flpAllMemberView";
            this.flpAllMemberView.Size = new System.Drawing.Size(784, 1200);
            this.flpAllMemberView.TabIndex = 1;
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Controls.Add(this.label2);
            this.guna2CustomGradientPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(20, 20);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(784, 124);
            this.guna2CustomGradientPanel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(894, 132);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(83, 1364);
            this.guna2CustomGradientPanel3.TabIndex = 3;
            // 
            // panelSubTasks
            // 
            this.panelSubTasks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelSubTasks.BorderRadius = 10;
            this.panelSubTasks.BorderThickness = 2;
            this.panelSubTasks.Controls.Add(this.flpAllTasks);
            this.panelSubTasks.Controls.Add(this.guna2CustomGradientPanel6);
            this.panelSubTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubTasks.Location = new System.Drawing.Point(977, 132);
            this.panelSubTasks.Name = "panelSubTasks";
            this.panelSubTasks.Padding = new System.Windows.Forms.Padding(20);
            this.panelSubTasks.Size = new System.Drawing.Size(1769, 1364);
            this.panelSubTasks.TabIndex = 4;
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BackColor = System.Drawing.Color.White;
            this.flpAllTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllTasks.Location = new System.Drawing.Point(20, 144);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Size = new System.Drawing.Size(1729, 1200);
            this.flpAllTasks.TabIndex = 2;
            // 
            // guna2CustomGradientPanel6
            // 
            this.guna2CustomGradientPanel6.Controls.Add(this.btnAssignTask);
            this.guna2CustomGradientPanel6.Controls.Add(this.label1);
            this.guna2CustomGradientPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel6.Location = new System.Drawing.Point(20, 20);
            this.guna2CustomGradientPanel6.Name = "guna2CustomGradientPanel6";
            this.guna2CustomGradientPanel6.Size = new System.Drawing.Size(1729, 124);
            this.guna2CustomGradientPanel6.TabIndex = 1;
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignTask.BorderColor = System.Drawing.Color.White;
            this.btnAssignTask.BorderRadius = 10;
            this.btnAssignTask.BorderThickness = 3;
            this.btnAssignTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssignTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssignTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssignTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssignTask.FillColor = System.Drawing.Color.Green;
            this.btnAssignTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Location = new System.Drawing.Point(1338, 21);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(367, 89);
            this.btnAssignTask.TabIndex = 85;
            this.btnAssignTask.Text = "ASSIGN TASK";
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invidual Task";
            // 
            // UCSTudentSubTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelSubTasks);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.panelMember);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UCSTudentSubTasks";
            this.Padding = new System.Windows.Forms.Padding(70, 30, 70, 20);
            this.Size = new System.Drawing.Size(2816, 1516);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            this.panelMember.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel5.PerformLayout();
            this.panelSubTasks.ResumeLayout(false);
            this.guna2CustomGradientPanel6.ResumeLayout(false);
            this.guna2CustomGradientPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDay;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelMember;
        public System.Windows.Forms.FlowLayoutPanel flpAllMemberView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelSubTasks;
        public System.Windows.Forms.FlowLayoutPanel flpAllTasks;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnPrevious;
        public Guna.UI2.WinForms.Guna2Button btnAssignTask;
    }
}
