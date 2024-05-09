namespace WFThesisManagementSystem.Forms.UC
{
    partial class FNotificationSendStudent
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
            this.ucNotificationSendStudentAll1 = new WFThesisManagementSystem.Forms.UC.UcNotificationSendStudentAll();
            this.SuspendLayout();
            // 
            // ucNotificationSendStudentAll1
            // 
            this.ucNotificationSendStudentAll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotificationSendStudentAll1.Location = new System.Drawing.Point(0, 0);
            this.ucNotificationSendStudentAll1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ucNotificationSendStudentAll1.Name = "ucNotificationSendStudentAll1";
            this.ucNotificationSendStudentAll1.Size = new System.Drawing.Size(2777, 1564);
            this.ucNotificationSendStudentAll1.TabIndex = 0;
            // 
            // FNotificationSendStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2777, 1564);
            this.Controls.Add(this.ucNotificationSendStudentAll1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FNotificationSendStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNotificationSendStudent";
            this.Load += new System.EventHandler(this.FNotificationSendStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UcNotificationSendStudentAll ucNotificationSendStudentAll1;
    }
}