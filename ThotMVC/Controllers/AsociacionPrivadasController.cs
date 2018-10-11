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
    public class AsociacionPrivadasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AsociacionPrivadas
        public ActionResult Index()
        {
            return View(db.AsociacionPrivadas.ToList());
        }

        // GET: AsociacionPrivadas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsociacionPrivadas asociacionPrivadas = db.AsociacionPrivadas.Find(id);
            if (asociacionPrivadas == null)
            {
                return HttpNotFound();
            }
            return View(asociacionPrivadas);
        }

        // GET: AsociacionPrivadas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsociacionPrivadas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] AsociacionPrivadas asociacionPrivadas)
        {
            if (ModelState.IsValid)
            {
                db.AsociacionPrivadas.Add(asociacionPrivadas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asociacionPrivadas);
        }

        // GET: AsociacionPrivadas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsociacionPrivadas asociacionPrivadas = db.AsociacionPrivadas.Find(id);
            if (asociacionPrivadas == null)
            {
                return HttpNotFound();
            }
            return View(asociacionPrivadas);
        }

        // POST: AsociacionPrivadas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] AsociacionPrivadas asociacionPrivadas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asociacionPrivadas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asociacionPrivadas);
        }

        // GET: AsociacionPrivadas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsociacionPrivadas asociacionPrivadas = db.AsociacionPrivadas.Find(id);
            if (asociacionPrivadas == null)
            {
                return HttpNotFound();
            }
            return View(asociacionPrivadas);
        }

        // POST: AsociacionPrivadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AsociacionPrivadas asociacionPrivadas = db.AsociacionPrivadas.Find(id);
            db.AsociacionPrivadas.Remove(asociacionPrivadas);
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
