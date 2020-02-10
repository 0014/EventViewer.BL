using System;

namespace EventViewer.Data.Models
{
    public class EventBasicInfoModel
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}