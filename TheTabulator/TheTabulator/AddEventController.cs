using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public class AddEventController
    {
        private CalendarEvent _newEvent;

        public AddEventController(DateTime eventStart)
        {
            _newEvent = new CalendarEvent("", "", eventStart, eventStart.AddHours(1));
        }
        

        /// <summary>
        /// Controller adds its event to the CalendarController's event list
        /// </summary>
        public void AddEvent()
        {
            CalendarController.AddEvent(_newEvent);
        }

        /// <summary>
        /// Validates the fields of this controller's event
        /// </summary>
        /// <returns>
        /// True <- Controller's event is valid and can be added to the event list
        /// False <- Event is invalid
        /// </returns>
        public bool ValidateEvent()
        {
            return (_newEvent.Name != "");
        }

        public System.Drawing.Color EventColor
        {
            set
            {
                _newEvent.Color = value; ;
            }
        }

        public string EventName
        {
            set
            {
                _newEvent.Name = value;
            }
        }

        public string EventLocation
        {
            set
            {
                _newEvent.Location = value;
            }
        }

        public string StartTime
        {
            get
            {
                return _newEvent.StartTime.ToShortTimeString();
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
                return _newEvent.EndTime.ToShortTimeString();
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
                return _newEvent.StartTime.ToLongDateString();
            }
        }
    }
}
