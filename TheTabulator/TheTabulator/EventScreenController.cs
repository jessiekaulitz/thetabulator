using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotnetCOREClasses;
namespace TheTabulator
{
    public abstract class EventScreenController
    {
        /// <summary>
        /// Event to be added or edited on the calendar.
        /// </summary>
        protected CalendarEvent _event;


        /// <summary>
        /// Makes the controller execute its primary operation (add or edit event).
        /// </summary>
        public abstract void Action();

        /// <summary>
        /// Controller runs the EventScreen window with the specifications for its controller purpose
        /// (add or edit).
        /// </summary>
        public abstract void RunWindow();

        /// <summary>
        /// Validates the fields for a CalendarEvent
        /// If successful, assigns these parameters to the CalendarEvent of this controller.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="location"></param>
        /// <param name="color"></param>
        /// <returns>
        /// True <- Controller's event is valid and has been updated with the new data, ready for Controller Action().
        /// False <- Parameters are invalid, no changes to event saved.
        /// </returns>
        public bool ValidateEvent(string name, string startTime, string endTime, string location, System.Drawing.Color color)
        {
            bool successful = true;

            if (name == "")
            {
                MessageBox.Show("Name field must not be empty.");
                successful = false;
            }
            
            TimeSpan time = TimeConverter.ConvertTime(startTime);
            if ((time == null) || (time.Hours > 23))
            {
                MessageBox.Show("Start time must be valid and on the same day.");
                successful = false;
            }

            time = TimeConverter.ConvertTime(endTime);
            DateTime newEndTime = _event.EndTime.Date.Add(time);
            if ((time == null) || (newEndTime.Date != _event.StartTime.Date))
            {
                MessageBox.Show("End time must be valid and on the same day.");
                successful = false;
            }
            

            //Only do assignment if no errors
            if (successful)
            {
                _event.Name = name;
                _event.StartTime = _event.StartTime.Date.Add(time);
                _event.EndTime = newEndTime;

                _event.Color = color;
                _event.Location = location;
            }

            return successful;
        }
    }
}
