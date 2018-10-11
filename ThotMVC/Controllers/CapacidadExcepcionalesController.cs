using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThotMVC.Models;

namespace ThotMVC.Controllers
{
    public class CapacidadExcepcionalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CapacidadExcepcionales
        public ActionResult Index()
        {
            return View(db.CapacidadExcepcionales.ToList());
        }

        // GET: CapacidadExcepcionales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapacidadExcepcionales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] CapacidadExcepcionales capacidadExcepcionales)
        {
            if (ModelState.IsValid)
            {
                db.CapacidadExcepcionales.Add(capacidadExcepcionales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // POST: CapacidadExcepcionales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] CapacidadExcepcionales capacidadExcepcionales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capacidadExcepcionales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // POST: CapacidadExcepcionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            db.CapacidadExcepcionales.Remove(capacidadExcepcionales);
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
