using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OLZ_beta.Models;

namespace OLZ_beta.Controllers
{
    public class HomeController : Controller
    {
        private AnuncioDB db = new AnuncioDB();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Anuncios.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(Anuncio anuncio, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                          + file.FileName);
                    anuncio.ImagePath = file.FileName;
                }
                db.Anuncios.Add(anuncio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anuncio);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anuncio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anuncio);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }



        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Anuncio anuncio = db.Anuncios.Find(id);
            db.Anuncios.Remove(anuncio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}