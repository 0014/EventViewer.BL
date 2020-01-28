using EventViewer.Data;

namespace EventViewer.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventContext _context;

        public EventRepository Events { get; private set; }
        public EventTypeRepository EventTypes { get; private set; }

        public UnitOfWork(EventContext context)
        {
            _context = context;

            Events = new EventRepository(_context);
            EventTypes = new EventTypeRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
