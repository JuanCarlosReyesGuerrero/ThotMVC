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
    public class TipoCaracteresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoCaracteres
        public ActionResult Index()
        {
            return View(db.TipoCaracteres.ToList());
        }

        // GET: TipoCaracteres/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCaracteres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCaracteres tipoCaracteres)
        {
            if (ModelState.IsValid)
            {
                db.TipoCaracteres.Add(tipoCaracteres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // POST: TipoCaracteres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCaracteres tipoCaracteres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCaracteres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // POST: TipoCaracteres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            db.TipoCaracteres.Remove(tipoCaracteres);
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
