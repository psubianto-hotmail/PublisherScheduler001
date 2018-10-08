using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PublisherScheduler001.Models
{
    public class PublisherSchedulerContext : DbContext
    {
        public PublisherSchedulerContext() : base("PublisherScheduler")
        {

        }

        public DbSet<PersonEntry> Entries { get; set; }
    }
}