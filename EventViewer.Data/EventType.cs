using System.Collections.Generic;

namespace EventViewer.Data
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
