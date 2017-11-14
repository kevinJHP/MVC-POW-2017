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
    public class CustomerTypesController : Controller
    {
        private _20171112Context db = new _20171112Context();

        // GET: /CustomerTypes/
        public ActionResult Index()
        {
            return View(db.CustomerTypes.ToList());
        }

        // GET: /CustomerTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerTypes customertypes = db.CustomerTypes.Find(id);
            if (customertypes == null)
            {
                return HttpNotFound();
            }
            return View(customertypes);
        }

        // GET: /CustomerTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /CustomerTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CustomerTypeID,Type")] CustomerTypes customertypes)
        {
            if (ModelState.IsValid)
            {
                db.CustomerTypes.Add(customertypes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customertypes);
        }

        // GET: /CustomerTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerTypes customertypes = db.CustomerTypes.Find(id);
            if (customertypes == null)
            {
                return HttpNotFound();
            }
            return View(customertypes);
        }

        // POST: /CustomerTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CustomerTypeID,Type")] CustomerTypes customertypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customertypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customertypes);
        }

        // GET: /CustomerTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerTypes customertypes = db.CustomerTypes.Find(id);
            if (customertypes == null)
            {
                return HttpNotFound();
            }
            return View(customertypes);
        }

        // POST: /CustomerTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerTypes customertypes = db.CustomerTypes.Find(id);
            db.CustomerTypes.Remove(customertypes);
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
