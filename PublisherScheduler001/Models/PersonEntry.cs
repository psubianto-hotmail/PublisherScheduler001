using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublisherScheduler001.Models
{
    public class PersonEntry
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}