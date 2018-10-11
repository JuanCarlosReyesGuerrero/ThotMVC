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
    public class ArsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ars
        public ActionResult Index()
        {
            return View(db.Ars.ToList());
        }

        // GET: Ars/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // GET: Ars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Ars ars)
        {
            if (ModelState.IsValid)
            {
                db.Ars.Add(ars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ars);
        }

        // GET: Ars/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // POST: Ars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Ars ars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ars);
        }

        // GET: Ars/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // POST: Ars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Ars ars = db.Ars.Find(id);
            db.Ars.Remove(ars);
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
