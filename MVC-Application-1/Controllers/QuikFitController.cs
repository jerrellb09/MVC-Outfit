using MVC_Application_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_1.Controllers
{
    public class QuikFitController : Controller
    {
        // GET: QuikFit
        public ActionResult Index()
        {
            var outfitList = new List<Outfit>{

                new Outfit() {Belt = true, Bottom = "Shorts", Glasses = false, HeadDress = "Hat", Shoes = "Sneakers", Socks = true, Top = "Jersey" }
            };

            return View(outfitList);
        }

        // GET: QuikFit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuikFit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuikFit/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuikFit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuikFit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuikFit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuikFit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Generate(string style)
        {
            return View();
        }
    }
}
