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
    public class AporteParafiscalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AporteParafiscales
        public ActionResult Index()
        {
            return View(db.AporteParafiscales.ToList());
        }

        // GET: AporteParafiscales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AporteParafiscales aporteParafiscales = db.AporteParafiscales.Find(id);
            if (aporteParafiscales == null)
            {
                return HttpNotFound();
            }
            return View(aporteParafiscales);
        }

        // GET: AporteParafiscales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AporteParafiscales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] AporteParafiscales aporteParafiscales)
        {
            if (ModelState.IsValid)
            {
                db.AporteParafiscales.Add(aporteParafiscales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aporteParafiscales);
        }

        // GET: AporteParafiscales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AporteParafiscales aporteParafiscales = db.AporteParafiscales.Find(id);
            if (aporteParafiscales == null)
            {
                return HttpNotFound();
            }
            return View(aporteParafiscales);
        }

        // POST: AporteParafiscales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] AporteParafiscales aporteParafiscales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aporteParafiscales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aporteParafiscales);
        }

        // GET: AporteParafiscales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AporteParafiscales aporteParafiscales = db.AporteParafiscales.Find(id);
            if (aporteParafiscales == null)
            {
                return HttpNotFound();
            }
            return View(aporteParafiscales);
        }

        // POST: AporteParafiscales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AporteParafiscales aporteParafiscales = db.AporteParafiscales.Find(id);
            db.AporteParafiscales.Remove(aporteParafiscales);
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
