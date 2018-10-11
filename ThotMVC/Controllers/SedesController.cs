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
    public class SedesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sedes
        public ActionResult Index()
        {
            var sedes = db.Sedes.Include(s => s.Departamentos).Include(s => s.Especialidades).Include(s => s.Municipios).Include(s => s.Zonas);
            return View(sedes.ToList());
        }

        // GET: Sedes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedes sedes = db.Sedes.Find(id);
            if (sedes == null)
            {
                return HttpNotFound();
            }
            return View(sedes);
        }

        // GET: Sedes/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.EspecialidadId = new SelectList(db.Especialidades, "Id", "Codigo");
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo");
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo");
            return View();
        }

        // POST: Sedes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,CodigoDaneNuevo,CodigoDaneAntiguo,CodigoConsecutivo,Nombre,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,Email,Novedad,JornadaCompleta,JornadaManana,JornadaTarde,JornadaNoche,JornadaFinSemana,EspecialidadId,FechaCreacion,Director,Secretaria,EscalaValoracionNacional,RangoNumerico,NumeroInicial,NumeroFinal,ValoracionLetras,Juicios,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Sedes sedes)
        {
            if (ModelState.IsValid)
            {
                db.Sedes.Add(sedes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", sedes.DepartamentoId);
            ViewBag.EspecialidadId = new SelectList(db.Especialidades, "Id", "Codigo", sedes.EspecialidadId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", sedes.MunicipioId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", sedes.ZonaId);
            return View(sedes);
        }

        // GET: Sedes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedes sedes = db.Sedes.Find(id);
            if (sedes == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", sedes.DepartamentoId);
            ViewBag.EspecialidadId = new SelectList(db.Especialidades, "Id", "Codigo", sedes.EspecialidadId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", sedes.MunicipioId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", sedes.ZonaId);
            return View(sedes);
        }

        // POST: Sedes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,CodigoDaneNuevo,CodigoDaneAntiguo,CodigoConsecutivo,Nombre,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,Email,Novedad,JornadaCompleta,JornadaManana,JornadaTarde,JornadaNoche,JornadaFinSemana,EspecialidadId,FechaCreacion,Director,Secretaria,EscalaValoracionNacional,RangoNumerico,NumeroInicial,NumeroFinal,ValoracionLetras,Juicios,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Sedes sedes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sedes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", sedes.DepartamentoId);
            ViewBag.EspecialidadId = new SelectList(db.Especialidades, "Id", "Codigo", sedes.EspecialidadId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", sedes.MunicipioId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", sedes.ZonaId);
            return View(sedes);
        }

        // GET: Sedes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedes sedes = db.Sedes.Find(id);
            if (sedes == null)
            {
                return HttpNotFound();
            }
            return View(sedes);
        }

        // POST: Sedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Sedes sedes = db.Sedes.Find(id);
            db.Sedes.Remove(sedes);
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
