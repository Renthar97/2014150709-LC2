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
    public class AdministradorEquipoController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: AdministradorEquipo
        public ActionResult Index()
        {
            return View(db.AdministradorEquipo.ToList());
        }

        // GET: AdministradorEquipo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorEquipo_Id,Nombre_AdEquipo,Apellido_Paterno_AdEquipo,Apellido_Materno_AdEquipo,Dni")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                db.AdministradorEquipo.Add(administradorEquipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorEquipo);
        }

        // GET: AdministradorEquipo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorEquipo_Id,Nombre_AdEquipo,Apellido_Paterno_AdEquipo,Apellido_Materno_AdEquipo,Dni")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradorEquipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(id);
            db.AdministradorEquipo.Remove(administradorEquipo);
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
