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
            //Removing any time part of the date (will now be at 12am of the date)
            dateTime = dateTime.Date;

            while (dateTime.DayOfWeek != weekStartDay)
            {
                //This object's date becomes the day before
                dateTime = dateTime.Subtract(TimeSpan.FromDays(1));
            }

            return dateTime;
        }



        public static void ClearOptimised(this TableLayoutControlCollection cells)
        {
            foreach(Label label in cells)
            {
                cells.Remove(label);
            }
        }

        /// <summary>
        /// Returns a string representing the full month name of this date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>
        /// Month name as a full string. For example, January.
        /// </returns>
        public static string FullMonthString(this DateTime dateTime)
        {
            return dateTime.ToString("MMMM");
        }
    }
}
