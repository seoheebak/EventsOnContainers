using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult EventTypes()
        { 
        
        }

        [HttpGet("[action]")]
        public IActionResult Items()
        {
        }
    }
}
