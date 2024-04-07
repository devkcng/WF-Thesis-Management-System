using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCDashBoard : UserControl
    {
        private readonly System.Collections.Generic.Dictionary<DateTime, string> events = new System.Collections.Generic.Dictionary<DateTime, string>();

        public UCDashBoard()
        {
            InitializeComponent();

            chart2.Titles.Add("Task Chart");
            chart2.Series["s1"].Points.AddXY("Complete Task", "30");
            chart2.Series["s1"].Points.AddXY("Uncomplete Task", "70");

            chart3.Titles.Add("Worklog Chart");
            chart3.Series["s1"].Points.AddXY("Uncomplete Task", "70");
            chart3.Series["s1"].Points.AddXY("Task", "30");

            chart4.Titles.Add("Performance Chart");
            chart4.Series["s1"].Points.AddXY("2", "70");
            chart4.Series["s1"].Points.AddXY("3", "30");
            chart4.Series["s1"].Points.AddXY("4", "40");
            chart4.Series["s1"].Points.AddXY("5", "0");
            chart4.Series["s1"].Points.AddXY("6", "10");
            chart4.Series["s1"].Points.AddXY("7", "40");

            chart4.Series["s2"].Points.AddXY("2", "50");
            chart4.Series["s2"].Points.AddXY("3", "40");
            chart4.Series["s2"].Points.AddXY("4", "60");
            chart4.Series["s2"].Points.AddXY("5", "70");
            chart4.Series["s2"].Points.AddXY("6", "0");
            chart4.Series["s2"].Points.AddXY("7", "10");
        }

    }
}
