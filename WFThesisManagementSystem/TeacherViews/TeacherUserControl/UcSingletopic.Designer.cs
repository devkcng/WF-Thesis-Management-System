namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcSingletopic
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
            this.lblNametopic = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.lblOfftrack = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNametopic
            // 
            this.lblNametopic.AutoSize = true;
            this.lblNametopic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNametopic.Location = new System.Drawing.Point(44, 49);
            this.lblNametopic.Name = "lblNametopic";
            this.lblNametopic.Size = new System.Drawing.Size(81, 32);
            this.lblNametopic.TabIndex = 2;
            this.lblNametopic.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 30);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::WFThesisManagementSystem.Properties.Resources.Create;
            this.btnEdit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEdit.Location = new System.Drawing.Point(131, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 66);
            this.btnEdit.TabIndex = 1;
            // 
            // lblOfftrack
            // 
            this.lblOfftrack.AutoSize = true;
            this.lblOfftrack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfftrack.Location = new System.Drawing.Point(326, 49);
            this.lblOfftrack.Name = "lblOfftrack";
            this.lblOfftrack.Size = new System.Drawing.Size(116, 38);
            this.lblOfftrack.TabIndex = 4;
            this.lblOfftrack.Text = "Offtrack";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(21, 103);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(449, 20);
            this.lblLine.TabIndex = 5;
            this.lblLine.Text = "---------------------------------------------------------------------------------" +
    "-------";
            // 
            // UcSingletopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblOfftrack);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNametopic);
            this.Controls.Add(this.btnEdit);
            this.Name = "UcSingletopic";
            this.Size = new System.Drawing.Size(488, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label lblNametopic;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOfftrack;
        private System.Windows.Forms.Label lblLine;
    }
}
