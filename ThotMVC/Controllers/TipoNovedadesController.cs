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
    public class TipoNovedadesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoNovedades
        public ActionResult Index()
        {
            return View(db.TipoNovedades.ToList());
        }

        // GET: TipoNovedades/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoNovedades tipoNovedades = db.TipoNovedades.Find(id);
            if (tipoNovedades == null)
            {
                return HttpNotFound();
            }
            return View(tipoNovedades);
        }

        // GET: TipoNovedades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoNovedades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoNovedades tipoNovedades)
        {
            if (ModelState.IsValid)
            {
                db.TipoNovedades.Add(tipoNovedades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoNovedades);
        }

        // GET: TipoNovedades/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoNovedades tipoNovedades = db.TipoNovedades.Find(id);
            if (tipoNovedades == null)
            {
                return HttpNotFound();
            }
            return View(tipoNovedades);
        }

        // POST: TipoNovedades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoNovedades tipoNovedades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoNovedades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoNovedades);
        }

        // GET: TipoNovedades/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoNovedades tipoNovedades = db.TipoNovedades.Find(id);
            if (tipoNovedades == null)
            {
                return HttpNotFound();
            }
            return View(tipoNovedades);
        }

        // POST: TipoNovedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoNovedades tipoNovedades = db.TipoNovedades.Find(id);
            db.TipoNovedades.Remove(tipoNovedades);
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
