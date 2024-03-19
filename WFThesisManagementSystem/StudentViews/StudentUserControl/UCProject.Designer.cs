namespace WFThesisManagementSystem.Views.StudentViews
{
    partial class UCProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProject));
            this.lblComplete = new System.Windows.Forms.Label();
            this.panelContainerlblComplete = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptbIssue = new System.Windows.Forms.PictureBox();
            this.ptbLine = new System.Windows.Forms.PictureBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectDetail = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.panelContainerlblComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font(".VnBahamasB", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblComplete.Location = new System.Drawing.Point(18, 8);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(86, 22);
            this.lblComplete.TabIndex = 40;
            this.lblComplete.Text = "Completed";
            // 
            // panelContainerlblComplete
            // 
            this.panelContainerlblComplete.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerlblComplete.Controls.Add(this.lblComplete);
            this.panelContainerlblComplete.FillColor = System.Drawing.Color.PaleGreen;
            this.panelContainerlblComplete.Location = new System.Drawing.Point(1046, 4);
            this.panelContainerlblComplete.Name = "panelContainerlblComplete";
            this.panelContainerlblComplete.Radius = 4;
            this.panelContainerlblComplete.ShadowColor = System.Drawing.Color.Transparent;
            this.panelContainerlblComplete.Size = new System.Drawing.Size(107, 36);
            this.panelContainerlblComplete.TabIndex = 39;
            // 
            // ptbIssue
            // 
            this.ptbIssue.Image = ((System.Drawing.Image)(resources.GetObject("ptbIssue.Image")));
            this.ptbIssue.Location = new System.Drawing.Point(1023, 134);
            this.ptbIssue.Name = "ptbIssue";
            this.ptbIssue.Size = new System.Drawing.Size(40, 29);
            this.ptbIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIssue.TabIndex = 42;
            this.ptbIssue.TabStop = false;
            // 
            // ptbLine
            // 
            this.ptbLine.Image = ((System.Drawing.Image)(resources.GetObject("ptbLine.Image")));
            this.ptbLine.Location = new System.Drawing.Point(-11, 34);
            this.ptbLine.Name = "ptbLine";
            this.ptbLine.Size = new System.Drawing.Size(1164, 28);
            this.ptbLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLine.TabIndex = 3;
            this.ptbLine.TabStop = false;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(-2, 4);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(165, 29);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name";
            // 
            // txtProjectDetail
            // 
            this.txtProjectDetail.BackColor = System.Drawing.Color.White;
            this.txtProjectDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectDetail.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.txtProjectDetail.ForeColor = System.Drawing.Color.Silver;
            this.txtProjectDetail.Location = new System.Drawing.Point(3, 68);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.Size = new System.Drawing.Size(1150, 68);
            this.txtProjectDetail.TabIndex = 43;
            this.txtProjectDetail.Text = "Project Detail: cjavebvveve";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDeadline.Location = new System.Drawing.Point(-1, 141);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(199, 24);
            this.lblDeadline.TabIndex = 44;
            this.lblDeadline.Text = "Deadline: 05 APRIL 2023";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssue.ForeColor = System.Drawing.Color.Silver;
            this.lblIssue.Location = new System.Drawing.Point(1070, 139);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(83, 24);
            this.lblIssue.TabIndex = 45;
            this.lblIssue.Text = "14 issues";
            // 
            // UCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.txtProjectDetail);
            this.Controls.Add(this.ptbIssue);
            this.Controls.Add(this.panelContainerlblComplete);
            this.Controls.Add(this.ptbLine);
            this.Controls.Add(this.lblProjectName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProject";
            this.Size = new System.Drawing.Size(1160, 192);
            this.panelContainerlblComplete.ResumeLayout(false);
            this.panelContainerlblComplete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComplete;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelContainerlblComplete;
        private System.Windows.Forms.PictureBox ptbIssue;
        private System.Windows.Forms.PictureBox ptbLine;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectDetail;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblIssue;
    }
}
