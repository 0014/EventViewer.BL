using System.Collections.Generic;
using System.Linq;
using EventViewer.Data;
using EventViewer.Data.Models;

namespace EventViewer.DAL
{
    public class EventRepository : Repository<Event>
    {
        private EventContext EventContext => Context as EventContext;

        public EventRepository(EventContext context) : base(context)
        {

        }

        public List<EventBasicInfoModel> AllEventsWithBasicInfo()
        {
            return EventContext
                .Events
                .Select(e => new EventBasicInfoModel
                {
                    EventId = e.EventId,
                    Title = e.Title,
                    Date = e.Date
                })
                .ToList();
        }
    }
}