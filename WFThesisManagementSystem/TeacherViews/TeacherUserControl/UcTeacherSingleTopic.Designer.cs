namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherSingleTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTeacherSingleTopic));
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.plName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.plName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 149);
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
            this.btnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Location = new System.Drawing.Point(1087, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 48);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(46, 104);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1094, 20);
            this.lblLine.TabIndex = 5;
            this.lblLine.Text = resources.GetString("lblLine.Text");
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.Color.LightBlue;
            this.plName.Controls.Add(this.lblName);
            this.plName.Location = new System.Drawing.Point(50, 21);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(982, 73);
            this.plName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 30);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // UcTeacherSingleTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.plName);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnEdit);
            this.Name = "UcTeacherSingleTopic";
            this.Size = new System.Drawing.Size(1178, 229);
            this.Load += new System.EventHandler(this.UcTeacherSingleTopic_Load);
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btnEdit;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Panel plName;
        public System.Windows.Forms.Label lblName;
    }
}
