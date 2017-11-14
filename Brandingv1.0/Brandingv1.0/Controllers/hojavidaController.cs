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
    public class hojavidaController : Controller
    {
        private Brandingv10Context db = new Brandingv10Context();

        // GET: /hojavida/
        public ActionResult Index()
        {
            return View(db.hojavidas.ToList());
        }

        // GET: /hojavida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hojavida hojavida = db.hojavidas.Find(id);
            if (hojavida == null)
            {
                return HttpNotFound();
            }
            return View(hojavida);
        }

        // GET: /hojavida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /hojavida/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="hojavidaID,institucion,puesto,fechaini,fechafin")] hojavida hojavida)
        {
            if (ModelState.IsValid)
            {
                db.hojavidas.Add(hojavida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hojavida);
        }

        // GET: /hojavida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hojavida hojavida = db.hojavidas.Find(id);
            if (hojavida == null)
            {
                return HttpNotFound();
            }
            return View(hojavida);
        }

        // POST: /hojavida/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="hojavidaID,institucion,puesto,fechaini,fechafin")] hojavida hojavida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hojavida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hojavida);
        }

        // GET: /hojavida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hojavida hojavida = db.hojavidas.Find(id);
            if (hojavida == null)
            {
                return HttpNotFound();
            }
            return View(hojavida);
        }

        // POST: /hojavida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hojavida hojavida = db.hojavidas.Find(id);
            db.hojavidas.Remove(hojavida);
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
