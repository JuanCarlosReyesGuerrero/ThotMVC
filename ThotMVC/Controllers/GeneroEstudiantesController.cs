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
    public class GeneroEstudiantesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GeneroEstudiantes
        public ActionResult Index()
        {
            return View(db.GeneroEstudiantes.ToList());
        }

        // GET: GeneroEstudiantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneroEstudiantes generoEstudiantes = db.GeneroEstudiantes.Find(id);
            if (generoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(generoEstudiantes);
        }

        // GET: GeneroEstudiantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneroEstudiantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] GeneroEstudiantes generoEstudiantes)
        {
            if (ModelState.IsValid)
            {
                db.GeneroEstudiantes.Add(generoEstudiantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(generoEstudiantes);
        }

        // GET: GeneroEstudiantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneroEstudiantes generoEstudiantes = db.GeneroEstudiantes.Find(id);
            if (generoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(generoEstudiantes);
        }

        // POST: GeneroEstudiantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] GeneroEstudiantes generoEstudiantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(generoEstudiantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generoEstudiantes);
        }

        // GET: GeneroEstudiantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneroEstudiantes generoEstudiantes = db.GeneroEstudiantes.Find(id);
            if (generoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(generoEstudiantes);
        }

        // POST: GeneroEstudiantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            GeneroEstudiantes generoEstudiantes = db.GeneroEstudiantes.Find(id);
            db.GeneroEstudiantes.Remove(generoEstudiantes);
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
