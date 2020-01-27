using EventViewer.Data;

namespace EventViewer.DAL
{
    public class EventTypeRepository : Repository<EventType>
    {
        private EventContext EventContext => Context as EventContext;

        public EventTypeRepository(EventContext context) : base(context)
        {

        }
    }
}
