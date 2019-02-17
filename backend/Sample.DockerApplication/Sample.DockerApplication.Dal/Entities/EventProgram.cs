using System.Collections.Generic;

namespace Sample.DockerApplication.Dal.Entities
{
    public class EventProgram
    {
        public long Id { get; set; }

        public virtual List<Presentation> Presentations { get; set; }
    }
}