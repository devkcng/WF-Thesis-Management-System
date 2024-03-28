namespace WFThesisManagementSystem.TeacherViews.Views
{
    partial class FTeacherRegist
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
            this.ucTeacherAcceptRegistAll1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherAcceptRegistAll();
            this.SuspendLayout();
            // 
            // ucTeacherAcceptRegistAll1
            // 
            this.ucTeacherAcceptRegistAll1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAcceptRegistAll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherAcceptRegistAll1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherAcceptRegistAll1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucTeacherAcceptRegistAll1.Name = "ucTeacherAcceptRegistAll1";
            this.ucTeacherAcceptRegistAll1.Size = new System.Drawing.Size(1072, 656);
            this.ucTeacherAcceptRegistAll1.TabIndex = 0;
            // 
            // FTeacherRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 656);
            this.Controls.Add(this.ucTeacherAcceptRegistAll1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FTeacherRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherRegist";
            this.Load += new System.EventHandler(this.FTeacherRegist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TeacherUserControl.UcTeacherAcceptRegistAll ucTeacherAcceptRegistAll1;
    }
}