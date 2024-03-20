namespace WFThesisManagementSystem.Views.StudentViews
{
    partial class UCStudentTask
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
            this.ucTask1 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask();
            this.ucTask2 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask();
            this.ucTask3 = new WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.ucTask1);
            this.flowLayoutPanel1.Controls.Add(this.ucTask2);
            this.flowLayoutPanel1.Controls.Add(this.ucTask3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1226, 626);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ucTask1
            // 
            this.ucTask1.Location = new System.Drawing.Point(3, 3);
            this.ucTask1.Name = "ucTask1";
            this.ucTask1.Size = new System.Drawing.Size(897, 119);
            this.ucTask1.TabIndex = 0;
            // 
            // ucTask2
            // 
            this.ucTask2.Location = new System.Drawing.Point(3, 128);
            this.ucTask2.Name = "ucTask2";
            this.ucTask2.Size = new System.Drawing.Size(897, 119);
            this.ucTask2.TabIndex = 1;
            // 
            // ucTask3
            // 
            this.ucTask3.Location = new System.Drawing.Point(3, 253);
            this.ucTask3.Name = "ucTask3";
            this.ucTask3.Size = new System.Drawing.Size(897, 119);
            this.ucTask3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnBahamasBH", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tasks";
            // 
            // UCStudentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCStudentTask";
            this.Size = new System.Drawing.Size(1226, 687);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask ucTask1;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask ucTask2;
        private WFThesisManagementSystem.StudentViews.StudentUserControl.UCTask ucTask3;
        private System.Windows.Forms.Label label1;
    }
}
