using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheTabulator
{
    public class Event
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private int _color;
        private string _name;
        private string _location;

        public Event(string name)
        {
            _name = name;
        }

        public void SaveEvent(StreamWriter streamWriter)
        {

        }

        public void LoadEvent(StreamReader streamReader)
        {

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

        public int Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
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
