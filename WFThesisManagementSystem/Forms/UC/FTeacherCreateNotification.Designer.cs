namespace WFThesisManagementSystem.Forms.UC
{
    partial class FTeacherCreateNotification
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
            this.ucCreateNotification1 = new WFThesisManagementSystem.Forms.UC.UcCreateNotification();
            this.SuspendLayout();
            // 
            // ucCreateNotification1
            // 
            this.ucCreateNotification1.AutoScroll = true;
            this.ucCreateNotification1.BackColor = System.Drawing.Color.DarkKhaki;
            this.ucCreateNotification1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateNotification1.Location = new System.Drawing.Point(0, 0);
            this.ucCreateNotification1.Name = "ucCreateNotification1";
            this.ucCreateNotification1.Size = new System.Drawing.Size(889, 793);
            this.ucCreateNotification1.TabIndex = 0;
            // 
            // FTeacherCreateNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 793);
            this.Controls.Add(this.ucCreateNotification1);
            this.Name = "FTeacherCreateNotification";
            this.Text = "FTeacherCreateNotification";
            this.ResumeLayout(false);

        }

        #endregion

        public UcCreateNotification ucCreateNotification1;
    }
}