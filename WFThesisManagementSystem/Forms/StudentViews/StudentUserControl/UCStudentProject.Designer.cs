namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCStudentProject
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTasks = new System.Windows.Forms.Label();
            this.flpAllTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblTasks);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(2228, 188);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(5, 59);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(336, 63);
            this.lblTasks.TabIndex = 39;
            this.lblTasks.Text = "Your Project";
            // 
            // flpAllTopics
            // 
            this.flpAllTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllTopics.Location = new System.Drawing.Point(0, 188);
            this.flpAllTopics.Name = "flpAllTopics";
            this.flpAllTopics.Padding = new System.Windows.Forms.Padding(350, 50, 0, 300);
            this.flpAllTopics.Size = new System.Drawing.Size(2228, 1049);
            this.flpAllTopics.TabIndex = 1;
            // 
            // UCStudentProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpAllTopics);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UCStudentProject";
            this.Size = new System.Drawing.Size(2228, 1237);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public System.Windows.Forms.Label lblTasks;
        public System.Windows.Forms.FlowLayoutPanel flpAllTopics;
    }
}
