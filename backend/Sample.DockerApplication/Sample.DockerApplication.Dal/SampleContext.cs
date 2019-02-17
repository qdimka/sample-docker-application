using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Sample.DockerApplication.Dal.Entities;

namespace Sample.DockerApplication.Dal
{
    public class SampleContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        
        public DbSet<EventProgram> EventPrograms { get; set; }
        
        public DbSet<Presentation> Presentations { get; set; }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
        }
    }
}