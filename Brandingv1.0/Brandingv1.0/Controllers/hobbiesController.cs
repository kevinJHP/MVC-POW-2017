using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Brandingv1._0.Models;

namespace Brandingv1._0.Controllers
{
    public class hobbiesController : Controller
    {
        private Brandingv10Context db = new Brandingv10Context();

        // GET: /hobbies/
        public ActionResult Index()
        {
            return View(db.hobbies.ToList());
        }

        // GET: /hobbies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hobbies hobbies = db.hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // GET: /hobbies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /hobbies/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="estudiosID,hobbie,descripcion")] hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.hobbies.Add(hobbies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hobbies);
        }

        // GET: /hobbies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hobbies hobbies = db.hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // POST: /hobbies/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="estudiosID,hobbie,descripcion")] hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobbies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobbies);
        }

        // GET: /hobbies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hobbies hobbies = db.hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // POST: /hobbies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hobbies hobbies = db.hobbies.Find(id);
            db.hobbies.Remove(hobbies);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
