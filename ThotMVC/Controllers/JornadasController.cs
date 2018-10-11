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
    public class JornadasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Jornadas
        public ActionResult Index()
        {
            var jornadas = db.Jornadas.Include(j => j.Sedes);
            return View(jornadas.ToList());
        }

        // GET: Jornadas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornadas jornadas = db.Jornadas.Find(id);
            if (jornadas == null)
            {
                return HttpNotFound();
            }
            return View(jornadas);
        }

        // GET: Jornadas/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Jornadas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Jornadas jornadas)
        {
            if (ModelState.IsValid)
            {
                db.Jornadas.Add(jornadas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", jornadas.SedeId);
            return View(jornadas);
        }

        // GET: Jornadas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornadas jornadas = db.Jornadas.Find(id);
            if (jornadas == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", jornadas.SedeId);
            return View(jornadas);
        }

        // POST: Jornadas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Jornadas jornadas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jornadas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", jornadas.SedeId);
            return View(jornadas);
        }

        // GET: Jornadas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornadas jornadas = db.Jornadas.Find(id);
            if (jornadas == null)
            {
                return HttpNotFound();
            }
            return View(jornadas);
        }

        // POST: Jornadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Jornadas jornadas = db.Jornadas.Find(id);
            db.Jornadas.Remove(jornadas);
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
