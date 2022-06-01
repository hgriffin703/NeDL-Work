using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDI
{
    public interface IEventsList
    {
        public class EventsList : IEventsList
        {
            public List<Events> ListEvents = new List<Events>();

            ListEvents.Add(new Events() { EventDate = "10/24/2022",EventType = "Wedding", EventName = "Hayley's Wedding"});
            ListEvents.Add(new Events() { EventDate = "03/13/2023",EventType = "Wedding", EventName = "Sarah's Wedding"});
            ListEvents.Add(new Events() { EventDate = "06/29/2023",EventType = "Graduation", EventName = "Emily's Graduation"});
        }
    }
}
