using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheTabulator
{
    public class AddEventController : EventScreenController
    {
        public AddEventController(DateTime eventStart)
        {
            //Default start event has a starting time and and end time 1 hour later
            _event = new CalendarEvent("", "", eventStart, eventStart.AddHours(1));
        }
        
        /// <summary>
        /// AddController adds its event to the CalendarController's event list
        /// </summary>
        public override void Action()
        {
            CalendarController.AddEvent(_event);
        }

        public override void RunWindow()
        {
            //New EventScreen with the specific button text for this controller.
            EventScreen eventScreen = new EventScreen(this);
            eventScreen.ButtonText = "Add Event";

            eventScreen.InitialiseInputFields(_event.Name, _event.StartTime.ToShortTimeString(), _event.EndTime.ToShortTimeString(), _event.StartTime.ToShortDateString(), _event.Location, _event.Color);
            eventScreen.ShowDialog();
        }
    }
}
