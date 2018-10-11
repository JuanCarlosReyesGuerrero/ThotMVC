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
    public class LibretaMilitaresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LibretaMilitares
        public ActionResult Index()
        {
            return View(db.LibretaMilitares.ToList());
        }

        // GET: LibretaMilitares/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibretaMilitares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] LibretaMilitares libretaMilitares)
        {
            if (ModelState.IsValid)
            {
                db.LibretaMilitares.Add(libretaMilitares);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // POST: LibretaMilitares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] LibretaMilitares libretaMilitares)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libretaMilitares).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // POST: LibretaMilitares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            db.LibretaMilitares.Remove(libretaMilitares);
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
