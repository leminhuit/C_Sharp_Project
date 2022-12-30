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

namespace MainForm
{
    public partial class PlansAndDeadlines : Form
    {
        int month, year;

        public static int static_month, static_year;

        public PlansAndDeadlines()
        {
            InitializeComponent();
        }

        private void PlansAndDeadlines_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            static_month = month;
            static_year = year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthName + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int j = 1; j <= days; j++)
            {
                UserControlDay ucd = new UserControlDay();
                ucd.days(j);
                daysContainer.Controls.Add(ucd);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthName + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int j = 1; j <= days; j++)
            {
                UserControlDay ucd = new UserControlDay();
                ucd.days(j);
                daysContainer.Controls.Add(ucd);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthName + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int j = 1; j <= days; j++)
            {
                UserControlDay ucd = new UserControlDay();
                ucd.days(j);
                daysContainer.Controls.Add(ucd);
            }
        }
    }
}
