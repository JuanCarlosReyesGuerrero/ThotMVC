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
    public class TarifaAnualesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TarifaAnuales
        public ActionResult Index()
        {
            return View(db.TarifaAnuales.ToList());
        }

        // GET: TarifaAnuales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TarifaAnuales tarifaAnuales = db.TarifaAnuales.Find(id);
            if (tarifaAnuales == null)
            {
                return HttpNotFound();
            }
            return View(tarifaAnuales);
        }

        // GET: TarifaAnuales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TarifaAnuales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TarifaAnuales tarifaAnuales)
        {
            if (ModelState.IsValid)
            {
                db.TarifaAnuales.Add(tarifaAnuales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarifaAnuales);
        }

        // GET: TarifaAnuales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TarifaAnuales tarifaAnuales = db.TarifaAnuales.Find(id);
            if (tarifaAnuales == null)
            {
                return HttpNotFound();
            }
            return View(tarifaAnuales);
        }

        // POST: TarifaAnuales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TarifaAnuales tarifaAnuales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarifaAnuales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarifaAnuales);
        }

        // GET: TarifaAnuales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TarifaAnuales tarifaAnuales = db.TarifaAnuales.Find(id);
            if (tarifaAnuales == null)
            {
                return HttpNotFound();
            }
            return View(tarifaAnuales);
        }

        // POST: TarifaAnuales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TarifaAnuales tarifaAnuales = db.TarifaAnuales.Find(id);
            db.TarifaAnuales.Remove(tarifaAnuales);
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
