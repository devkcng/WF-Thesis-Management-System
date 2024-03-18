namespace WFThesisManagementSystem.Views.StudentViews
{
    partial class UCStudentWorkLogs
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucWorkLog1 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog();
            this.ucWorkLog2 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog();
            this.ucWorkLog3 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.ucWorkLog1);
            this.flowLayoutPanel1.Controls.Add(this.ucWorkLog2);
            this.flowLayoutPanel1.Controls.Add(this.ucWorkLog3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1226, 640);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ucWorkLog1
            // 
            this.ucWorkLog1.Location = new System.Drawing.Point(3, 3);
            this.ucWorkLog1.Name = "ucWorkLog1";
            this.ucWorkLog1.Size = new System.Drawing.Size(1103, 119);
            this.ucWorkLog1.TabIndex = 0;
            // 
            // ucWorkLog2
            // 
            this.ucWorkLog2.Location = new System.Drawing.Point(3, 128);
            this.ucWorkLog2.Name = "ucWorkLog2";
            this.ucWorkLog2.Size = new System.Drawing.Size(1103, 119);
            this.ucWorkLog2.TabIndex = 1;
            // 
            // ucWorkLog3
            // 
            this.ucWorkLog3.Location = new System.Drawing.Point(3, 253);
            this.ucWorkLog3.Name = "ucWorkLog3";
            this.ucWorkLog3.Size = new System.Drawing.Size(1103, 119);
            this.ucWorkLog3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnBahamasBH", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "WorkLogs";
            // 
            // UCStudentWorkLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCStudentWorkLogs";
            this.Size = new System.Drawing.Size(1226, 687);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog ucWorkLog1;
        private System.Windows.Forms.Label label1;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog ucWorkLog2;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCWorkLog ucWorkLog3;
    }
}
