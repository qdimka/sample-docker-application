using System;

namespace Sample.DockerApplication.Dal.Entities
{
    public class Presentation
    {
        public long Id { get; set; }

        public long EventId { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Author { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }
    }
}