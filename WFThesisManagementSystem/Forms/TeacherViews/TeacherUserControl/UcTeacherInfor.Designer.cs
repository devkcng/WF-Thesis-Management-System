namespace WFThesisManagementSystem.TeacherViews.TeacherUserControl
{
    partial class UcTeacherInfor
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
            this.ptbInfor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbInfor
            // 
            this.ptbInfor.BackColor = System.Drawing.SystemColors.Control;
            this.ptbInfor.ImageRotate = 0F;
            this.ptbInfor.Location = new System.Drawing.Point(71, 20);
            this.ptbInfor.Name = "ptbInfor";
            this.ptbInfor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbInfor.Size = new System.Drawing.Size(184, 184);
            this.ptbInfor.TabIndex = 0;
            this.ptbInfor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(71, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 178);
            this.panel1.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Image = global::WFThesisManagementSystem.Properties.Resources.coronavirus;
            this.lblCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountry.Location = new System.Drawing.Point(32, 132);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(142, 30);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "     Country";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Image = global::WFThesisManagementSystem.Properties.Resources.pin__1_;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(34, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(140, 30);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "     Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Image = global::WFThesisManagementSystem.Properties.Resources.user;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(34, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "     Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Location = new System.Drawing.Point(71, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 125);
            this.panel2.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Image = global::WFThesisManagementSystem.Properties.Resources.email;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(38, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 30);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "     Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Image = global::WFThesisManagementSystem.Properties.Resources.telephone_call;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(38, 19);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(124, 30);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "     Phone";
            // 
            // UcInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbInfor);
            this.Name = "UcInfor";
            this.Size = new System.Drawing.Size(322, 627);
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbInfor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
    }
}
