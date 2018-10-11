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
    public class JuiciosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Juicios
        public ActionResult Index()
        {
            var juicios = db.Juicios.Include(j => j.Grados).Include(j => j.Grupos).Include(j => j.Jornadas).Include(j => j.Materias).Include(j => j.Periodos).Include(j => j.Sedes);
            return View(juicios.ToList());
        }

        // GET: Juicios/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juicios juicios = db.Juicios.Find(id);
            if (juicios == null)
            {
                return HttpNotFound();
            }
            return View(juicios);
        }

        // GET: Juicios/Create
        public ActionResult Create()
        {
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo");
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo");
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo");
            ViewBag.MateriaId = new SelectList(db.Materias, "Id", "Nombre");
            ViewBag.PeriodoId = new SelectList(db.Periodos, "Id", "Nombre");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Juicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,GradoId,GrupoId,JornadaId,MateriaId,PeriodoId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Juicios juicios)
        {
            if (ModelState.IsValid)
            {
                db.Juicios.Add(juicios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", juicios.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", juicios.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", juicios.JornadaId);
            ViewBag.MateriaId = new SelectList(db.Materias, "Id", "Nombre", juicios.MateriaId);
            ViewBag.PeriodoId = new SelectList(db.Periodos, "Id", "Nombre", juicios.PeriodoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", juicios.SedeId);
            return View(juicios);
        }

        // GET: Juicios/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juicios juicios = db.Juicios.Find(id);
            if (juicios == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", juicios.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", juicios.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", juicios.JornadaId);
            ViewBag.MateriaId = new SelectList(db.Materias, "Id", "Nombre", juicios.MateriaId);
            ViewBag.PeriodoId = new SelectList(db.Periodos, "Id", "Nombre", juicios.PeriodoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", juicios.SedeId);
            return View(juicios);
        }

        // POST: Juicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,GradoId,GrupoId,JornadaId,MateriaId,PeriodoId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Juicios juicios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(juicios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradoId = new SelectList(db.Grados, "Id", "Codigo", juicios.GradoId);
            ViewBag.GrupoId = new SelectList(db.Grupos, "Id", "Codigo", juicios.GrupoId);
            ViewBag.JornadaId = new SelectList(db.Jornadas, "Id", "Codigo", juicios.JornadaId);
            ViewBag.MateriaId = new SelectList(db.Materias, "Id", "Nombre", juicios.MateriaId);
            ViewBag.PeriodoId = new SelectList(db.Periodos, "Id", "Nombre", juicios.PeriodoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", juicios.SedeId);
            return View(juicios);
        }

        // GET: Juicios/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juicios juicios = db.Juicios.Find(id);
            if (juicios == null)
            {
                return HttpNotFound();
            }
            return View(juicios);
        }

        // POST: Juicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Juicios juicios = db.Juicios.Find(id);
            db.Juicios.Remove(juicios);
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
