using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTViDuMVCGiaiPTBac1.Models;

namespace BTViDuMVCGiaiPTBac1.Controllers
{
    public class PersonController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();

        // GET: Person
        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person ps)
        {
            if(ModelState.IsValid)
            {
                db.Persons.Add(ps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }    
            return View();
        }
    }
}