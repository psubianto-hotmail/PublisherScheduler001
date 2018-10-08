using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PublisherScheduler001.Models;

namespace PublisherScheduler001.Controllers
{
    public class PersonController : Controller
    {
        private PublisherSchedulerContext _db = new PublisherSchedulerContext();
        
        // GET: Person
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            _db.Entries.Add(entry);
            _db.SaveChanges();

            return Content("New entry successfully added.");
        }
    }
}