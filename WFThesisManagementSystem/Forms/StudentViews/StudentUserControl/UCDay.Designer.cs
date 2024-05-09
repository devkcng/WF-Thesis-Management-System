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
            this.splitPanelDay = new System.Windows.Forms.SplitContainer();
            this.ptb3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ptb2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ptb1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanelDay)).BeginInit();
            this.splitPanelDay.Panel1.SuspendLayout();
            this.splitPanelDay.Panel2.SuspendLayout();
            this.splitPanelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPanelDay
            // 
            this.splitPanelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanelDay.Location = new System.Drawing.Point(0, 0);
            this.splitPanelDay.Name = "splitPanelDay";
            // 
            // splitPanelDay.Panel1
            // 
            this.splitPanelDay.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitPanelDay.Panel2
            // 
            this.splitPanelDay.Panel2.Controls.Add(this.lblDay);
            this.splitPanelDay.Size = new System.Drawing.Size(260, 203);
            this.splitPanelDay.SplitterDistance = 57;
            this.splitPanelDay.TabIndex = 0;
            // 
            // ptb3
            // 
            this.ptb3.ImageRotate = 0F;
            this.ptb3.Location = new System.Drawing.Point(3, 139);
            this.ptb3.Name = "ptb3";
            this.ptb3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb3.Size = new System.Drawing.Size(40, 40);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb3.TabIndex = 8;
            this.ptb3.TabStop = false;
            this.ptb3.Visible = false;
            // 
            // ptb2
            // 
            this.ptb2.ImageRotate = 0F;
            this.ptb2.Location = new System.Drawing.Point(3, 71);
            this.ptb2.Name = "ptb2";
            this.ptb2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb2.Size = new System.Drawing.Size(40, 40);
            this.ptb2.TabIndex = 7;
            this.ptb2.TabStop = false;
            this.ptb2.Visible = false;
            // 
            // ptb1
            // 
            this.ptb1.ImageRotate = 0F;
            this.ptb1.Location = new System.Drawing.Point(3, 3);
            this.ptb1.Name = "ptb1";
            this.ptb1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb1.Size = new System.Drawing.Size(40, 40);
            this.ptb1.TabIndex = 6;
            this.ptb1.TabStop = false;
            this.ptb1.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDay.Font = new System.Drawing.Font("Cambria", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(3, 61);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(114, 79);
            this.lblDay.TabIndex = 5;
            this.lblDay.Text = "00";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ptb3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ptb2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(57, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UCDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitPanelDay);
            this.Name = "UCDay";
            this.Size = new System.Drawing.Size(260, 203);
            this.splitPanelDay.Panel1.ResumeLayout(false);
            this.splitPanelDay.Panel2.ResumeLayout(false);
            this.splitPanelDay.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanelDay)).EndInit();
            this.splitPanelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPanelDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb3;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb2;
        public Guna.UI2.WinForms.Guna2CirclePictureBox ptb1;
        public System.Windows.Forms.Label lblDay;
    }
}
