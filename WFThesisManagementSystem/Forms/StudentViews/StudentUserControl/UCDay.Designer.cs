namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCDay
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
            this.lblDay = new System.Windows.Forms.Label();
            this.ptb3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ptb2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ptb1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDay.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(56, 32);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(68, 52);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "00";
            // 
            // ptb3
            // 
            this.ptb3.ImageRotate = 0F;
            this.ptb3.Location = new System.Drawing.Point(3, 63);
            this.ptb3.Name = "ptb3";
            this.ptb3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb3.Size = new System.Drawing.Size(29, 25);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb3.TabIndex = 4;
            this.ptb3.TabStop = false;
            this.ptb3.Visible = false;
            // 
            // ptb2
            // 
            this.ptb2.ImageRotate = 0F;
            this.ptb2.Location = new System.Drawing.Point(3, 32);
            this.ptb2.Name = "ptb2";
            this.ptb2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb2.Size = new System.Drawing.Size(29, 25);
            this.ptb2.TabIndex = 3;
            this.ptb2.TabStop = false;
            this.ptb2.Visible = false;
            // 
            // ptb1
            // 
            this.ptb1.ImageRotate = 0F;
            this.ptb1.Location = new System.Drawing.Point(3, 3);
            this.ptb1.Name = "ptb1";
            this.ptb1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb1.Size = new System.Drawing.Size(29, 25);
            this.ptb1.TabIndex = 2;
            this.ptb1.TabStop = false;
            this.ptb1.Visible = false;
            // 
            // UCDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ptb3);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.lblDay);
            this.Name = "UCDay";
            this.Size = new System.Drawing.Size(196, 126);
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDay;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb2;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb3;
    }
}
