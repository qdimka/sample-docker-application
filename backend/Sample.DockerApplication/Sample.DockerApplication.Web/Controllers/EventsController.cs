using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Sample.DockerApplication.Dal;
using Sample.DockerApplication.Dal.Entities;

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
        public IActionResult Get() 
            => Ok(_dbContext
                .Set<Event>()
                .ProjectTo<EventListDto>()
                .ToList());
        
        [HttpGet("details/{eventId}")]
        public IActionResult Details(long eventId)
        {
            var eventProgram = _dbContext
                .Set<Event>()
                .First(x => x.Id == eventId);

            return Ok(Mapper.Map<EventProgramDto>(eventProgram));
        }
    }

    public class EventListDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string StartDate { get; set; }

        public string ImageLink { get; set; }

        public string Description { get; set; }
    }

    public class EventProgramDto
    {
        public string Title { get; set; }

        public List<PresentationDto> Presentations { get; set; }
    }

    public class PresentationDto
    {
        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Author { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }
    }

    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventListDto>()
                .ForMember(x => x.StartDate, 
                    s => s.MapFrom(x => x.StartDate.ToString("D")));
            CreateMap<Event, EventProgramDto>();
            CreateMap<Presentation, PresentationDto>()
                .ForMember(d => d.StartTime, 
                    s => s.MapFrom(x => x.StartTime.ToString("hh\\:mm")))
                .ForMember(d => d.EndTime, 
                    s => s.MapFrom(x => x.EndTime.ToString("hh\\:mm")));
        }
    }
}