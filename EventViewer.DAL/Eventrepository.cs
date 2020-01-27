using EventViewer.Data;

namespace EventViewer.DAL
{
    public class EventRepository : Repository<Event>
    {
        private EventContext EventContext => Context as EventContext;

        public EventRepository(EventContext context) : base(context)
        {

        }
    }
}
