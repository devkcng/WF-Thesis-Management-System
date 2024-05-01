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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ucTeacherAllMark1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherAllMark();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ucTeacherAllMark1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1900, 1026);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // ucTeacherAllMark1
            // 
            this.ucTeacherAllMark1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAllMark1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherAllMark1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherAllMark1.Name = "ucTeacherAllMark1";
            this.ucTeacherAllMark1.Size = new System.Drawing.Size(1900, 1026);
            this.ucTeacherAllMark1.TabIndex = 0;
            // 
            // FTeacherMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FTeacherMark";
            this.Text = "FTeacherMark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTeacherMark_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public TeacherUserControl.UcTeacherAllMark ucTeacherAllMark1;
    }
}