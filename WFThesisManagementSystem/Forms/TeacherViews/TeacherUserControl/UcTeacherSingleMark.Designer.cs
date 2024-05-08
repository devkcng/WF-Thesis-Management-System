namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    partial class UcTeacherSingleMark
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
            this.txtPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPoint
            // 
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.DefaultText = "";
            this.txtPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.Location = new System.Drawing.Point(138, 82);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.PasswordChar = '\0';
            this.txtPoint.PlaceholderText = "";
            this.txtPoint.SelectedText = "";
            this.txtPoint.Size = new System.Drawing.Size(120, 52);
            this.txtPoint.TabIndex = 10;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.BackColor = System.Drawing.Color.Transparent;
            this.lblReview.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReview.Location = new System.Drawing.Point(53, 261);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(89, 28);
            this.lblReview.TabIndex = 9;
            this.lblReview.Text = "Review";
            // 
            // txtReview
            // 
            this.txtReview.BorderRadius = 10;
            this.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReview.DefaultText = "";
            this.txtReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Location = new System.Drawing.Point(48, 346);
            this.txtReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReview.Name = "txtReview";
            this.txtReview.PasswordChar = '\0';
            this.txtReview.PlaceholderText = "";
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(461, 210);
            this.txtReview.TabIndex = 14;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(43, 91);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(67, 28);
            this.lblPoint.TabIndex = 15;
            this.lblPoint.Text = "Point";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.txtReview);
            this.panelContainer.Controls.Add(this.lblPoint);
            this.panelContainer.Controls.Add(this.lblReview);
            this.panelContainer.Controls.Add(this.txtPoint);
            this.panelContainer.Location = new System.Drawing.Point(2, 2);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(562, 616);
            this.panelContainer.TabIndex = 16;
            // 
            // UcTeacherSingleMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelContainer);
            this.Name = "UcTeacherSingleMark";
            this.Size = new System.Drawing.Size(566, 614);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblReview;
        public Guna.UI2.WinForms.Guna2TextBox txtPoint;
        public Guna.UI2.WinForms.Guna2TextBox txtReview;
        public System.Windows.Forms.Label lblPoint;
        public System.Windows.Forms.Panel panelContainer;
    }
}
