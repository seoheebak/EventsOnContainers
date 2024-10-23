using EventCatalogAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventContext _context;
        public EventController (EventContext context)
        { 
            _context = context;
        }

        [HttpGet("[action]")]
        public async  Task<IActionResult> EventTypes()
        {
            var types = await _context.EventTypes.ToListAsync();
            return Ok(types);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery]int pageIndex = 0,
            [FromQuery]int pageSize = 6
            )
        {
            var items = await _context.Events
                .OrderBy(c => c.Id)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
            
            return Ok(items);
        }
    }
}
