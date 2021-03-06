using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.DockerApplication.Dal.Entities
{
    public class Event
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageLink { get; set; }

        public DateTime StartDate { get; set; }

        public bool IsRegistrationOpen { get; protected set; }

        public void CloseRegistration() => IsRegistrationOpen = false;
        
        public virtual ICollection<Presentation> Presentations { get; set; }
    }
}