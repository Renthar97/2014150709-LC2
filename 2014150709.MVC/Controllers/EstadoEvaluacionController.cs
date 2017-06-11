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
    public class EstadoEvaluacionController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: EstadoEvaluacion
        public ActionResult Index()
        {
            return View(db.EstadoEvaluacion.ToList());
        }

        // GET: EstadoEvaluacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoEvaluacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstadoEvaluacionId,Estado")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.EstadoEvaluacion.Add(estadoEvaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstadoEvaluacionId,Estado")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoEvaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            db.EstadoEvaluacion.Remove(estadoEvaluacion);
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
