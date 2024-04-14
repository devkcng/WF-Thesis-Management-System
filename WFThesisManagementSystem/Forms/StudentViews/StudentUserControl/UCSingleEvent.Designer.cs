namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCSingleEvent
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lbEventName = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.BorderThickness = 5;
            this.guna2GradientPanel1.Controls.Add(this.lblDay);
            this.guna2GradientPanel1.Controls.Add(this.lbEventName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 196);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Cambria", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(315, 133);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(148, 40);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "3 day left";
            // 
            // lbEventName
            // 
            this.lbEventName.AutoSize = true;
            this.lbEventName.Font = new System.Drawing.Font("Cambria", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventName.Location = new System.Drawing.Point(15, 16);
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(229, 55);
            this.lbEventName.TabIndex = 2;
            this.lbEventName.Text = "Design UI";
            // 
            // UCSingleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UCSingleEvent";
            this.Size = new System.Drawing.Size(800, 196);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        public System.Windows.Forms.Label lblDay;
        public System.Windows.Forms.Label lbEventName;
    }
}
