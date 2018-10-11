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
    public class EscalafonesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Escalafones
        public ActionResult Index()
        {
            return View(db.Escalafones.ToList());
        }

        // GET: Escalafones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escalafones escalafones = db.Escalafones.Find(id);
            if (escalafones == null)
            {
                return HttpNotFound();
            }
            return View(escalafones);
        }

        // GET: Escalafones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escalafones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Escalafones escalafones)
        {
            if (ModelState.IsValid)
            {
                db.Escalafones.Add(escalafones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(escalafones);
        }

        // GET: Escalafones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escalafones escalafones = db.Escalafones.Find(id);
            if (escalafones == null)
            {
                return HttpNotFound();
            }
            return View(escalafones);
        }

        // POST: Escalafones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Escalafones escalafones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escalafones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(escalafones);
        }

        // GET: Escalafones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escalafones escalafones = db.Escalafones.Find(id);
            if (escalafones == null)
            {
                return HttpNotFound();
            }
            return View(escalafones);
        }

        // POST: Escalafones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Escalafones escalafones = db.Escalafones.Find(id);
            db.Escalafones.Remove(escalafones);
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
