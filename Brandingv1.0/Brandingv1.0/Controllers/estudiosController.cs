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
    public class estudiosController : Controller
    {
        private Brandingv10Context db = new Brandingv10Context();

        // GET: /estudios/
        public ActionResult Index()
        {
            return View(db.estudios.ToList());
        }

        // GET: /estudios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estudios estudios = db.estudios.Find(id);
            if (estudios == null)
            {
                return HttpNotFound();
            }
            return View(estudios);
        }

        // GET: /estudios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /estudios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="estudiosID,institucion,especialidad,fechaini,fechafin")] estudios estudios)
        {
            if (ModelState.IsValid)
            {
                db.estudios.Add(estudios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estudios);
        }

        // GET: /estudios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estudios estudios = db.estudios.Find(id);
            if (estudios == null)
            {
                return HttpNotFound();
            }
            return View(estudios);
        }

        // POST: /estudios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="estudiosID,institucion,especialidad,fechaini,fechafin")] estudios estudios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estudios);
        }

        // GET: /estudios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estudios estudios = db.estudios.Find(id);
            if (estudios == null)
            {
                return HttpNotFound();
            }
            return View(estudios);
        }

        // POST: /estudios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            estudios estudios = db.estudios.Find(id);
            db.estudios.Remove(estudios);
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
