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
    public class EquipoCelularController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: EquipoCelular
        public ActionResult Index()
        {
            return View(db.EquipoCelular.ToList());
        }

        // GET: EquipoCelular/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoCelular/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoCelular_Id,Nombre_Equipo,Marca_Equipo")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.EquipoCelular.Add(equipoCelular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipoCelular);
        }

        // GET: EquipoCelular/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelular/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoCelular_Id,Nombre_Equipo,Marca_Equipo")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipoCelular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelular/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            db.EquipoCelular.Remove(equipoCelular);
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
