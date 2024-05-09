namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    partial class FTeacherMark
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucTeacherAllMark1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherAllMark();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucTeacherAllMark1);
            this.guna2Panel1.Location = new System.Drawing.Point(326, 58);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1349, 896);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ucTeacherAllMark1
            // 
            this.ucTeacherAllMark1.BackColor = System.Drawing.SystemColors.Control;
            this.ucTeacherAllMark1.Location = new System.Drawing.Point(0, 3);
            this.ucTeacherAllMark1.Name = "ucTeacherAllMark1";
            this.ucTeacherAllMark1.Size = new System.Drawing.Size(1349, 896);
            this.ucTeacherAllMark1.TabIndex = 0;
            // 
            // FTeacherMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FTeacherMark";
            this.Text = "FTeacherMark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTeacherMark_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TeacherUserControl.UcTeacherAllMark ucTeacherAllMark1;
    }
}