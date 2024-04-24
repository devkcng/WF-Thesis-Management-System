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
            this.flpAllNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpAllNotifications
            // 
            this.flpAllNotifications.AutoScroll = true;
            this.flpAllNotifications.BackColor = System.Drawing.Color.White;
            this.flpAllNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAllNotifications.Location = new System.Drawing.Point(0, 0);
            this.flpAllNotifications.Margin = new System.Windows.Forms.Padding(5);
            this.flpAllNotifications.Name = "flpAllNotifications";
            this.flpAllNotifications.Size = new System.Drawing.Size(2816, 1516);
            this.flpAllNotifications.TabIndex = 14;
            // 
            // UcAllNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpAllNotifications);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UcAllNotifications";
            this.Size = new System.Drawing.Size(2816, 1516);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flpAllNotifications;
    }
}
