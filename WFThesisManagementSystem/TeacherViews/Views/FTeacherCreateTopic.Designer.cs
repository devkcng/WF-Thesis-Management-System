namespace WFThesisManagementSystem.TeacherViews.Views
{
    partial class FTeacherCreateTopic
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
            this.ucTeacherCreateTopic1 = new WFThesisManagementSystem.TeacherViews.TeacherUserControl.UcTeacherCreateTopic();
            this.SuspendLayout();
            // 
            // ucTeacherCreateTopic1
            // 
            this.ucTeacherCreateTopic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherCreateTopic1.Location = new System.Drawing.Point(1, 3);
            this.ucTeacherCreateTopic1.Name = "ucTeacherCreateTopic1";
            this.ucTeacherCreateTopic1.Size = new System.Drawing.Size(1404, 726);
            this.ucTeacherCreateTopic1.TabIndex = 0;
            // 
            // FTeacherCreateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 741);
            this.Controls.Add(this.ucTeacherCreateTopic1);
            this.Name = "FTeacherCreateTopic";
            this.Text = "FTeacherCreateTopic";
            this.ResumeLayout(false);

        }

        #endregion

        private TeacherUserControl.UcTeacherCreateTopic ucTeacherCreateTopic1;
    }
}