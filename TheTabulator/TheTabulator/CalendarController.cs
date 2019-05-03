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
        public const int DAYS_PER_WEEK = 7;
        /// <summary>
        /// Setting the start date of the week as the first Monday as of the current date.
        /// </summary>
        private static DateTime _weekStartDate = DateTime.Now.Date.WeekStartDate(DayOfWeek.Monday);
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

        public static void NextWeek()
        {
            //Advance the current week date by a week (automatically rolls over to next month/year)
            _weekStartDate = _weekStartDate.AddDays(DAYS_PER_WEEK);
        }

        public static void PreviousWeek()
        {
            //Subtract a week from the current week date (automatically rolls over to previous month/year)
            _weekStartDate = _weekStartDate.Subtract(TimeSpan.FromDays(DAYS_PER_WEEK));
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
        
        public static string Year
        {
            get
            {
                return _weekStartDate.Year.ToString();
            }
        }

        public static string Month
        {
            get
            {
                //Returns a string representing the full month name from the current week date.
                return _weekStartDate.ToString("MMMM");
            }
        }

        public static int DayDate(DayOfWeek day)
        {
            return _weekStartDate.AddDays(ExtensionMethods.DayIndexWithRollOver(day)).Day;
        }
    }
}
