using Marketim.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Marketim.Controllers
{
    public class ProductController : Controller
    {
        MarketDB db = new MarketDB();
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.ProductId > 0).ToList();
            return View(urun);
        }



        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product model , string Productname  ,HttpPostedFileBase Productimage ,int ProductPrice)
        {
            try
            {
                if (Productimage != null)
                {

                    WebImage img = new WebImage(Productimage.InputStream);
                    FileInfo fotoinfo = new FileInfo(Productimage.FileName);
                    string yenifoto = Guid.NewGuid().ToString();
                    img.Resize(220, 200);
                    img.Save("~/App_Data/uploads/"+yenifoto);
                    model.Productimage = "~/App_Data/uploads/" + yenifoto;
                    db.Products.Add(model);
                    db.SaveChanges();
                }
                db.Products.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var urun = db.Products.Where(i => i.ProductId == id).SingleOrDefault();
            return View(urun);
            
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product model)
        {
            try
            {
                var sonuc = db.Products.Where(i => i.ProductId == id).SingleOrDefault();
                db.Products.Remove(sonuc);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
