using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTabulator
{
    public static class AddEventController
    {

        public static void AddEvent(string name, string location, string startTimeString, string endTimeString, System.Drawing.Color color)
        {
            //Needs to convert starttime and endTIme to DAteTime (should be TimeSpan) objects
            TimeSpan cake = new TimeSpan();
            DateTime startTime = new DateTime(2019, 5, 17, 10, 00, 00);
            DateTime endTime = new DateTime(2019, 5, 17, 13, 00, 00);

            CalendarEvent newEvent = new CalendarEvent(name, location, startTime, endTime);
            newEvent.Color = color;

        }
    }
}
