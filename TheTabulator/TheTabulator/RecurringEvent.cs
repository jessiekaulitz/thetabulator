using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTabulator
{
    class RecurringEvent: CalendarEvent
    {
        private CalendarEvent _nextEvent;

        public RecurringEvent(string name, DateTime startTime, DateTime endTime) : base (name, startTime, endTime)
        {

        }
    }
}
