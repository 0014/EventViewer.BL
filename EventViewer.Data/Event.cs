using System;

namespace EventViewer.Data
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public EventType Type { get; set; }
    }
}
