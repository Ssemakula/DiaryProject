using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalAndDates
{
    public static class MyMethods
    {
        public enum MonthNames { January = 1, February, March, April, May, June, July, August, September, October, November, December };
        public static string ? MonthText, YearText, MonthDayText, DayOfWeekText;

        public static void SetOtherDates()
        {
            System.Globalization.GregorianCalendar g_cal = new System.Globalization.GregorianCalendar();

            MonthText = MyMethods.MonthName(g_cal.GetMonth(DateTime.Now));
            YearText = g_cal.GetYear(DateTime.Now).ToString();
            MonthDayText = g_cal.GetDayOfMonth(DateTime.Now).ToString();
            DayOfWeekText = g_cal.GetDayOfWeek(DateTime.Now).ToString();
    }

        public static string MonthName(int Month)
        {
            MonthNames myMonth = (MonthNames)Month;
            return myMonth.ToString();
        }
    }


}
