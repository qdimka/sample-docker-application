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
                        EventId = 1L
                    },
                    new 
                    {
                        Id = 2L,
                        Title = "ASP.NET Web Deployment using Visual Studio",
                        Author = "Robert Johnson",
                        Company = "BigCompany Inc.",
                        StartTime = TimeSpan.Parse("12:00"),
                        EndTime = TimeSpan.Parse("14:00"),
                        EventId = 1L
                    },
                    new 
                    {
                        Id = 3L,
                        Title = "Coffee",
                        StartTime = TimeSpan.Parse("14:00"),
                        EndTime = TimeSpan.Parse("15:00"),
                        EventId = 1L
                    },
                    new
                    {
                        Id = 4L,
                        Title = "Here are 9 effective best practices for using DevOps in the cloud",
                        Author = "David Linthicum",
                        Company = "Deloitte Consulting",
                        StartTime = TimeSpan.Parse("15:00"),
                        EndTime = TimeSpan.Parse("17:00"),
                        EventId = 1L
                    },new
                    {
                        Id = 5L,
                        Title = "A quick guide to help you understand and create ReactJS apps",
                        Author = "John Smith",
                        Company = "VeryCoolCompany Inc.",
                        StartTime = TimeSpan.Parse("10:00"),
                        EndTime = TimeSpan.Parse("12:00"),
                        EventId = 2L
                    },
                    new 
                    {
                        Id = 6L,
                        Title = "ASP.NET Web Deployment using Visual Studio",
                        Author = "Robert Johnson",
                        Company = "BigCompany Inc.",
                        StartTime = TimeSpan.Parse("12:00"),
                        EndTime = TimeSpan.Parse("14:00"),
                        EventId = 2L
                    },
                    new 
                    {
                        Id = 7L,
                        Title = "Coffee",
                        StartTime = TimeSpan.Parse("14:00"),
                        EndTime = TimeSpan.Parse("15:00"),
                        EventId = 2L
                    },
                    new
                    {
                        Id = 8L,
                        Title = "Here are 9 effective best practices for using DevOps in the cloud",
                        Author = "David Linthicum",
                        Company = "Deloitte Consulting",
                        StartTime = TimeSpan.Parse("15:00"),
                        EndTime = TimeSpan.Parse("17:00"),
                        EventId = 2L
                    },
                    new
                    {
                        Id = 9L,
                        Title = "Rubber duck and debug",
                        Author = "Pragmatic Programmer",
                        Company = "Duck Factory",
                        StartTime = TimeSpan.Parse("10:00"),
                        EndTime = TimeSpan.Parse("15:00"),
                        EventId = 3L
                    }
                );
            
            modelBuilder
                .Entity<Event>()
                .HasData(new
                {
                    Id = 1L,
                    Title = "Technology Conference",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                  "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                  "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ",
                    StartDate = DateTime.Now.Date,
                    IsRegistrationOpen = false,
                    ImageLink = "https://digital.report/wp-content/uploads/2017/04/615124073-1078x516.jpg"
                },new
                {
                    Id = 2L,
                    Title = "Docker meetup",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                  "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                  "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ",
                    StartDate = DateTime.Now.Date.AddDays(22),
                    IsRegistrationOpen = false,
                    ImageLink = "https://cdn-images-1.medium.com/max/2600/1*JAJ910fg52ODIRZjHXASBQ.png"
                },new
                {
                    Id = 3L,
                    Title = "Rubber duck debugging",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                  "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                  "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ",
                    StartDate = DateTime.Now.Date.AddDays(12),
                    IsRegistrationOpen = false,
                    ImageLink = "https://pics.me.me/rubber-duck-debugging-the-rubber-duck-debugging-method-is-as-18277289.png"
                });

        }
    }
}