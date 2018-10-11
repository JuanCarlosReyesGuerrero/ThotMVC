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
    public class EquivalenciasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Equivalencias
        public ActionResult Index()
        {
            var equivalencias = db.Equivalencias.Include(e => e.Sedes).Include(e => e.ValoracionLetras);
            return View(equivalencias.ToList());
        }

        // GET: Equivalencias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            return View(equivalencias);
        }

        // GET: Equivalencias/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo");
            return View();
        }

        // POST: Equivalencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,EquivalenciaRangoNumerico,ValoracionLetraId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Equivalencias equivalencias)
        {
            if (ModelState.IsValid)
            {
                db.Equivalencias.Add(equivalencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // GET: Equivalencias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // POST: Equivalencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,EquivalenciaRangoNumerico,ValoracionLetraId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Equivalencias equivalencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equivalencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // GET: Equivalencias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            return View(equivalencias);
        }

        // POST: Equivalencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            db.Equivalencias.Remove(equivalencias);
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
