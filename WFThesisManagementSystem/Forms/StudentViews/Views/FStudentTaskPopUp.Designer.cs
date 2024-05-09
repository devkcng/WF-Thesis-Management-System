namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    partial class FStudentTaskPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudentTaskPopUp));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ptbStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStudentname = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubmitDate = new System.Windows.Forms.Label();
            this.txtDocumentLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSubTaskName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.saveBtn);
            this.panelContainer.Controls.Add(this.editBtn);
            this.panelContainer.Controls.Add(this.ptbStatus);
            this.panelContainer.Controls.Add(this.lblStudentname);
            this.panelContainer.Controls.Add(this.btnSubmit);
            this.panelContainer.Controls.Add(this.lblSubmitDate);
            this.panelContainer.Controls.Add(this.txtDocumentLink);
            this.panelContainer.Controls.Add(this.pictureBox6);
            this.panelContainer.Controls.Add(this.pictureBox5);
            this.panelContainer.Controls.Add(this.pictureBox3);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Controls.Add(this.label15);
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.lblSubTaskName);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1198, 923);
            this.panelContainer.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.BorderColor = System.Drawing.Color.White;
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderThickness = 3;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.Green;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(825, 799);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(243, 89);
            this.saveBtn.TabIndex = 87;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BorderRadius = 10;
            this.editBtn.BorderThickness = 3;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.FillColor = System.Drawing.Color.White;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Location = new System.Drawing.Point(528, 799);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(243, 89);
            this.editBtn.TabIndex = 86;
            this.editBtn.Text = "EDIT";
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ptbStatus
            // 
            this.ptbStatus.Image = global::WFThesisManagementSystem.Properties.Resources.photo_2024_04_02_16_52_38;
            this.ptbStatus.ImageRotate = 0F;
            this.ptbStatus.Location = new System.Drawing.Point(375, 193);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbStatus.Size = new System.Drawing.Size(50, 43);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStatus.TabIndex = 85;
            this.ptbStatus.TabStop = false;
            // 
            // lblStudentname
            // 
            this.lblStudentname.AutoSize = true;
            this.lblStudentname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentname.Location = new System.Drawing.Point(366, 111);
            this.lblStudentname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentname.Name = "lblStudentname";
            this.lblStudentname.Size = new System.Drawing.Size(422, 54);
            this.lblStudentname.TabIndex = 83;
            this.lblStudentname.Text = "Make a suitable form";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.BorderRadius = 10;
            this.btnSubmit.BorderThickness = 3;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(825, 799);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(243, 89);
            this.btnSubmit.TabIndex = 84;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubmitDate
            // 
            this.lblSubmitDate.AutoSize = true;
            this.lblSubmitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitDate.ForeColor = System.Drawing.Color.Black;
            this.lblSubmitDate.Location = new System.Drawing.Point(368, 281);
            this.lblSubmitDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubmitDate.Name = "lblSubmitDate";
            this.lblSubmitDate.Size = new System.Drawing.Size(177, 39);
            this.lblSubmitDate.TabIndex = 82;
            this.lblSubmitDate.Text = "14/3/2024";
            // 
            // txtDocumentLink
            // 
            this.txtDocumentLink.BorderRadius = 10;
            this.txtDocumentLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentLink.DefaultText = "";
            this.txtDocumentLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocumentLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocumentLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumentLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumentLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumentLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentLink.Location = new System.Drawing.Point(434, 656);
            this.txtDocumentLink.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtDocumentLink.Name = "txtDocumentLink";
            this.txtDocumentLink.PasswordChar = '\0';
            this.txtDocumentLink.PlaceholderText = "";
            this.txtDocumentLink.SelectedText = "";
            this.txtDocumentLink.Size = new System.Drawing.Size(633, 52);
            this.txtDocumentLink.TabIndex = 81;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(41, 656);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 79;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(43, 284);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 78;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 123);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 200);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 486);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1130, 32);
            this.label15.TabIndex = 74;
            this.label15.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(106, 656);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 39);
            this.label9.TabIndex = 71;
            this.label9.Text = "Document Link";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(123, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 39);
            this.label7.TabIndex = 70;
            this.label7.Text = "Submit Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 46);
            this.label8.TabIndex = 69;
            this.label8.Text = "Attachment";
            // 
            // lblSubTaskName
            // 
            this.lblSubTaskName.AutoSize = true;
            this.lblSubTaskName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTaskName.Location = new System.Drawing.Point(43, 23);
            this.lblSubTaskName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTaskName.Name = "lblSubTaskName";
            this.lblSubTaskName.Size = new System.Drawing.Size(437, 54);
            this.lblSubTaskName.TabIndex = 66;
            this.lblSubTaskName.Text = "Make a suitable form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(123, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 39);
            this.label5.TabIndex = 68;
            this.label5.Text = "Owner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(126, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 39);
            this.label4.TabIndex = 67;
            this.label4.Text = "Status";
            // 
            // FStudentTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 923);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FStudentTaskPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentTaskPopUp";
            this.Load += new System.EventHandler(this.FStudentTaskPopUp_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptbStatus;
        public System.Windows.Forms.Label lblStudentname;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        public System.Windows.Forms.Label lblSubmitDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblSubTaskName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel panelContainer;
        public Guna.UI2.WinForms.Guna2TextBox txtDocumentLink;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button editBtn;
    }
}