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
    public class IdiomasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Idiomas
        public ActionResult Index()
        {
            return View(db.Idiomas.ToList());
        }

        // GET: Idiomas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idiomas idiomas = db.Idiomas.Find(id);
            if (idiomas == null)
            {
                return HttpNotFound();
            }
            return View(idiomas);
        }

        // GET: Idiomas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Idiomas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Idiomas idiomas)
        {
            if (ModelState.IsValid)
            {
                db.Idiomas.Add(idiomas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(idiomas);
        }

        // GET: Idiomas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idiomas idiomas = db.Idiomas.Find(id);
            if (idiomas == null)
            {
                return HttpNotFound();
            }
            return View(idiomas);
        }

        // POST: Idiomas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Idiomas idiomas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(idiomas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(idiomas);
        }

        // GET: Idiomas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idiomas idiomas = db.Idiomas.Find(id);
            if (idiomas == null)
            {
                return HttpNotFound();
            }
            return View(idiomas);
        }

        // POST: Idiomas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Idiomas idiomas = db.Idiomas.Find(id);
            db.Idiomas.Remove(idiomas);
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
