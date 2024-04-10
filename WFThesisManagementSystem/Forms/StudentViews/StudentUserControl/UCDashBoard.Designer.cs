namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    partial class UCDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.sdpTOP = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.sdpTask = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flpGroupTask = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTaskDate = new System.Windows.Forms.ComboBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.sdpCalendar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.sdpBottom = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.sdpPerformanceChart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.sdpTaskChart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.groupTaskChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.ucCalendar1 = new WFThesisManagementSystem.Forms.StudentViews.StudentUserControl.UCCalendar();
            this.sdpTOP.SuspendLayout();
            this.sdpTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sdpCalendar.SuspendLayout();
            this.sdpBottom.SuspendLayout();
            this.sdpPerformanceChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.sdpTaskChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTaskChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sdpTOP
            // 
            this.sdpTOP.BackColor = System.Drawing.Color.Transparent;
            this.sdpTOP.Controls.Add(this.sdpTask);
            this.sdpTOP.Controls.Add(this.guna2CustomGradientPanel2);
            this.sdpTOP.Controls.Add(this.sdpCalendar);
            this.sdpTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdpTOP.FillColor = System.Drawing.Color.White;
            this.sdpTOP.Location = new System.Drawing.Point(0, 0);
            this.sdpTOP.Margin = new System.Windows.Forms.Padding(0);
            this.sdpTOP.Name = "sdpTOP";
            this.sdpTOP.Padding = new System.Windows.Forms.Padding(20);
            this.sdpTOP.ShadowColor = System.Drawing.Color.Black;
            this.sdpTOP.Size = new System.Drawing.Size(2228, 838);
            this.sdpTOP.TabIndex = 0;
            // 
            // sdpTask
            // 
            this.sdpTask.BackColor = System.Drawing.Color.Transparent;
            this.sdpTask.Controls.Add(this.flpGroupTask);
            this.sdpTask.Controls.Add(this.panel1);
            this.sdpTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdpTask.FillColor = System.Drawing.Color.White;
            this.sdpTask.Location = new System.Drawing.Point(1464, 20);
            this.sdpTask.Name = "sdpTask";
            this.sdpTask.ShadowColor = System.Drawing.Color.Black;
            this.sdpTask.ShadowDepth = 0;
            this.sdpTask.ShadowShift = 0;
            this.sdpTask.Size = new System.Drawing.Size(744, 798);
            this.sdpTask.TabIndex = 2;
            // 
            // flpGroupTask
            // 
            this.flpGroupTask.AutoScroll = true;
            this.flpGroupTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGroupTask.Location = new System.Drawing.Point(0, 126);
            this.flpGroupTask.Name = "flpGroupTask";
            this.flpGroupTask.Size = new System.Drawing.Size(744, 672);
            this.flpGroupTask.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTaskDate);
            this.panel1.Controls.Add(this.lblTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 126);
            this.panel1.TabIndex = 0;
            // 
            // cbTaskDate
            // 
            this.cbTaskDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskDate.FormattingEnabled = true;
            this.cbTaskDate.Items.AddRange(new object[] {
            "This week",
            "This month"});
            this.cbTaskDate.Location = new System.Drawing.Point(459, 42);
            this.cbTaskDate.Name = "cbTaskDate";
            this.cbTaskDate.Size = new System.Drawing.Size(251, 39);
            this.cbTaskDate.TabIndex = 40;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(22, 19);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(346, 63);
            this.lblTasks.TabIndex = 39;
            this.lblTasks.Text = "Group Tasks";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(1447, 20);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(17, 798);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // sdpCalendar
            // 
            this.sdpCalendar.BackColor = System.Drawing.Color.Transparent;
            this.sdpCalendar.Controls.Add(this.ucCalendar1);
            this.sdpCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sdpCalendar.FillColor = System.Drawing.Color.White;
            this.sdpCalendar.Location = new System.Drawing.Point(20, 20);
            this.sdpCalendar.Name = "sdpCalendar";
            this.sdpCalendar.ShadowColor = System.Drawing.Color.Black;
            this.sdpCalendar.ShadowDepth = 0;
            this.sdpCalendar.Size = new System.Drawing.Size(1427, 798);
            this.sdpCalendar.TabIndex = 0;
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // sdpBottom
            // 
            this.sdpBottom.BackColor = System.Drawing.Color.Transparent;
            this.sdpBottom.Controls.Add(this.sdpPerformanceChart);
            this.sdpBottom.Controls.Add(this.guna2CustomGradientPanel1);
            this.sdpBottom.Controls.Add(this.sdpTaskChart);
            this.sdpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdpBottom.FillColor = System.Drawing.Color.White;
            this.sdpBottom.Location = new System.Drawing.Point(0, 838);
            this.sdpBottom.Margin = new System.Windows.Forms.Padding(0);
            this.sdpBottom.Name = "sdpBottom";
            this.sdpBottom.Padding = new System.Windows.Forms.Padding(20);
            this.sdpBottom.ShadowColor = System.Drawing.Color.Black;
            this.sdpBottom.Size = new System.Drawing.Size(2228, 399);
            this.sdpBottom.TabIndex = 1;
            // 
            // sdpPerformanceChart
            // 
            this.sdpPerformanceChart.BackColor = System.Drawing.Color.Transparent;
            this.sdpPerformanceChart.Controls.Add(this.chart4);
            this.sdpPerformanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdpPerformanceChart.FillColor = System.Drawing.Color.White;
            this.sdpPerformanceChart.Location = new System.Drawing.Point(1409, 20);
            this.sdpPerformanceChart.Name = "sdpPerformanceChart";
            this.sdpPerformanceChart.Radius = 10;
            this.sdpPerformanceChart.ShadowColor = System.Drawing.Color.Black;
            this.sdpPerformanceChart.Size = new System.Drawing.Size(799, 359);
            this.sdpPerformanceChart.TabIndex = 2;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "s2";
            this.chart4.Series.Add(series1);
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(799, 359);
            this.chart4.TabIndex = 0;
            this.chart4.Text = "chart4";
            this.chart4.Visible = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(1392, 20);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(17, 359);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // sdpTaskChart
            // 
            this.sdpTaskChart.BackColor = System.Drawing.Color.Transparent;
            this.sdpTaskChart.Controls.Add(this.groupTaskChart);
            this.sdpTaskChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.sdpTaskChart.FillColor = System.Drawing.Color.White;
            this.sdpTaskChart.Location = new System.Drawing.Point(20, 20);
            this.sdpTaskChart.Name = "sdpTaskChart";
            this.sdpTaskChart.ShadowColor = System.Drawing.Color.Black;
            this.sdpTaskChart.Size = new System.Drawing.Size(1372, 359);
            this.sdpTaskChart.TabIndex = 0;
            // 
            // groupTaskChart
            // 
            this.groupTaskChart.BorderSkin.BorderWidth = 5;
            this.groupTaskChart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.groupTaskChart.ChartAreas.Add(chartArea2);
            this.groupTaskChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.groupTaskChart.Legends.Add(legend2);
            this.groupTaskChart.Location = new System.Drawing.Point(0, 0);
            this.groupTaskChart.Name = "groupTaskChart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderWidth = 8;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.groupTaskChart.Series.Add(series3);
            this.groupTaskChart.Size = new System.Drawing.Size(1372, 359);
            this.groupTaskChart.TabIndex = 1;
            this.groupTaskChart.Text = "Task Chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Group Task Chart";
            this.groupTaskChart.Titles.Add(title1);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ucCalendar1
            // 
            this.ucCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalendar1.Location = new System.Drawing.Point(0, 0);
            this.ucCalendar1.Name = "ucCalendar1";
            this.ucCalendar1.Size = new System.Drawing.Size(1427, 798);
            this.ucCalendar1.TabIndex = 0;
            // 
            // UCDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sdpBottom);
            this.Controls.Add(this.sdpTOP);
            this.Name = "UCDashBoard";
            this.Size = new System.Drawing.Size(2228, 1237);
            this.sdpTOP.ResumeLayout(false);
            this.sdpTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sdpCalendar.ResumeLayout(false);
            this.sdpBottom.ResumeLayout(false);
            this.sdpPerformanceChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.sdpTaskChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTaskChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpTOP;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel sdpBottom;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTasks;
        public Guna.UI2.WinForms.Guna2ShadowPanel sdpCalendar;
        public UCCalendar ucCalendar1;
        public Guna.UI2.WinForms.Guna2ShadowPanel sdpTask;
        public System.Windows.Forms.ComboBox cbTaskDate;
        public System.Windows.Forms.FlowLayoutPanel flpGroupTask;
        public System.Windows.Forms.DataVisualization.Charting.Chart groupTaskChart;
        public Guna.UI2.WinForms.Guna2ShadowPanel sdpPerformanceChart;
        public Guna.UI2.WinForms.Guna2ShadowPanel sdpTaskChart;
    }
}
