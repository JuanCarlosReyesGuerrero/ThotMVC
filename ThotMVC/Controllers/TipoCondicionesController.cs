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
    public class TipoCondicionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoCondiciones
        public ActionResult Index()
        {
            return View(db.TipoCondiciones.ToList());
        }

        // GET: TipoCondiciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCondiciones tipoCondiciones = db.TipoCondiciones.Find(id);
            if (tipoCondiciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoCondiciones);
        }

        // GET: TipoCondiciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCondiciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCondiciones tipoCondiciones)
        {
            if (ModelState.IsValid)
            {
                db.TipoCondiciones.Add(tipoCondiciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCondiciones);
        }

        // GET: TipoCondiciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCondiciones tipoCondiciones = db.TipoCondiciones.Find(id);
            if (tipoCondiciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoCondiciones);
        }

        // POST: TipoCondiciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCondiciones tipoCondiciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCondiciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCondiciones);
        }

        // GET: TipoCondiciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCondiciones tipoCondiciones = db.TipoCondiciones.Find(id);
            if (tipoCondiciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoCondiciones);
        }

        // POST: TipoCondiciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoCondiciones tipoCondiciones = db.TipoCondiciones.Find(id);
            db.TipoCondiciones.Remove(tipoCondiciones);
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
