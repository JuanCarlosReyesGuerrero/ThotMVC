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
    public class MetodologiasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Metodologias
        public ActionResult Index()
        {
            return View(db.Metodologias.ToList());
        }

        // GET: Metodologias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // GET: Metodologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metodologias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Metodologias metodologias)
        {
            if (ModelState.IsValid)
            {
                db.Metodologias.Add(metodologias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metodologias);
        }

        // GET: Metodologias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // POST: Metodologias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Metodologias metodologias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metodologias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metodologias);
        }

        // GET: Metodologias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // POST: Metodologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Metodologias metodologias = db.Metodologias.Find(id);
            db.Metodologias.Remove(metodologias);
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
