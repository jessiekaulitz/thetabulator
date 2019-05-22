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
            //Setting default label color and making it fill its container
            _eventLabel.BackColor = DEFAULT_COLOR;
            _eventLabel.Dock = DockStyle.Fill;

            //Dynamically assigning the same event handler for the label of this event to enable
            //editing of it.
            _eventLabel.MouseClick += new MouseEventHandler(Label_Click);
        }

        /// <summary>
        /// EventHandler for mouse click on the label of this CalendarEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            CalendarController.EditEventRequest(this);
        }

        public void SaveEvent(StreamWriter streamWriter)
        {
            throw new NotImplementedException();
        }

        public void LoadEvent(StreamReader streamReader)
        {
            throw new NotImplementedException();
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
        /// Calculates the row span of this event's label calendar based on its
        /// end time in relation to its start time.
        /// </summary>
        /// <returns></returns>
        public int CalculateRowSpan()
        {
            //Number of rows to span is the difference in the start and end hours.
            int rowSpan = (_endTime.Hour24() - _startTime.Hour24());

            //For events lasting less than an hour, must still span 1 full row.
            if (rowSpan < 1) rowSpan = 1;

            return rowSpan;
        }


        public void UpdateLabelText()
        {
            _eventLabel.Text = _name + " " + _startTime.ToShortTimeString();
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
