using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TheTabulator
{
    public class CalendarEvent
    {
        public static System.Drawing.Color DEFAULT_COLOR = System.Drawing.Color.Purple;

        private DateTime _startTime;
        private DateTime _endTime;
        private string _name;
        private string _location;
        private Label _eventLabel;

        public CalendarEvent(string name, string location, DateTime startTime, DateTime endTime)
        {
            _name = name;
            _startTime = startTime;
            _endTime = endTime;
            _eventLabel = new Label();
            _eventLabel.BackColor = DEFAULT_COLOR;
            _eventLabel.Dock = DockStyle.Fill;
        }

        public void SaveEvent(StreamWriter streamWriter)
        {
            //DateTime cake = new DateTime();

            //cake.TimeOfDay

            //cake.DayOfWeek;
        }

        public void LoadEvent(StreamReader streamReader)
        {

        }

        /// <summary>
        /// Calculates the start indexes for both row and column position on the calendar
        /// based on this event's start time.
        /// </summary>
        /// <param name="columnIndex">
        /// Passed-by-reference column index. Initialised in the method.
        /// </param>
        /// <param name="startRowIndex">
        /// Passed-by-reference row index. Initialised in the method.
        /// </param>
        public void CalculateStartPosition(out int columnIndex, out int startRowIndex)
        {
            columnIndex = CalendarController.DayIndexForMondayWeekStart(_startTime.DayOfWeek);

            //Table row index matches the hour (in 24 hr time) integer
            startRowIndex = _startTime.Hour;
        }

        /// <summary>
        /// Calculates the ending row index position of the calendar based on this event's
        /// end time.
        /// </summary>
        /// <returns></returns>
        public int CalculateEndRowPosition()
        {
            return _endTime.Hour;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public Label Label
        {
            get
            {
                _eventLabel.Text = _name;
                return _eventLabel;
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return _eventLabel.BackColor;
            }

            set
            {
                _eventLabel.BackColor = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }

            set
            {
                _startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }

            set
            {
                _endTime = value;
            }
        }
    }
}
