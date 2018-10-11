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
    public class CursosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cursos
        public ActionResult Index()
        {
            var cursos = db.Cursos.Include(c => c.Grados).Include(c => c.Grupos).Include(c => c.Jornadas).Include(c => c.Profesores).Include(c => c.Sedes);
            return View(cursos.ToList());
        }

        // GET: Cursos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            return View(cursos);
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo");
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo");
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo");
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,GradoId,GrupoId,JornadaId,ProfesorId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Cursos cursos)
        {
            if (ModelState.IsValid)
            {
                db.Cursos.Add(cursos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", cursos.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", cursos.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", cursos.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", cursos.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", cursos.SedeId);
            return View(cursos);
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", cursos.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", cursos.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", cursos.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", cursos.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", cursos.SedeId);
            return View(cursos);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,GradoId,GrupoId,JornadaId,ProfesorId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Cursos cursos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cursos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", cursos.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", cursos.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", cursos.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", cursos.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", cursos.SedeId);
            return View(cursos);
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            return View(cursos);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Cursos cursos = db.Cursos.Find(id);
            db.Cursos.Remove(cursos);
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
