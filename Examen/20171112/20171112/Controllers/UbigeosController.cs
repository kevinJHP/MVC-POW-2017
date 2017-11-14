using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _20171112.Models;

namespace _20171112.Controllers
{
    public class UbigeosController : Controller
    {
        private _20171112Context db = new _20171112Context();

        // GET: /Ubigeos/
        public ActionResult Index()
        {
            return View(db.Ubigeos.ToList());
        }

        // GET: /Ubigeos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeos ubigeos = db.Ubigeos.Find(id);
            if (ubigeos == null)
            {
                return HttpNotFound();
            }
            return View(ubigeos);
        }

        // GET: /Ubigeos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Ubigeos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UbigeoID,Pais,Departamento,Provincia,Distrito")] Ubigeos ubigeos)
        {
            if (ModelState.IsValid)
            {
                db.Ubigeos.Add(ubigeos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ubigeos);
        }

        // GET: /Ubigeos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeos ubigeos = db.Ubigeos.Find(id);
            if (ubigeos == null)
            {
                return HttpNotFound();
            }
            return View(ubigeos);
        }

        // POST: /Ubigeos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UbigeoID,Pais,Departamento,Provincia,Distrito")] Ubigeos ubigeos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ubigeos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ubigeos);
        }

        // GET: /Ubigeos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeos ubigeos = db.Ubigeos.Find(id);
            if (ubigeos == null)
            {
                return HttpNotFound();
            }
            return View(ubigeos);
        }

        // POST: /Ubigeos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ubigeos ubigeos = db.Ubigeos.Find(id);
            db.Ubigeos.Remove(ubigeos);
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
