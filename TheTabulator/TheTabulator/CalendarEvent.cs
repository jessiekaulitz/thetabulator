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

        public CalendarEvent(string name)
        {
            _name = name;
            _eventLabel = new Label();
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
            columnIndex = default;
            startRowIndex = default;
        }

        public int CalculateEndRowPosition()
        {
            return default;
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
