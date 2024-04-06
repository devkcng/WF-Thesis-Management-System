using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCCalendar : UserControl
    {
        int month, year;
        public UCCalendar()
        {
            InitializeComponent();
            DisplayDays();
        }

        private void ptbPrevious_Click(object sender, EventArgs e)
        {

        }

        private void ptbNext_Click(object sender, EventArgs e)
        {
            flpDayContainer.Controls.Clear();
            month++;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            lblMY.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 2; i < dayoftheweek; i++)
            {
                UCBlank uCBlank = new UCBlank();
                flpDayContainer.Controls.Add(uCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDay uCDay = new UCDay();
                uCDay.days(i);
               
                flpDayContainer.Controls.Add(uCDay);
            }
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);


            lblMY.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) +" " +now.Year;
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"))+1;

            for(int i=2; i < dayoftheweek; i++)
            {
                UCBlank uCBlank = new UCBlank();
                flpDayContainer.Controls.Add(uCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDay uCDay = new UCDay();
                uCDay.days(i);
                if (i == 1)
                { 
                    uCDay.BackColor = Color.LightGreen; 
                    uCDay.lblDay.BackColor= Color.LightGreen;
                }
                if (i == 10)
                {
                    uCDay.BackColor = Color.LightYellow;
                    uCDay.lblDay.BackColor = Color.LightYellow;
                }
                if (i == 30)
                {
                    uCDay.BackColor = Color.MediumVioletRed;
                    uCDay.lblDay.BackColor = Color.MediumVioletRed;
                }
                flpDayContainer.Controls.Add(uCDay);

            }
        }



    }
}
