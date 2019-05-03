using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Decrements the date back until it is at the defined start day.
        /// </summary>
        /// <param name="dateTime">
        /// DayOfWeek type to select what day is considered the start of the week.
        /// </param>
        /// <param name="weekStartDay"></param>
        /// <returns></returns>
        public static DateTime WeekStartDate(this DateTime dateTime, DayOfWeek weekStartDay)
        {
            while (dateTime.DayOfWeek != weekStartDay)
            {
                //This object's date becomes the day before
                dateTime = dateTime.Subtract(TimeSpan.FromDays(1));
            }

            return dateTime;
        }

        public static int DayIndexWithRollOver(DayOfWeek day)
        {
            int dayNumber = Convert.ToInt32(day) - 1;

            if (dayNumber < 0) dayNumber = 6;

            return dayNumber;
        }

        public static void ClearOptimised(this TableLayoutControlCollection cells)
        {
            foreach(Label label in cells)
            {
                cells.Remove(label);
            }
        }
    }
}
