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
            this.flowLayoutPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContainer
            // 
            this.flowLayoutPanelContainer.AutoScroll = true;
            this.flowLayoutPanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelContainer.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanelContainer.Name = "flowLayoutPanelContainer";
            this.flowLayoutPanelContainer.Size = new System.Drawing.Size(1226, 640);
            this.flowLayoutPanelContainer.TabIndex = 0;
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
            this.Controls.Add(this.flowLayoutPanelContainer);
            this.Name = "UCStudentWorkLogs";
            this.Size = new System.Drawing.Size(1226, 687);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContainer;
        private System.Windows.Forms.Label label1;
    }
}
