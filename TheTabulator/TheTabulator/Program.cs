using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime cake = DateTime.Now.Date.WeekStartDate(DayOfWeek.Monday);
            //cake.



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creating start time for Wednesday, 20th of March, 2019 at 10am
            DateTime _eventStart = new DateTime(2019, 5, 3).AddHours(10);

            //Creating end time for Wednesday, 20th of March, 2019 at 2pm
            DateTime _eventEnd = _eventStart.AddHours(4);

            CalendarEvent _testEvent = new CalendarEvent("test", _eventStart, _eventEnd);

            CalendarController.AddEvent(_testEvent);


            Application.Run(new MainWindow());
        }
    }
}
