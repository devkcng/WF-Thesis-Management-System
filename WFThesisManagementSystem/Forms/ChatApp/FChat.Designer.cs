namespace WFThesisManagementSystem.Forms.ChatApp
{
    partial class FChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.flpMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTaskName.Location = new System.Drawing.Point(213, 18);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(99, 22);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 105);
            this.panel2.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::WFThesisManagementSystem.Properties.Resources.icons8_send_50;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSend.Location = new System.Drawing.Point(457, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 51);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMessage.Location = new System.Drawing.Point(6, 3);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(445, 74);
            this.txtMessage.TabIndex = 0;
            // 
            // flpMessages
            // 
            this.flpMessages.AutoScroll = true;
            this.flpMessages.Location = new System.Drawing.Point(0, 66);
            this.flpMessages.Name = "flpMessages";
            this.flpMessages.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flpMessages.Size = new System.Drawing.Size(532, 386);
            this.flpMessages.TabIndex = 3;
            // 
            // FChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 560);
            this.Controls.Add(this.flpMessages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Box";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel flpMessages;
    }
}