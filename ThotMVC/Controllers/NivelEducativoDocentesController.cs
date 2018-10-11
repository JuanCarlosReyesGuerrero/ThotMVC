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
    public class NivelEducativoDocentesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NivelEducativoDocentes
        public ActionResult Index()
        {
            return View(db.NivelEducativoDocentes.ToList());
        }

        // GET: NivelEducativoDocentes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativoDocentes nivelEducativoDocentes = db.NivelEducativoDocentes.Find(id);
            if (nivelEducativoDocentes == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativoDocentes);
        }

        // GET: NivelEducativoDocentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NivelEducativoDocentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] NivelEducativoDocentes nivelEducativoDocentes)
        {
            if (ModelState.IsValid)
            {
                db.NivelEducativoDocentes.Add(nivelEducativoDocentes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nivelEducativoDocentes);
        }

        // GET: NivelEducativoDocentes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativoDocentes nivelEducativoDocentes = db.NivelEducativoDocentes.Find(id);
            if (nivelEducativoDocentes == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativoDocentes);
        }

        // POST: NivelEducativoDocentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] NivelEducativoDocentes nivelEducativoDocentes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nivelEducativoDocentes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nivelEducativoDocentes);
        }

        // GET: NivelEducativoDocentes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativoDocentes nivelEducativoDocentes = db.NivelEducativoDocentes.Find(id);
            if (nivelEducativoDocentes == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativoDocentes);
        }

        // POST: NivelEducativoDocentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            NivelEducativoDocentes nivelEducativoDocentes = db.NivelEducativoDocentes.Find(id);
            db.NivelEducativoDocentes.Remove(nivelEducativoDocentes);
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
