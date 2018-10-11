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
    public class ResguardosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Resguardos
        public ActionResult Index()
        {
            return View(db.Resguardos.ToList());
        }

        // GET: Resguardos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resguardos resguardos = db.Resguardos.Find(id);
            if (resguardos == null)
            {
                return HttpNotFound();
            }
            return View(resguardos);
        }

        // GET: Resguardos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resguardos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Resguardos resguardos)
        {
            if (ModelState.IsValid)
            {
                db.Resguardos.Add(resguardos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resguardos);
        }

        // GET: Resguardos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resguardos resguardos = db.Resguardos.Find(id);
            if (resguardos == null)
            {
                return HttpNotFound();
            }
            return View(resguardos);
        }

        // POST: Resguardos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Resguardos resguardos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resguardos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resguardos);
        }

        // GET: Resguardos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resguardos resguardos = db.Resguardos.Find(id);
            if (resguardos == null)
            {
                return HttpNotFound();
            }
            return View(resguardos);
        }

        // POST: Resguardos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Resguardos resguardos = db.Resguardos.Find(id);
            db.Resguardos.Remove(resguardos);
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
