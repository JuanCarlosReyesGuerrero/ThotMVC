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
    public class MatriculasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Matriculas
        public ActionResult Index()
        {
            var matriculas = db.Matriculas.Include(m => m.EstadoEstudiantes).Include(m => m.Estudiantes).Include(m => m.Grados).Include(m => m.Grupos).Include(m => m.Jornadas).Include(m => m.Sedes).Include(m => m.TipoCaracteres);
            return View(matriculas.ToList());
        }

        // GET: Matriculas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matriculas matriculas = db.Matriculas.Find(id);
            if (matriculas == null)
            {
                return HttpNotFound();
            }
            return View(matriculas);
        }

        // GET: Matriculas/Create
        public ActionResult Create()
        {
            ViewBag.EstadoMatricula = new SelectList(db.EstadoEstudiantes, "Id", "Nombre");
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "Id", "CodigoMEN");
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Nombre");
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Nombre");
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Nombre");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre");
            ViewBag.TipoCaracterId = new SelectList(db.TipoCaracteres, "Id", "Nombre");
            return View();
        }

        // POST: Matriculas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EstudianteId,EdadMatricula,NumeroMatricula,Numerofolio,FechaMatricula,AnioMatricula,GradoId,GrupoId,JornadaId,EstadoMatricula,Repitente,TipoCaracterId,SedeId,Observaciones")] Matriculas matriculas)
        {
            if (ModelState.IsValid)
            {
                db.Matriculas.Add(matriculas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstadoMatricula = new SelectList(db.EstadoEstudiantes, "Id", "Nombre", matriculas.EstadoMatricula);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "Id", "CodigoMEN", matriculas.EstudianteId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Nombre", matriculas.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Nombre", matriculas.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Nombre", matriculas.JornadaId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre", matriculas.SedeId);
            ViewBag.TipoCaracterId = new SelectList(db.TipoCaracteres, "Id", "Nombre", matriculas.TipoCaracterId);
            return View(matriculas);
        }

        // GET: Matriculas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matriculas matriculas = db.Matriculas.Find(id);
            if (matriculas == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstadoMatricula = new SelectList(db.EstadoEstudiantes, "Id", "Nombre", matriculas.EstadoMatricula);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "Id", "CodigoMEN", matriculas.EstudianteId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Nombre", matriculas.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Nombre", matriculas.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Nombre", matriculas.JornadaId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", matriculas.SedeId);
            ViewBag.TipoCaracterId = new SelectList(db.TipoCaracteres, "Id", "Nombre", matriculas.TipoCaracterId);
            return View(matriculas);
        }

        // POST: Matriculas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EstudianteId,EdadMatricula,NumeroMatricula,Numerofolio,FechaMatricula,AnioMatricula,GradoId,GrupoId,JornadaId,EstadoMatricula,Repitente,TipoCaracterId,SedeId,Observaciones")] Matriculas matriculas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matriculas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstadoMatricula = new SelectList(db.EstadoEstudiantes, "Id", "Nombre", matriculas.EstadoMatricula);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "Id", "CodigoMEN", matriculas.EstudianteId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Nombre", matriculas.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Nombre", matriculas.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Nombre", matriculas.JornadaId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", matriculas.SedeId);
            ViewBag.TipoCaracterId = new SelectList(db.TipoCaracteres, "Id", "Nombre", matriculas.TipoCaracterId);
            return View(matriculas);
        }

        // GET: Matriculas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matriculas matriculas = db.Matriculas.Find(id);
            if (matriculas == null)
            {
                return HttpNotFound();
            }
            return View(matriculas);
        }

        // POST: Matriculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Matriculas matriculas = db.Matriculas.Find(id);
            db.Matriculas.Remove(matriculas);
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
