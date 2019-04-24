using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTabulator
{
    class RecurringEvent: Event
    {
        private Event _nextEvent;

        public RecurringEvent(string name) : base (name)
        {

        }
    }
}
