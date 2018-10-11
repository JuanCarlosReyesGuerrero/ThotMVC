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
    public class TipoDevengosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoDevengos
        public ActionResult Index()
        {
            return View(db.TipoDevengos.ToList());
        }

        // GET: TipoDevengos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDevengos tipoDevengos = db.TipoDevengos.Find(id);
            if (tipoDevengos == null)
            {
                return HttpNotFound();
            }
            return View(tipoDevengos);
        }

        // GET: TipoDevengos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDevengos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoDevengos tipoDevengos)
        {
            if (ModelState.IsValid)
            {
                db.TipoDevengos.Add(tipoDevengos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDevengos);
        }

        // GET: TipoDevengos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDevengos tipoDevengos = db.TipoDevengos.Find(id);
            if (tipoDevengos == null)
            {
                return HttpNotFound();
            }
            return View(tipoDevengos);
        }

        // POST: TipoDevengos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoDevengos tipoDevengos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDevengos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDevengos);
        }

        // GET: TipoDevengos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDevengos tipoDevengos = db.TipoDevengos.Find(id);
            if (tipoDevengos == null)
            {
                return HttpNotFound();
            }
            return View(tipoDevengos);
        }

        // POST: TipoDevengos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoDevengos tipoDevengos = db.TipoDevengos.Find(id);
            db.TipoDevengos.Remove(tipoDevengos);
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
