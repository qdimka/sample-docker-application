using Microsoft.AspNetCore.Mvc;

namespace Sample.DockerApplication.Web.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("events");
        }
    }
}