namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcMinimized
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
            this.btnMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnMinimized
            // 
            this.btnMinimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimized.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.Image = global::WFThesisManagementSystem.Properties.Resources.minimize_sign;
            this.btnMinimized.ImageSize = new System.Drawing.Size(60, 60);
            this.btnMinimized.Location = new System.Drawing.Point(0, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(90, 90);
            this.btnMinimized.TabIndex = 0;
            // 
            // UcMinimized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMinimized);
            this.Name = "UcMinimized";
            this.Size = new System.Drawing.Size(90, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMinimized;
    }
}
