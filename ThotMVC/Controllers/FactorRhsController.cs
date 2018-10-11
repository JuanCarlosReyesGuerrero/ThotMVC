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
    public class FactorRhsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FactorRhs
        public ActionResult Index()
        {
            return View(db.FactorRhs.ToList());
        }

        // GET: FactorRhs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // GET: FactorRhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FactorRhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FactorRhs factorRhs)
        {
            if (ModelState.IsValid)
            {
                db.FactorRhs.Add(factorRhs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(factorRhs);
        }

        // GET: FactorRhs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // POST: FactorRhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FactorRhs factorRhs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factorRhs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(factorRhs);
        }

        // GET: FactorRhs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // POST: FactorRhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            db.FactorRhs.Remove(factorRhs);
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
