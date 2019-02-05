using Marketim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketim.Controllers
{
    public class ArrearController : Controller
    {
        MarketDB db = new MarketDB();

        // GET: Arrear
        public ActionResult Index()
        {
            var tumu = db.Arrears.Where(i => i.Arrearıd > 0).ToList();

            return View(tumu);
        }

        // GET: Arrear/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Arrear/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Arrear/Create
        [HttpPost]
        public ActionResult Create(Arrear model)
        {
            try
            {
                db.Arrears.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Arrear/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Arrear/Edit/5
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

        // GET: Arrear/Delete/5
        public ActionResult Delete(int id)
        {
            var veresiye = db.Arrears.Where(i => i.Arrearıd == id).SingleOrDefault();
            return View(veresiye);
        }

        // POST: Arrear/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Arrear model)
        {
            try
            {
                var veresiyee = db.Arrears.Where(i => i.Arrearıd == id).SingleOrDefault();
                db.Arrears.Remove(veresiyee);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Listele()
        {
            var liste = db.Arrears.Where(i => i.Arrearıd > 0).ToList();

            return View(liste);

        }
    }
}
