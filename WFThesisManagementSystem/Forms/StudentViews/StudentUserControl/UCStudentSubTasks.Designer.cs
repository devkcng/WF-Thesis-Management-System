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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flpAllTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 63);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sub Tasks";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(2332, 128);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(78, 54);
            this.lblTo.TabIndex = 35;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(1749, 132);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 54);
            this.lblFrom.TabIndex = 34;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.Green;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(1979, 121);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 70);
            this.dtpFrom.TabIndex = 33;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 2, 15, 42, 12, 488);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.Tomato;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(2465, 121);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(290, 68);
            this.dtpTo.TabIndex = 32;
            this.dtpTo.Value = new System.DateTime(2024, 4, 2, 16, 36, 24, 159);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblTo);
            this.guna2ShadowPanel1.Controls.Add(this.dtpTo);
            this.guna2ShadowPanel1.Controls.Add(this.dtpFrom);
            this.guna2ShadowPanel1.Controls.Add(this.lblFrom);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(2816, 241);
            this.guna2ShadowPanel1.TabIndex = 38;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.flpAllTasks);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 241);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(2816, 1275);
            this.guna2ShadowPanel2.TabIndex = 39;
            // 
            // flpAllTasks
            // 
            this.flpAllTasks.AutoScroll = true;
            this.flpAllTasks.BackColor = System.Drawing.Color.White;
            this.flpAllTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllTasks.Location = new System.Drawing.Point(0, 0);
            this.flpAllTasks.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllTasks.Name = "flpAllTasks";
            this.flpAllTasks.Padding = new System.Windows.Forms.Padding(400, 150, 300, 0);
            this.flpAllTasks.Size = new System.Drawing.Size(2816, 1275);
            this.flpAllTasks.TabIndex = 30;
            // 
            // UCSTudentSubTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UCSTudentSubTasks";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        public System.Windows.Forms.FlowLayoutPanel flpAllTasks;
    }
}
