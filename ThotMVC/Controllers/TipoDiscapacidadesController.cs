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
    public class TipoDiscapacidadesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoDiscapacidades
        public ActionResult Index()
        {
            return View(db.TipoDiscapacidades.ToList());
        }

        // GET: TipoDiscapacidades/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDiscapacidades tipoDiscapacidades = db.TipoDiscapacidades.Find(id);
            if (tipoDiscapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tipoDiscapacidades);
        }

        // GET: TipoDiscapacidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDiscapacidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoDiscapacidades tipoDiscapacidades)
        {
            if (ModelState.IsValid)
            {
                db.TipoDiscapacidades.Add(tipoDiscapacidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDiscapacidades);
        }

        // GET: TipoDiscapacidades/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDiscapacidades tipoDiscapacidades = db.TipoDiscapacidades.Find(id);
            if (tipoDiscapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tipoDiscapacidades);
        }

        // POST: TipoDiscapacidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoDiscapacidades tipoDiscapacidades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDiscapacidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDiscapacidades);
        }

        // GET: TipoDiscapacidades/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDiscapacidades tipoDiscapacidades = db.TipoDiscapacidades.Find(id);
            if (tipoDiscapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tipoDiscapacidades);
        }

        // POST: TipoDiscapacidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoDiscapacidades tipoDiscapacidades = db.TipoDiscapacidades.Find(id);
            db.TipoDiscapacidades.Remove(tipoDiscapacidades);
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
