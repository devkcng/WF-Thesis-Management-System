using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
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
            this.ucTeacherAcceptRegistAll1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherAcceptRegistAll();
            this.btnRejectedList = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucTeacherAcceptRegistAll1
            // 
            this.ucTeacherAcceptRegistAll1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAcceptRegistAll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherAcceptRegistAll1.Location = new System.Drawing.Point(0, 0);
            this.ucTeacherAcceptRegistAll1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTeacherAcceptRegistAll1.Name = "ucTeacherAcceptRegistAll1";
            this.ucTeacherAcceptRegistAll1.Size = new System.Drawing.Size(1608, 1009);
            this.ucTeacherAcceptRegistAll1.TabIndex = 0;
            // 
            // btnRejectedList
            // 
            this.btnRejectedList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectedList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectedList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRejectedList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRejectedList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRejectedList.ForeColor = System.Drawing.Color.White;
            this.btnRejectedList.Location = new System.Drawing.Point(1263, 12);
            this.btnRejectedList.Name = "btnRejectedList";
            this.btnRejectedList.Size = new System.Drawing.Size(231, 72);
            this.btnRejectedList.TabIndex = 1;
            this.btnRejectedList.Text = "Rejected List";
            this.btnRejectedList.Click += new System.EventHandler(this.btnRejectedList_Click);
            // 
            // FTeacherRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 1009);
            this.Controls.Add(this.btnRejectedList);
            this.Controls.Add(this.ucTeacherAcceptRegistAll1);
            this.Name = "FTeacherRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherRegist";
            this.Load += new System.EventHandler(this.FTeacherRegist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UcTeacherAcceptRegistAll ucTeacherAcceptRegistAll1;
        private Guna.UI2.WinForms.Guna2Button btnRejectedList;
    }
}