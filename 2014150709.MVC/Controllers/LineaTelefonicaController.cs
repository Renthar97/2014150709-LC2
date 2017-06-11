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
    public class LineaTelefonicaController : Controller
    {
        private LineasNuevasDbContext db = new LineasNuevasDbContext();

        // GET: LineaTelefonica
        public ActionResult Index()
        {
            return View(db.LineaTelefonica.ToList());
        }

        // GET: LineaTelefonica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaTelefonica/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaTelefonica_Id,Operador,Numero")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.LineaTelefonica.Add(lineaTelefonica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonica/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaTelefonica_Id,Operador,Numero")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineaTelefonica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            db.LineaTelefonica.Remove(lineaTelefonica);
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
