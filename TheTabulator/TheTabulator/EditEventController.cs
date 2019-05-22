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
        /// 
        /// </summary>
        public override void Action()
        {
            //Refreshes the parent component of the calendar (ie, the entire Calendar.cs component)
            _event.Label.Parent.Parent.Refresh();
        }



        public override void RunWindow()
        {
            EventScreen eventScreen = new EventScreen(this, "Edit Event");
            eventScreen.InitialiseInputFields(_event.Name, _event.StartTime.ToShortTimeString(), _event.EndTime.ToShortTimeString(), _event.StartTime.ToShortDateString(), _event.Location);
            eventScreen.ShowDialog();
        }



        /*

        public System.Drawing.Color EventColor
        {
            set
            {
                _newEvent.Color = value;
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
        */
    }
}
