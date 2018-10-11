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
    public class RegimenCostosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RegimenCostos
        public ActionResult Index()
        {
            return View(db.RegimenCostos.ToList());
        }

        // GET: RegimenCostos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // GET: RegimenCostos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegimenCostos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] RegimenCostos regimenCostos)
        {
            if (ModelState.IsValid)
            {
                db.RegimenCostos.Add(regimenCostos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regimenCostos);
        }

        // GET: RegimenCostos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // POST: RegimenCostos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] RegimenCostos regimenCostos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regimenCostos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regimenCostos);
        }

        // GET: RegimenCostos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // POST: RegimenCostos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            db.RegimenCostos.Remove(regimenCostos);
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
