using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public class EditEventController : EventScreenController
    {
        public EditEventController(CalendarEvent eventToEdit)
        {
            _event = eventToEdit;
        }
        
        /// <summary>
        /// EditController refreshes the calendar component, which is the grandparent of the event label.
        /// </summary>
        public override void Action()
        {
            //Refreshes the parent component of the calendar (ie, the entire Calendar.cs component)
            _event.Label.Parent.Parent.Refresh();
        }

        public override void RunWindow()
        {
            //New EventScreen with the specific button text for this controller.
            EventScreen eventScreen = new EventScreen(this);
            eventScreen.ButtonText = "Edit Event";

            eventScreen.InitialiseInputFields(_event.Name, _event.StartTime.ToShortTimeString(), _event.EndTime.ToShortTimeString(), _event.StartTime.ToShortDateString(), _event.Location, _event.Color);
            eventScreen.ShowDialog();
        }
    }
}
