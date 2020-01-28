using Microsoft.EntityFrameworkCore;

namespace EventViewer.Data
{
    public class EventContext : DbContext
    {
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Enter_Connection_String_Here");
        }
    }
}
