using EventViewer.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EventViewer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly UnitOfWork _db;

        public EventsController(UnitOfWork db)
        {
            _db = db;
        }

        // GET api/events
        [HttpGet]
        public JsonResult Get()
        {
            var events = _db.Events.GetAll();

            return Json(events);
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var eventt = _db.Events
                .SingleOrDefault(x => x.EventId == id);

            return Json(eventt);
        }
    }
}
