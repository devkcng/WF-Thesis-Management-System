namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcMaximize
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
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnMaximize
            // 
            this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::WFThesisManagementSystem.Properties.Resources.maximize;
            this.btnMaximize.ImageSize = new System.Drawing.Size(60, 60);
            this.btnMaximize.Location = new System.Drawing.Point(0, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(90, 90);
            this.btnMaximize.TabIndex = 0;
            // 
            // UcMaximize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMaximize);
            this.Name = "UcMaximize";
            this.Size = new System.Drawing.Size(90, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMaximize;
    }
}
