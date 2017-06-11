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
    public class AdministradorLineaController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: AdministradorLinea
        public ActionResult Index()
        {
            return View(db.AdministradorLinea.ToList());
        }

        // GET: AdministradorLinea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // GET: AdministradorLinea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorLinea/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorLinea_Id,Nombre_AdLinea,Apellido_Paterno_AdLinea,Apellido_Materno_AdLinea,Dni")] AdministradorLinea administradorLinea)
        {
            if (ModelState.IsValid)
            {
                db.AdministradorLinea.Add(administradorLinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorLinea);
        }

        // GET: AdministradorLinea/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // POST: AdministradorLinea/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorLinea_Id,Nombre_AdLinea,Apellido_Paterno_AdLinea,Apellido_Materno_AdLinea,Dni")] AdministradorLinea administradorLinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradorLinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorLinea);
        }

        // GET: AdministradorLinea/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // POST: AdministradorLinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(id);
            db.AdministradorLinea.Remove(administradorLinea);
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
