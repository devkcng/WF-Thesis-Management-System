using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    partial class FTeacherDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTeacherDashboard));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.projectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuRadioButton1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton();
            this.kryptonContextMenuCheckButton1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.MSListFolder = new System.Windows.Forms.MenuStrip();
            this.Project = new System.Windows.Forms.ToolStripMenuItem();
            this.task = new System.Windows.Forms.ToolStripMenuItem();
            this.worklogs = new System.Windows.Forms.ToolStripMenuItem();
            this.performance = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Regist = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.mspProfile = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucTeacherAllTask1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherAllTask();
            this.ucTeacherEditInfor1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherEditInfor();
            this.ucTeacherInfor1 = new WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl.UcTeacherInfor();
            this.ucTeacherAllTopics1 = new UcTeacherAllTopics(_context);
            this.MSListFolder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mspProfile.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormClose.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMax.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMin.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.projectToolStripMenuItem1.Text = "Project";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuRadioButton1
            // 
            this.kryptonContextMenuRadioButton1.ExtraText = "";
            this.kryptonContextMenuRadioButton1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuCheckButton1
            // 
            this.kryptonContextMenuCheckButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton1.Text = "CheckButton";
            // 
            // MSListFolder
            // 
            this.MSListFolder.BackColor = System.Drawing.Color.White;
            this.MSListFolder.Dock = System.Windows.Forms.DockStyle.None;
            this.MSListFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MSListFolder.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MSListFolder.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MSListFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Project,
            this.task,
            this.worklogs,
            this.performance,
            this.logout,
            this.Regist});
            this.MSListFolder.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.MSListFolder.Location = new System.Drawing.Point(0, 5);
            this.MSListFolder.Name = "MSListFolder";
            this.MSListFolder.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MSListFolder.Size = new System.Drawing.Size(213, 220);
            this.MSListFolder.TabIndex = 1;
            this.MSListFolder.Text = "menuStrip2";
            // 
            // Project
            // 
            this.Project.BackColor = System.Drawing.Color.Wheat;
            this.Project.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.Image = global::WFThesisManagementSystem.Properties.Resources.Edit;
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(143, 36);
            this.Project.Text = "Project";
            this.Project.Click += new System.EventHandler(this.Project_Click);
            // 
            // task
            // 
            this.task.BackColor = System.Drawing.Color.OldLace;
            this.task.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task.Image = global::WFThesisManagementSystem.Properties.Resources.Ok;
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(111, 36);
            this.task.Text = "Task";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // worklogs
            // 
            this.worklogs.BackColor = System.Drawing.Color.Wheat;
            this.worklogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worklogs.Image = global::WFThesisManagementSystem.Properties.Resources.Bookmark;
            this.worklogs.Name = "worklogs";
            this.worklogs.Size = new System.Drawing.Size(183, 36);
            this.worklogs.Text = "Work Logs";
            // 
            // performance
            // 
            this.performance.BackColor = System.Drawing.Color.OldLace;
            this.performance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance.Image = global::WFThesisManagementSystem.Properties.Resources.Hexagon_Synchronize;
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(209, 36);
            this.performance.Text = "Performance";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Wheat;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = global::WFThesisManagementSystem.Properties.Resources.Single_Sign_On;
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(150, 36);
            this.logout.Text = "Log out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Regist
            // 
            this.Regist.BackColor = System.Drawing.Color.OldLace;
            this.Regist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regist.Image = global::WFThesisManagementSystem.Properties.Resources.Edit_Property;
            this.Regist.Name = "Regist";
            this.Regist.Size = new System.Drawing.Size(132, 36);
            this.Regist.Text = "Regist";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNotification);
            this.panel1.Controls.Add(this.mspProfile);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.menuStrip3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1689, 58);
            this.panel1.TabIndex = 2;
            // 
            // btnNotification
            // 
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.Color.Transparent;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.Black;
            this.btnNotification.Image = global::WFThesisManagementSystem.Properties.Resources.notification1;
            this.btnNotification.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNotification.Location = new System.Drawing.Point(1003, 3);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(221, 52);
            this.btnNotification.TabIndex = 6;
            this.btnNotification.Text = "   Notification";
            // 
            // mspProfile
            // 
            this.mspProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mspProfile.BackColor = System.Drawing.Color.White;
            this.mspProfile.Dock = System.Windows.Forms.DockStyle.None;
            this.mspProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mspProfile.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mspProfile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mspProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.mspProfile.Location = new System.Drawing.Point(-9472, 6);
            this.mspProfile.Name = "mspProfile";
            this.mspProfile.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mspProfile.Size = new System.Drawing.Size(144, 38);
            this.mspProfile.TabIndex = 5;
            this.mspProfile.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Wheat;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::WFThesisManagementSystem.Properties.Resources.Female_User;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 36);
            this.toolStripMenuItem2.Text = "Profile";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 40);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(277, 58);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Thesis Management";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip3.BackColor = System.Drawing.Color.White;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(-8781, 15);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(144, 40);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Wheat;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::WFThesisManagementSystem.Properties.Resources.Female_User;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 36);
            this.toolStripMenuItem1.Text = "Profile";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.MSListFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 786);
            this.panel2.TabIndex = 3;
            // 
            // ucTeacherAllTask1
            // 
            this.ucTeacherAllTask1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAllTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherAllTask1.Location = new System.Drawing.Point(213, 58);
            this.ucTeacherAllTask1.Name = "ucTeacherAllTask1";
            this.ucTeacherAllTask1.Size = new System.Drawing.Size(1476, 786);
            this.ucTeacherAllTask1.TabIndex = 11;
            // 
            // ucTeacherAllTopics1
            // 
            this.ucTeacherAllTopics1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherAllTopics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTeacherAllTopics1.Location = new System.Drawing.Point(213, 55);
            this.ucTeacherAllTopics1.Name = "ucTeacherAllTopics1";
            this.ucTeacherAllTopics1.Size = new System.Drawing.Size(1476, 789);
            this.ucTeacherAllTopics1.TabIndex = 10;
            // 
            // ucTeacherEditInfor1
            // 
            this.ucTeacherEditInfor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherEditInfor1.Location = new System.Drawing.Point(571, 75);
            this.ucTeacherEditInfor1.Name = "ucTeacherEditInfor1";
            this.ucTeacherEditInfor1.Size = new System.Drawing.Size(722, 724);
            this.ucTeacherEditInfor1.TabIndex = 9;
            // 
            // ucTeacherInfor1
            // 
            this.ucTeacherInfor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTeacherInfor1.Location = new System.Drawing.Point(243, 75);
            this.ucTeacherInfor1.Name = "ucTeacherInfor1";
            this.ucTeacherInfor1.Size = new System.Drawing.Size(322, 627);
            this.ucTeacherInfor1.TabIndex = 8;
            // 
            // FTeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 844);
            this.Controls.Add(this.ucTeacherAllTask1);
            this.Controls.Add(this.ucTeacherAllTopics1);
            this.Controls.Add(this.ucTeacherEditInfor1);
            this.Controls.Add(this.ucTeacherInfor1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FTeacherDashboard";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTeacherDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MSListFolder.ResumeLayout(false);
            this.MSListFolder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mspProfile.ResumeLayout(false);
            this.mspProfile.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton kryptonContextMenuRadioButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton1;
        private System.Windows.Forms.MenuStrip MSListFolder;
        private System.Windows.Forms.ToolStripMenuItem Project;
        private System.Windows.Forms.ToolStripMenuItem task;
        private System.Windows.Forms.ToolStripMenuItem worklogs;
        private System.Windows.Forms.ToolStripMenuItem performance;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mspProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private UcTeacherInfor ucTeacherInfor1;
        private UcTeacherEditInfor ucTeacherEditInfor1;
        private UcTeacherAllTopics ucTeacherAllTopics1;
        private UcTeacherAllTask ucTeacherAllTask1;
        private System.Windows.Forms.ToolStripMenuItem Regist;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
    }
}