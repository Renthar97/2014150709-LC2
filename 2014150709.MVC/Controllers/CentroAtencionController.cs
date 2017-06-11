using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014150709_ENT.Entities;
using _2014150709_PER;

namespace _2014150709.MVC.Controllers
{
    public class CentroAtencionController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: CentroAtencion
        public ActionResult Index()
        {
            return View(db.CentroAtencions.ToList());
        }

        // GET: CentroAtencion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencions.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // GET: CentroAtencion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CentroAtencion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CentroAtencionId,Nombre")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.CentroAtencions.Add(centroAtencion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(centroAtencion);
        }

        // GET: CentroAtencion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencions.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentroAtencion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CentroAtencionId,Nombre")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centroAtencion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(centroAtencion);
        }

        // GET: CentroAtencion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencions.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentroAtencion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CentroAtencion centroAtencion = db.CentroAtencions.Find(id);
            db.CentroAtencions.Remove(centroAtencion);
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
