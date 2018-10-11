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
    public class ProfesoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Profesores
        public ActionResult Index()
        {
            var profesores = db.Profesores.Include(p => p.Escalafones).Include(p => p.Profesiones).Include(p => p.Sedes).Include(p => p.TipoIdentificaciones);
            return View(profesores.ToList());
        }

        // GET: Profesores/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // GET: Profesores/Create
        public ActionResult Create()
        {
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Codigo");
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Codigo");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo");
            return View();
        }

        // POST: Profesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,TipoIdentificacionId,NumeroDocumento,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,Direccion,Telefono,ProfesionId,EscalafonId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.Profesores.Add(profesores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Codigo", profesores.EscalafonId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Codigo", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", profesores.TipoIdentificacionId);
            return View(profesores);
        }

        // GET: Profesores/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Codigo", profesores.EscalafonId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Codigo", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", profesores.TipoIdentificacionId);
            return View(profesores);
        }

        // POST: Profesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,TipoIdentificacionId,NumeroDocumento,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,Direccion,Telefono,ProfesionId,EscalafonId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Codigo", profesores.EscalafonId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Codigo", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", profesores.TipoIdentificacionId);
            return View(profesores);
        }

        // GET: Profesores/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // POST: Profesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Profesores profesores = db.Profesores.Find(id);
            db.Profesores.Remove(profesores);
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
