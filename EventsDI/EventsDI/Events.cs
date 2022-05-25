using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDI
{
    class Events
    {
        private string eventDate;
        private string eventType;
        private string eventName;

        public Events()
        {
            eventDate = "";
            eventType = "";
            eventName = "";
        }
        public Events(string eventDate, string eventType, string eventName)
        {
            EventDate = eventDate;
            EventType = eventType;
            EventName = eventName;
        }
        public string EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }
        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

    }
}


