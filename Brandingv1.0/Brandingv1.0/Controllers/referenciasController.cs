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
    public class referenciasController : Controller
    {
        private Brandingv10Context db = new Brandingv10Context();

        // GET: /referencias/
        public ActionResult Index()
        {
            return View(db.referencias.ToList());
        }

        // GET: /referencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencias referencias = db.referencias.Find(id);
            if (referencias == null)
            {
                return HttpNotFound();
            }
            return View(referencias);
        }

        // GET: /referencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /referencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="referenciasID,persona,telefono,entidad,puesto")] referencias referencias)
        {
            if (ModelState.IsValid)
            {
                db.referencias.Add(referencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referencias);
        }

        // GET: /referencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencias referencias = db.referencias.Find(id);
            if (referencias == null)
            {
                return HttpNotFound();
            }
            return View(referencias);
        }

        // POST: /referencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="referenciasID,persona,telefono,entidad,puesto")] referencias referencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referencias);
        }

        // GET: /referencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencias referencias = db.referencias.Find(id);
            if (referencias == null)
            {
                return HttpNotFound();
            }
            return View(referencias);
        }

        // POST: /referencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            referencias referencias = db.referencias.Find(id);
            db.referencias.Remove(referencias);
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
