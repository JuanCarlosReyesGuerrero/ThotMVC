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
    public class EstadoEstudiantesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EstadoEstudiantes
        public ActionResult Index()
        {
            return View(db.EstadoEstudiantes.ToList());
        }

        // GET: EstadoEstudiantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEstudiantes estadoEstudiantes = db.EstadoEstudiantes.Find(id);
            if (estadoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(estadoEstudiantes);
        }

        // GET: EstadoEstudiantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoEstudiantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EstadoEstudiantes estadoEstudiantes)
        {
            if (ModelState.IsValid)
            {
                db.EstadoEstudiantes.Add(estadoEstudiantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoEstudiantes);
        }

        // GET: EstadoEstudiantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEstudiantes estadoEstudiantes = db.EstadoEstudiantes.Find(id);
            if (estadoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(estadoEstudiantes);
        }

        // POST: EstadoEstudiantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EstadoEstudiantes estadoEstudiantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoEstudiantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoEstudiantes);
        }

        // GET: EstadoEstudiantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEstudiantes estadoEstudiantes = db.EstadoEstudiantes.Find(id);
            if (estadoEstudiantes == null)
            {
                return HttpNotFound();
            }
            return View(estadoEstudiantes);
        }

        // POST: EstadoEstudiantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EstadoEstudiantes estadoEstudiantes = db.EstadoEstudiantes.Find(id);
            db.EstadoEstudiantes.Remove(estadoEstudiantes);
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
