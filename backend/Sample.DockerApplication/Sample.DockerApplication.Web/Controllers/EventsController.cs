using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sample.DockerApplication.Dal;

namespace Sample.DockerApplication.Web.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly SampleContext _dbContext;

        public EventsController(SampleContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult Get() => Ok(_dbContext.Events.ToList());
    }
}