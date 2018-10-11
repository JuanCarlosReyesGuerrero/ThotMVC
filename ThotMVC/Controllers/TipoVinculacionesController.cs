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
    public class TipoVinculacionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoVinculaciones
        public ActionResult Index()
        {
            return View(db.TipoVinculaciones.ToList());
        }

        // GET: TipoVinculaciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVinculaciones tipoVinculaciones = db.TipoVinculaciones.Find(id);
            if (tipoVinculaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoVinculaciones);
        }

        // GET: TipoVinculaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoVinculaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoVinculaciones tipoVinculaciones)
        {
            if (ModelState.IsValid)
            {
                db.TipoVinculaciones.Add(tipoVinculaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoVinculaciones);
        }

        // GET: TipoVinculaciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVinculaciones tipoVinculaciones = db.TipoVinculaciones.Find(id);
            if (tipoVinculaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoVinculaciones);
        }

        // POST: TipoVinculaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoVinculaciones tipoVinculaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoVinculaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoVinculaciones);
        }

        // GET: TipoVinculaciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVinculaciones tipoVinculaciones = db.TipoVinculaciones.Find(id);
            if (tipoVinculaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoVinculaciones);
        }

        // POST: TipoVinculaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoVinculaciones tipoVinculaciones = db.TipoVinculaciones.Find(id);
            db.TipoVinculaciones.Remove(tipoVinculaciones);
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
