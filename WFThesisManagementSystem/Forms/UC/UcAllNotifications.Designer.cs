namespace WFThesisManagementSystem.Forms.UC
{
    partial class UcAllNotifications
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.flpAllNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(163, 64);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(175, 38);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "Notification";
            // 
            // flpAllNotifications
            // 
            this.flpAllNotifications.AutoScroll = true;
            this.flpAllNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllNotifications.Location = new System.Drawing.Point(170, 134);
            this.flpAllNotifications.Name = "flpAllNotifications";
            this.flpAllNotifications.Size = new System.Drawing.Size(1272, 787);
            this.flpAllNotifications.TabIndex = 14;
            // 
            // UcAllNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpAllNotifications);
            this.Controls.Add(this.lblNotification);
            this.Name = "UcAllNotifications";
            this.Size = new System.Drawing.Size(1584, 978);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotification;
        public System.Windows.Forms.FlowLayoutPanel flpAllNotifications;
    }
}
