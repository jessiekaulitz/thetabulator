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
        private static DateTime _weekStartDate = DateTime.Now;
        private static List<CalendarEvent> _eventList = new List<CalendarEvent>();


        public static void SaveEvents()
        {

        }

        public static void LoadEvents()
        {

        }

        public static void AddEvent(CalendarEvent eventToAdd)
        {

        }

        public static void EditEvent(CalendarEvent eventToEdit)
        {

        }

        public static void NextWeek()
        {

        }

        public static void PreviousWeek()
        {

        }

        public static void DrawWeeksEvents(TableLayoutControlCollection cells)
        {

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
                //Not going to work, returns integer representing month
                return _weekStartDate.Month.ToString();
            }
        }

        public static string MondayDate
        {
            get
            {
                return _weekStartDate.Date.ToString();
            }
        }

    }
}
