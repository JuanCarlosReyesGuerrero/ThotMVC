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
    public class TipoRespuestasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoRespuestas
        public ActionResult Index()
        {
            return View(db.TipoRespuestas.ToList());
        }

        // GET: TipoRespuestas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoRespuestas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoRespuestas tipoRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.TipoRespuestas.Add(tipoRespuestas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // POST: TipoRespuestas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoRespuestas tipoRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoRespuestas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // POST: TipoRespuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            db.TipoRespuestas.Remove(tipoRespuestas);
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
