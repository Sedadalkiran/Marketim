using Marketim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketim.Controllers
{
    public class HomeController : Controller
    {
        MarketDB db = new MarketDB();
        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.ProductId > 0).ToList();
            return View(urun);
        }

        public ActionResult About()
        {
            return View();

        }

        public ActionResult Tumunugoster()
        {


            var urun = db.Products.Where(i => i.ProductId > 0).ToList();
            return View(urun);

        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}