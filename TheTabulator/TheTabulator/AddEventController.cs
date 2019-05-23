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
            _event = new CalendarEvent("", "", eventStart, eventStart.AddHours(3));
        }
        

        /// <summary>
        /// Controller adds its event to the CalendarController's event list
        /// </summary>
        public override void Action()
        {
            CalendarController.AddEvent(_event);
        }


        public override void RunWindow()
        {
            EventScreen eventScreen = new EventScreen(this, "Add Event");
            eventScreen.InitialiseInputFields(_event.Name, _event.StartTime.ToShortTimeString(), _event.EndTime.ToShortTimeString(), _event.StartTime.ToShortDateString(), _event.Location);
            eventScreen.ShowDialog();

        }

        public System.Drawing.Color EventColor
        {
            set
            {
                _event.Color = value;
            }
        }

        public string EventName
        {
            set
            {
                _event.Name = value;
            }
        }

        public string EventLocation
        {
            set
            {
                _event.Location = value;
            }
        }

        public string StartTime
        {
            get
            {
                return _event.StartTime.ToShortTimeString();
            }

            set
            {
                string timeString = value;

                //Need to use the time converter
                //Then check timespan is <23 hours
                //Then set the event date to 12am (.Date)
                //then modify _newEvent.StartTime = .Date
                //then modify _newEvent.StartTime.addtime(TImeSpan)
            }
        }

        public string EndTime
        {
            get
            {
                return _event.EndTime.ToShortTimeString();
            }
            set
            {
                string timeString = value;
                //see above comments
                //Need to check that event.endtime.addtime(TIMeSpan).date == event.starttime.date
                //^ie, the end time is still on the same day as the start time
            }
        }

        public string EventDate
        {
            get
            {
                return _event.StartTime.ToLongDateString();
            }
        }
    }
}
