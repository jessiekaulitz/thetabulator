using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TheTabulator
{
    public static class CalendarController
    {
        public const DayOfWeek WeekStartDay = DayOfWeek.Monday;

        public const int DAYS_PER_WEEK = 7;
        /// <summary>
        /// Setting the start date of the week as the first Monday as of the current date.
        /// </summary>
        private static DateTime _weekStartDate = ThisWeekStart();
        /// <summary>
        /// List of all events ever created.
        /// </summary>
        private static List<CalendarEvent> _eventList = new List<CalendarEvent>();


        public static void SaveEvents()
        {

        }

        public static void LoadEvents()
        {

        }

        public static void AddEvent(CalendarEvent eventToAdd)
        {
            _eventList.Add(eventToAdd);
        }

        public static void EditEvent(CalendarEvent eventToEdit)
        {

        }


        /// <summary>
        /// Checks if the week of the calendar is the same as the current week in time.
        /// </summary>
        /// <returns>
        /// True <- If the calendar is in the current week.
        /// False <- Not in the current week in time.
        /// </returns>
        public static bool AtThisWeek()
        {
            return _weekStartDate.Equals(ThisWeekStart());
        }

        /// <summary>
        /// Returns an integer index representing the current day of the week.
        /// </summary>
        /// <returns></returns>
        public static int CurrentDayIndex()
        {
            return DayIndexForMondayWeekStart(DateTime.Now.DayOfWeek);
        }




        /// <summary>
        /// Moving this Controller's current week field forward by one week.
        /// </summary>
        public static void NextWeek()
        {
            //Advance the current week date by a week (automatically rolls over to next month/year)
            _weekStartDate = _weekStartDate.AddDays(DAYS_PER_WEEK);
        }

        /// <summary>
        /// Moving this Controller's current week field back by one week.
        /// </summary>
        public static void PreviousWeek()
        {
            //Subtract a week from the current week date (automatically rolls over to previous month/year)
            _weekStartDate = _weekStartDate.Subtract(TimeSpan.FromDays(DAYS_PER_WEEK));
        }

        /// <summary>
        /// Setting the start date of the week back to the first Monday as of the current date.
        /// </summary>
        public static void ResetWeek()
        {
            _weekStartDate = ThisWeekStart();
        }

        private static DateTime ThisWeekStart()
        {
            return DateTime.Now.WeekStartDate(WeekStartDay);
        }

        public static void DrawWeeksEvents(TableLayoutControlCollection cells)
        {
            int columnIndex, startRowIndex, endRowIndex;

            foreach (CalendarEvent cEvent in _eventList)
            {
                //V Doesnt seem to work better, need to find better method
                //cells.ClearOptimised();
                //cells.Clear();

                cEvent.CalculateStartPosition(out columnIndex, out startRowIndex);
                endRowIndex = cEvent.CalculateEndRowPosition();

                cells.Add(cEvent.Label, columnIndex, startRowIndex);
            }
        }

        public static string YearString
        {
            get
            {
                return _weekStartDate.Year.ToString();
            }
        }

        public static string MonthString
        {
            get
            {
                //String of the Month from the current week start date (if week
                //splits over 2 months).
                return _weekStartDate.FullMonthString();
            }
        }

        /// <summary>
        /// Returns a string of the current day number of the week, based on the
        /// DayOfWeek type.
        /// </summary>
        /// <param name="day">
        /// The day of this week for which to return its date number string as.
        /// </param>
        /// <returns></returns>
        public static string DayDateString(DayOfWeek day)
        {
            return _weekStartDate.AddDays(DayIndexForMondayWeekStart(day)).Day.ToString();
        }

        /// <summary>
        /// Converts the DayOfWeek enum value to an integer but with index
        /// 0 representing Monday, rather than Sunday as defined by the enum.
        /// </summary>
        /// <param name="day">
        /// Enumerated value whose index will be converted.
        /// </param>
        /// <returns></returns>
        public static int DayIndexForMondayWeekStart(DayOfWeek day)
        {
            int dayNumber = Convert.ToInt32(day) - 1;

            //Rollover the index if the day was Sunday.
            if (dayNumber< 0) dayNumber = 6;

            return dayNumber;
        }
    }
}
