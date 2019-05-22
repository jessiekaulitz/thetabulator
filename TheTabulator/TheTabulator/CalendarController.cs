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
        public const DayOfWeek WEEK_START_DAY = DayOfWeek.Monday;

        public const int DAYS_PER_WEEK = 7;
        /// <summary>
        /// Setting the start date of the week as the first Monday as of the current date.
        /// </summary>
        private static DateTime _weekStartDate = ThisWeekStart();
        /// <summary>
        /// List of all events ever created.
        /// </summary>
        private static Dictionary<string, List<CalendarEvent>> _events = new Dictionary<string, List<CalendarEvent>>();


        public static void SaveEvents()
        {
            throw new NotImplementedException();
        }

        public static void LoadEvents()
        {
            throw new NotImplementedException();
        }

        public static void AddEvent(CalendarEvent eventToAdd)
        {
            _events[GetWeekKey()].Add(eventToAdd);
        }

        /// <summary>
        /// Sets up new event screen and its controller and prepares to add a new event to this week's event
        /// list.
        /// </summary>
        /// <param name="colIndex">
        /// Column index of the calendar cell that was selected for where a new event is to be created.
        /// </param>
        /// <param name="rowIndex">
        /// Row index of the calendar cell that was selected for where a new event is to be created.
        /// </param>
        public static void NewEventRequest(int colIndex, int rowIndex)
        {
            DateTime startingDateTime = _weekStartDate.AddDays(colIndex);
            startingDateTime = startingDateTime.AddHours(rowIndex);

            AddEventController eventScreenController = new AddEventController(startingDateTime);
            eventScreenController.RunWindow();
        }


        public static void EditEvent(CalendarEvent eventToEdit)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the string key for the events dictionary for the current week.
        /// </summary>
        /// <returns></returns>
        private static string GetWeekKey()
        {
            return _weekStartDate.ToShortDateString();
        }


        /// <summary>
        /// Checks if the week of the calendar is the same as the current week in time.
        /// </summary>
        /// <returns>
        /// True <- If the calendar is in the current week.
        /// False <- Not in the current week in time.
        /// </returns>
        public static bool IsAtThisWeek()
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


        /// <summary>
        /// Returns a DateTime object at the start of the current week.
        /// </summary>
        /// <returns></returns>
        private static DateTime ThisWeekStart()
        {
            return DateTime.Now.WeekStartDate(WEEK_START_DAY);
        }


        /// <summary>
        /// Clears the TableLayoutPanel and fills its cells with the labels for the events of this current week.
        /// </summary>
        /// <param name="table">
        /// TableLayoutPanel whose cells are to be filled with events.
        /// </param>
        public static void DrawWeeksEvents(TableLayoutPanel table)
        {
            int columnIndex, startRowIndex, rowSpan;

            //In the case a week is being drawn for the fist time, or the calendar is first loaded
            if (!_events.ContainsKey(GetWeekKey()))
                _events[GetWeekKey()] = new List<CalendarEvent>();


            table.Controls.Clear();

            //For each event of this week, calculate where it needs to be positioned in the calendar,
            //add it to the TableLayoutPanel, and set the appropriate rowspan.
            foreach (CalendarEvent cEvent in _events[GetWeekKey()])
            {
                cEvent.CalculateStartPosition(out columnIndex, out startRowIndex);
                
                cEvent.UpdateLabelText();

                table.Controls.Add(cEvent.Label, columnIndex, startRowIndex);

                rowSpan = cEvent.CalculateRowSpan();
                table.SetRowSpan(cEvent.Label, rowSpan);
            }
        }

        /// <summary>
        /// Gets the string of the current year that the calendar is positioned at.
        /// </summary>
        public static string YearString
        {
            get
            {
                return _weekStartDate.Year.ToString();
            }
        }


        /// <summary>
        /// Gets the string of the current month that the calendar is positioned at.
        /// </summary>
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
