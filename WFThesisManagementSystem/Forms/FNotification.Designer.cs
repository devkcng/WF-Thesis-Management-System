namespace WFThesisManagementSystem.Forms
{
    partial class FNotification
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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.msMenuNotification = new System.Windows.Forms.MenuStrip();
            this.tsmiCompose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInbox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnread = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucAllNotifications1 = new WFThesisManagementSystem.Forms.UC.UcAllNotifications();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitaskAssignment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmigroupAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmionlineMeeting = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            this.msMenuNotification.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(292, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1107, 74);
            this.txtSearch.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.msMenuNotification);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 146);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(289, 639);
            this.guna2Panel1.TabIndex = 1;
            // 
            // msMenuNotification
            // 
            this.msMenuNotification.BackColor = System.Drawing.Color.Transparent;
            this.msMenuNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msMenuNotification.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenuNotification.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenuNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompose,
            this.tsmiInbox,
            this.tsmiRead,
            this.tsmiUnread,
            this.tsmiSend,
            this.tsmiExit});
            this.msMenuNotification.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMenuNotification.Location = new System.Drawing.Point(0, 0);
            this.msMenuNotification.Name = "msMenuNotification";
            this.msMenuNotification.Size = new System.Drawing.Size(289, 258);
            this.msMenuNotification.TabIndex = 0;
            this.msMenuNotification.Text = "menuStrip1";
            // 
            // tsmiCompose
            // 
            this.tsmiCompose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCompose.Image = global::WFThesisManagementSystem.Properties.Resources.writing;
            this.tsmiCompose.Name = "tsmiCompose";
            this.tsmiCompose.Size = new System.Drawing.Size(282, 42);
            this.tsmiCompose.Text = "Compose";
            this.tsmiCompose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiCompose.Click += new System.EventHandler(this.tsmiCompose_Click);
            // 
            // tsmiInbox
            // 
            this.tsmiInbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiInbox.Image = global::WFThesisManagementSystem.Properties.Resources.inbox;
            this.tsmiInbox.Name = "tsmiInbox";
            this.tsmiInbox.Size = new System.Drawing.Size(282, 42);
            this.tsmiInbox.Text = "InBox";
            this.tsmiInbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiRead
            // 
            this.tsmiRead.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRead.Image = global::WFThesisManagementSystem.Properties.Resources.open_book;
            this.tsmiRead.Name = "tsmiRead";
            this.tsmiRead.Size = new System.Drawing.Size(282, 42);
            this.tsmiRead.Text = "Read";
            this.tsmiRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiUnread
            // 
            this.tsmiUnread.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiUnread.Image = global::WFThesisManagementSystem.Properties.Resources.email1;
            this.tsmiUnread.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiUnread.Name = "tsmiUnread";
            this.tsmiUnread.Size = new System.Drawing.Size(282, 42);
            this.tsmiUnread.Text = "UnRead";
            // 
            // tsmiSend
            // 
            this.tsmiSend.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSend.Image = global::WFThesisManagementSystem.Properties.Resources.mail;
            this.tsmiSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiSend.Name = "tsmiSend";
            this.tsmiSend.Size = new System.Drawing.Size(282, 42);
            this.tsmiSend.Text = "Send";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiExit.Image = global::WFThesisManagementSystem.Properties.Resources.exit;
            this.tsmiExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(282, 42);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lblNotifications);
            this.guna2Panel2.Location = new System.Drawing.Point(2, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(289, 144);
            this.guna2Panel2.TabIndex = 2;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(43, 49);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(208, 38);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.ucAllNotifications1);
            this.guna2Panel3.Controls.Add(this.ms);
            this.guna2Panel3.Location = new System.Drawing.Point(292, 82);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1107, 694);
            this.guna2Panel3.TabIndex = 3;
            // 
            // ucAllNotifications1
            // 
            this.ucAllNotifications1.Location = new System.Drawing.Point(0, 64);
            this.ucAllNotifications1.Name = "ucAllNotifications1";
            this.ucAllNotifications1.Size = new System.Drawing.Size(1107, 641);
            this.ucAllNotifications1.TabIndex = 1;
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.Transparent;
            this.ms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ms.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1107, 46);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Image = global::WFThesisManagementSystem.Properties.Resources.book;
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(158, 42);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmitaskAssignment,
            this.tsmigroupAcceptance,
            this.tsmionlineMeeting});
            this.typesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typesToolStripMenuItem.Image = global::WFThesisManagementSystem.Properties.Resources.laptop;
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(131, 42);
            this.typesToolStripMenuItem.Text = "Types";
            // 
            // tsmitaskAssignment
            // 
            this.tsmitaskAssignment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmitaskAssignment.ForeColor = System.Drawing.Color.Black;
            this.tsmitaskAssignment.Name = "tsmitaskAssignment";
            this.tsmitaskAssignment.Size = new System.Drawing.Size(287, 38);
            this.tsmitaskAssignment.Text = "Task Assignment";
            // 
            // tsmigroupAcceptance
            // 
            this.tsmigroupAcceptance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmigroupAcceptance.ForeColor = System.Drawing.Color.Black;
            this.tsmigroupAcceptance.Name = "tsmigroupAcceptance";
            this.tsmigroupAcceptance.Size = new System.Drawing.Size(287, 38);
            this.tsmigroupAcceptance.Text = "GroupAcceptance";
            // 
            // tsmionlineMeeting
            // 
            this.tsmionlineMeeting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmionlineMeeting.ForeColor = System.Drawing.Color.Black;
            this.tsmionlineMeeting.Name = "tsmionlineMeeting";
            this.tsmionlineMeeting.Size = new System.Drawing.Size(287, 38);
            this.tsmionlineMeeting.Text = "Online Meeting";
            // 
            // FNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1667, 788);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txtSearch);
            this.MainMenuStrip = this.msMenuNotification;
            this.Name = "FNotification";
            this.Text = "FNotification";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.msMenuNotification.ResumeLayout(false);
            this.msMenuNotification.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.MenuStrip msMenuNotification;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompose;
        private System.Windows.Forms.ToolStripMenuItem tsmiRead;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnread;
        private System.Windows.Forms.ToolStripMenuItem tsmiSend;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInbox;
        private UC.UcAllNotifications ucAllNotifications1;
        private System.Windows.Forms.ToolStripMenuItem tsmitaskAssignment;
        private System.Windows.Forms.ToolStripMenuItem tsmigroupAcceptance;
        private System.Windows.Forms.ToolStripMenuItem tsmionlineMeeting;
    }
}