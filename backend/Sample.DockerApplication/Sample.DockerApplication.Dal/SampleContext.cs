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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder
                .Entity<Presentation>()
                .HasData(new
                    {
                        Id = 1L,
                        Title = "A quick guide to help you understand and create ReactJS apps",
                        Author = "John Smith",
                        Company = "VeryCoolCompany Inc.",
                        StartTime = TimeSpan.Parse("10:00"),
                        EndTime = TimeSpan.Parse("12:00"),
                        EventProgramId = 1L
                    },
                    new 
                    {
                        Id = 2L,
                        Title = "ASP.NET Web Deployment using Visual Studio",
                        Author = "Robert Johnson",
                        Company = "BigCompany Inc.",
                        StartTime = TimeSpan.Parse("12:00"),
                        EndTime = TimeSpan.Parse("14:00"),
                        EventProgramId = 1L
                    },
                    new 
                    {
                        Id = 3L,
                        Title = "Coffee",
                        StartTime = TimeSpan.Parse("14:00"),
                        EndTime = TimeSpan.Parse("15:00"),
                        EventProgramId = 1L
                    },
                    new
                    {
                        Id = 4L,
                        Title = "Here are 9 effective best practices for using DevOps in the cloud",
                        Author = "David Linthicum",
                        Company = "Deloitte Consulting",
                        StartTime = TimeSpan.Parse("15:00"),
                        EndTime = TimeSpan.Parse("17:00"),
                        EventProgramId = 1L
                    }
                );
            
            modelBuilder
                .Entity<EventProgram>()
                .HasData(new
                {
                    Id = 1L,
                });
            
            modelBuilder
                .Entity<Event>()
                .HasData(new
                {
                    Id = 1L,
                    Title = "Technology Conference",
                    EventProgramId = 1L,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                  "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                  "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
                                  "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                                  "in reprehenderit in voluptate velit esse cillum dolore eu fugiat " +
                                  "nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                  " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    StartDate = DateTime.Now.Date,
                    IsRegistrationOpen = false
                });

        }
    }
}