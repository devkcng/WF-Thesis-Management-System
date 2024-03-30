namespace WFThesisManagementSystem.Views.StudentViews
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
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.flowLayoutPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(564, 769);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Previous";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(915, 769);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Next";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProject.Font = new System.Drawing.Font(".VnBahamasBH", 15F, System.Drawing.FontStyle.Bold);
            this.lblProject.Location = new System.Drawing.Point(0, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(147, 44);
            this.lblProject.TabIndex = 54;
            this.lblProject.Text = "Projects";
            this.lblProject.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanelContainer
            // 
            this.flowLayoutPanelContainer.AutoScroll = true;
            this.flowLayoutPanelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelContainer.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanelContainer.Name = "flowLayoutPanelContainer";
            this.flowLayoutPanelContainer.Size = new System.Drawing.Size(1253, 649);
            this.flowLayoutPanelContainer.TabIndex = 53;
            // 
            // UCStudentProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.flowLayoutPanelContainer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCStudentProject";
            this.Size = new System.Drawing.Size(1253, 718);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContainer;
    }
}
