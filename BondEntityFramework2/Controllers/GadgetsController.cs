using BondEntityFramework2.Models;
//using BondEntityFramework2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BondEntityFramework2.Controllers
{
    public class GadgetsController : Controller
    {
        private ApplicationDbContext context;

        public GadgetsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose();
        }

        // GET: Gadgets
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Details(int id)
        {
            return View("Details");
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult Edit(int id)
        {
            return View("Create");
        }

        public ActionResult Delete(int id)
        {
            return View("Index");
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            return View("SearchResults"); //searchResults);
        }

        [HttpPost]
        public ActionResult ProcessCreate(GadgetModel gadgetModel)
        {
            return View("Details");
        }
    }
}