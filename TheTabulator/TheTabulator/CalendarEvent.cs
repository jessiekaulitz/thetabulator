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
        private DateTime _startTime;
        private DateTime _endTime;
        private string _name;
        private string _location;
        private Label _eventLabel;

        public CalendarEvent(string name, DateTime startTime, DateTime endTime)
        {
            _name = name;
            _startTime = startTime;
            _endTime = endTime;
            _eventLabel = new Label();
            _eventLabel.Dock = DockStyle.Fill;
            _eventLabel.Text = "This is an event";
        }

        public void SaveEvent(StreamWriter streamWriter)
        {
            DateTime cake = new DateTime();

            //cake.TimeOfDay

            //cake.DayOfWeek;
        }

        public void LoadEvent(StreamReader streamReader)
        {

        }

        public void CalculateStartPosition(out int columnIndex, out int startRowIndex)
        {
            columnIndex = ExtensionMethods.DayIndexWithRollOver(_startTime.DayOfWeek);

            //If the DayOfWeek enumerated type is the 0th value, then set to 
            //be the 7th index to accomodate for the first column of the table being
            //for the time labels.
            //if (columnIndex < 0) columnIndex = 6;

            //Table row index matches the hour (in 24 hr time) integer
            startRowIndex = _startTime.Hour;
        }

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
