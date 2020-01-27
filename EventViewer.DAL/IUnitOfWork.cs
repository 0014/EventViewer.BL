using System;
using System.Collections.Generic;
using System.Text;

namespace EventViewer.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        EventRepository Events{ get; }
        EventTypeRepository EventTypes{ get; }
        int Complete();
    }
}
