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
    public class MateriasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Materias
        public ActionResult Index()
        {
            var materias = db.Materias.Include(m => m.Clasificaciones).Include(m => m.Grados).Include(m => m.Grupos).Include(m => m.Jornadas).Include(m => m.Profesores).Include(m => m.Sedes);
            return View(materias.ToList());
        }

        // GET: Materias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materias materias = db.Materias.Find(id);
            if (materias == null)
            {
                return HttpNotFound();
            }
            return View(materias);
        }

        // GET: Materias/Create
        public ActionResult Create()
        {
            ViewBag.ClasificacionId = new SelectList(db.Clasificaciones, "Id", "Nombre");
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo");
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo");
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo");
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Materias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,IntensidadHoraria,Orden,ClasificacionId,ProfesorId,GradoId,GrupoId,JornadaId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Materias materias)
        {
            if (ModelState.IsValid)
            {
                db.Materias.Add(materias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClasificacionId = new SelectList(db.Clasificaciones, "Id", "Nombre", materias.ClasificacionId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", materias.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", materias.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", materias.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", materias.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", materias.SedeId);
            return View(materias);
        }

        // GET: Materias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materias materias = db.Materias.Find(id);
            if (materias == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClasificacionId = new SelectList(db.Clasificaciones, "Id", "Nombre", materias.ClasificacionId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", materias.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", materias.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", materias.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", materias.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", materias.SedeId);
            return View(materias);
        }

        // POST: Materias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,IntensidadHoraria,Orden,ClasificacionId,ProfesorId,GradoId,GrupoId,JornadaId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Materias materias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClasificacionId = new SelectList(db.Clasificaciones, "Id", "Nombre", materias.ClasificacionId);
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", materias.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", materias.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", materias.JornadaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "Id", "NumeroDocumento", materias.ProfesorId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", materias.SedeId);
            return View(materias);
        }

        // GET: Materias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materias materias = db.Materias.Find(id);
            if (materias == null)
            {
                return HttpNotFound();
            }
            return View(materias);
        }

        // POST: Materias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Materias materias = db.Materias.Find(id);
            db.Materias.Remove(materias);
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
