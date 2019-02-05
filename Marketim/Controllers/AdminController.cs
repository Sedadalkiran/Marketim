using Marketim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketim.Controllers
{
    public class AdminController : Controller
    {
        MarketDB db = new MarketDB();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(Admin model)

        {
            try
            {
                var deger = db.Admins.Where(i => i.Username == model.Username).SingleOrDefault();
                if (deger == null)
                {
                    return RedirectToAction("Index", "Home");

                }
                if (deger.Password == model.Password){

                    Session["username"] = model.Username;
                    return RedirectToAction("Index", "Admin");
                }


                return RedirectToAction("Index", "Home");

            }

            catch {

                return RedirectToAction("Index", "Home");
    }

     


    }

        // GET: Admin/Create
        public ActionResult Create()
        {
    return RedirectToAction("Index", "Home");
}

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Admin model)
        {
            Session["username"] = model.Username;

            try
            {
                db.Admins.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


      


        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
    return RedirectToAction("Index", "Home");
}

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
        // TODO: Add update logic here

        return RedirectToAction("Index", "Home");
    }
            catch
            {
        return RedirectToAction("Index", "Home");
    }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
     return RedirectToAction("Index", "Home");
}

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
        // TODO: Add delete logic here

        return RedirectToAction("Index", "Home");
    }
            catch
            {
        return RedirectToAction("Index", "Home");
    }
        }
    }
}
