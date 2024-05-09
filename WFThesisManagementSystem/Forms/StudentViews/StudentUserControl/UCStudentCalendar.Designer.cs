namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCStudentCalendar
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
            this.sdpCalendar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.sdpUpcomingEvent = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelUpcomingEventTitle = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flpSingleEvent = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCalendar1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCCalendar();
            this.sdpCalendar.SuspendLayout();
            this.sdpUpcomingEvent.SuspendLayout();
            this.panelUpcomingEventTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdpCalendar
            // 
            this.sdpCalendar.BackColor = System.Drawing.Color.Transparent;
            this.sdpCalendar.Controls.Add(this.ucCalendar1);
            this.sdpCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sdpCalendar.FillColor = System.Drawing.Color.White;
            this.sdpCalendar.Location = new System.Drawing.Point(0, 0);
            this.sdpCalendar.Name = "sdpCalendar";
            this.sdpCalendar.ShadowColor = System.Drawing.Color.Black;
            this.sdpCalendar.Size = new System.Drawing.Size(1891, 1237);
            this.sdpCalendar.TabIndex = 0;
            // 
            // sdpUpcomingEvent
            // 
            this.sdpUpcomingEvent.BackColor = System.Drawing.Color.Transparent;
            this.sdpUpcomingEvent.Controls.Add(this.flpSingleEvent);
            this.sdpUpcomingEvent.Controls.Add(this.panelUpcomingEventTitle);
            this.sdpUpcomingEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdpUpcomingEvent.FillColor = System.Drawing.Color.White;
            this.sdpUpcomingEvent.Location = new System.Drawing.Point(1891, 0);
            this.sdpUpcomingEvent.Name = "sdpUpcomingEvent";
            this.sdpUpcomingEvent.ShadowColor = System.Drawing.Color.Black;
            this.sdpUpcomingEvent.Size = new System.Drawing.Size(800, 1237);
            this.sdpUpcomingEvent.TabIndex = 1;
            // 
            // panelUpcomingEventTitle
            // 
            this.panelUpcomingEventTitle.BorderThickness = 10;
            this.panelUpcomingEventTitle.Controls.Add(this.label1);
            this.panelUpcomingEventTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpcomingEventTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelUpcomingEventTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(166)))), ((int)(((byte)(208)))));
            this.panelUpcomingEventTitle.Location = new System.Drawing.Point(0, 0);
            this.panelUpcomingEventTitle.Name = "panelUpcomingEventTitle";
            this.panelUpcomingEventTitle.Size = new System.Drawing.Size(800, 184);
            this.panelUpcomingEventTitle.TabIndex = 0;
            // 
            // flpSingleEvent
            // 
            this.flpSingleEvent.AutoScroll = true;
            this.flpSingleEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSingleEvent.Location = new System.Drawing.Point(0, 184);
            this.flpSingleEvent.Name = "flpSingleEvent";
            this.flpSingleEvent.Padding = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.flpSingleEvent.Size = new System.Drawing.Size(800, 1053);
            this.flpSingleEvent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcoming Event";
            // 
            // ucCalendar1
            // 
            this.ucCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalendar1.Location = new System.Drawing.Point(0, 0);
            this.ucCalendar1.Name = "ucCalendar1";
            this.ucCalendar1.Size = new System.Drawing.Size(1891, 1237);
            this.ucCalendar1.TabIndex = 0;
            // 
            // UCStudentCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdpUpcomingEvent);
            this.Controls.Add(this.sdpCalendar);
            this.Name = "UCStudentCalendar";
            this.Size = new System.Drawing.Size(2691, 1237);
            this.sdpCalendar.ResumeLayout(false);
            this.sdpUpcomingEvent.ResumeLayout(false);
            this.panelUpcomingEventTitle.ResumeLayout(false);
            this.panelUpcomingEventTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel sdpCalendar;
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpUpcomingEvent;
        private Guna.UI2.WinForms.Guna2GradientPanel panelUpcomingEventTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flpSingleEvent;
        public UCCalendar ucCalendar1;
    }
}
