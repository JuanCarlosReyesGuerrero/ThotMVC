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
    public class EscalaNacionalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EscalaNacionales
        public ActionResult Index()
        {
            var escalaNacionales = db.EscalaNacionales.Include(e => e.Sedes);
            return View(escalaNacionales.ToList());
        }

        // GET: EscalaNacionales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: EscalaNacionales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,CriterioEvalaluacion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EscalaNacionales escalaNacionales)
        {
            if (ModelState.IsValid)
            {
                db.EscalaNacionales.Add(escalaNacionales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // POST: EscalaNacionales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,CriterioEvalaluacion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EscalaNacionales escalaNacionales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escalaNacionales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            return View(escalaNacionales);
        }

        // POST: EscalaNacionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            db.EscalaNacionales.Remove(escalaNacionales);
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
