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
    public class EstudiantesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Estudiantes
        public ActionResult Index()
        {
            var estudiantes = db.Estudiantes.Include(e => e.Ars).Include(e => e.CapacidadExcepcionales).Include(e => e.Eps).Include(e => e.Estratos).Include(e => e.Etnias).Include(e => e.FactorRhs).Include(e => e.Generos).Include(e => e.Grupos).Include(e => e.Instituciones).Include(e => e.Parentescos).Include(e => e.PoblacionVictimaConflictos).Include(e => e.Resguardos).Include(e => e.Sedes).Include(e => e.Sisbenes).Include(e => e.TipoDiscapacidades).Include(e => e.TipoIdentificaciones);
            return View(estudiantes.ToList());
        }

        // GET: Estudiantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiantes estudiantes = db.Estudiantes.Find(id);
            if (estudiantes == null)
            {
                return HttpNotFound();
            }
            return View(estudiantes);
        }

        // GET: Estudiantes/Create
        public ActionResult Create()
        {
            ViewBag.ArsId = new SelectList(db.Ars, "Id", "Codigo");
            ViewBag.CapacidadExcepcionalId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo");
            ViewBag.EpsId = new SelectList(db.Eps, "Id", "Codigo");
            ViewBag.EstratoId = new SelectList(db.Estratos, "Id", "Codigo");
            ViewBag.EtniaId = new SelectList(db.Etnias, "Id", "Codigo");
            ViewBag.FactorRhId = new SelectList(db.FactorRhs, "Id", "Codigo");
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo");
            ViewBag.GrupoUsuarioId = new SelectList(db.Grupos, "Id", "Codigo");
            ViewBag.InstitucionId = new SelectList(db.Instituciones, "Id", "CodigoDane");
            ViewBag.ParentescoAcudienteId = new SelectList(db.Parentescos, "Id", "Codigo");
            ViewBag.PoblacionVictimaId = new SelectList(db.PoblacionVictimaConflictos, "Id", "Codigo");
            ViewBag.ResguardoId = new SelectList(db.Resguardos, "Id", "Codigo");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            ViewBag.SisbenId = new SelectList(db.Sisbenes, "Id", "Codigo");
            ViewBag.DiscapacidadId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo");
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo");
            return View();
        }

        // POST: Estudiantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,CodigoMEN,TipoIdentificacionId,NumeroDocumento,DepartamentoExpedicionId,MunicipioExpedicionId,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,FechaNacimiento,DepartamentoNacimientoId,MunicipioNacimientoId,GeneroId,FactorRhId,Email,Fotografia,Direccion,DepartamentoResidenciaId,MunicipioResidenciaId,ZonaResidenciaId,Localidad,Barrio,EstratoId,Telefono,Celular,SisbenId,NumeroSisben,EpsId,ArsId,PoblacionVictimaId,DepartamentoExpulsorId,MunicipioExpulsorId,FechaExpulsion,CertificadoExpulsion,FechaCertificadoExpulsion,DiscapacidadId,CapacidadExcepcionalId,EtniaId,ResguardoId,ProvieneSectorPrivado,ProvieneOtroMunicipio,InstitucionBienestar,TipoIdentificacionMadreId,NumeroDocumentoMadre,DepartamentoExpedicionMadreId,MunicipioExpedicionMadreId,EstudiantePrimerApellidoMadre,SegundoApellidoMadre,PrimerNombreMadre,EstudianteSegundoNombreMadre,EmailMadre,DireccionMadre,DepartamentoResidenciaMadreId,MunicipioResidenciaMadreId,ZonaResidenciaMadreId,BarrioMadre,LocalidadMadre,TelefonoMadre,CelularMadre,OcupacionMadre,EmpresaMadre,TelefonoEmpresaMadre,TipoIdentificacionPadreId,NumeroDocumentoPadre,DepartamentoExpedicionPadreId,MunicipioExpedicionPadreId,PrimerApellidoPadre,SegundoApellidoPadre,PrimerNombrePadre,SegundoNombrePadre,EmailPadre,DireccionPadre,DepartamentoResidenciaPadreId,MunicipioResidenciaPadreId,ZonaResicenciaPadreId,BarrioPadre,Localidadpadre,TelefonoPadre,CelularPadre,OcupacionPadre,EmpresaPadre,TelefonoEmpresaPadre,TipoIdentificacionAcudienteId,NumeroDocumentoAcudiente,DepartamentoExpedicionAcudienteId,MunicipioExpedicionAcudiente,PrimerApellidoAcudiente,SegundoApellidoAcudiente,PrimerNombreAcudiente,SegundoNombreAcudiente,EmailAcudiente,DireccionAcudiente,DepartamentoResidenciaAcudienteId,MunicipioResidenciaAcudienteId,ZonaResidenciaAcudienteId,BarrioAcudiente,LocalidadAcudiente,TelefonoAcudiente,CelularAcudiente,OcupacionAcudiente,EmpresaAcudiente,TelefonoEmpresaAcudiente,GeneroAcudienteId,ParentescoAcudienteId,ColegioUltimoCurso,DireccionColegioUltimoCurso,TelefonoColegioUltimoCurso,UltimoGrado,Anio,MotivoRetiroUltimo,Observaciones,UsuarioEstudiante,ClaveAcceso,GrupoUsuarioId,SedeId,InstitucionId,SeleccioneMadre,SeleccionePadre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Estudiantes estudiantes)
        {
            if (ModelState.IsValid)
            {
                db.Estudiantes.Add(estudiantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArsId = new SelectList(db.Ars, "Id", "Codigo", estudiantes.ArsId);
            ViewBag.CapacidadExcepcionalId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", estudiantes.CapacidadExcepcionalId);
            ViewBag.EpsId = new SelectList(db.Eps, "Id", "Codigo", estudiantes.EpsId);
            ViewBag.EstratoId = new SelectList(db.Estratos, "Id", "Codigo", estudiantes.EstratoId);
            ViewBag.EtniaId = new SelectList(db.Etnias, "Id", "Codigo", estudiantes.EtniaId);
            ViewBag.FactorRhId = new SelectList(db.FactorRhs, "Id", "Codigo", estudiantes.FactorRhId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", estudiantes.GeneroId);
            ViewBag.GrupoUsuarioId = new SelectList(db.Grupos, "Id", "Codigo", estudiantes.GrupoUsuarioId);
            ViewBag.InstitucionId = new SelectList(db.Instituciones, "Id", "CodigoDane", estudiantes.InstitucionId);
            ViewBag.ParentescoAcudienteId = new SelectList(db.Parentescos, "Id", "Codigo", estudiantes.ParentescoAcudienteId);
            ViewBag.PoblacionVictimaId = new SelectList(db.PoblacionVictimaConflictos, "Id", "Codigo", estudiantes.PoblacionVictimaId);
            ViewBag.ResguardoId = new SelectList(db.Resguardos, "Id", "Codigo", estudiantes.ResguardoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", estudiantes.SedeId);
            ViewBag.SisbenId = new SelectList(db.Sisbenes, "Id", "Codigo", estudiantes.SisbenId);
            ViewBag.DiscapacidadId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", estudiantes.DiscapacidadId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", estudiantes.TipoIdentificacionId);
            return View(estudiantes);
        }

        // GET: Estudiantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiantes estudiantes = db.Estudiantes.Find(id);
            if (estudiantes == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArsId = new SelectList(db.Ars, "Id", "Codigo", estudiantes.ArsId);
            ViewBag.CapacidadExcepcionalId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", estudiantes.CapacidadExcepcionalId);
            ViewBag.EpsId = new SelectList(db.Eps, "Id", "Codigo", estudiantes.EpsId);
            ViewBag.EstratoId = new SelectList(db.Estratos, "Id", "Codigo", estudiantes.EstratoId);
            ViewBag.EtniaId = new SelectList(db.Etnias, "Id", "Codigo", estudiantes.EtniaId);
            ViewBag.FactorRhId = new SelectList(db.FactorRhs, "Id", "Codigo", estudiantes.FactorRhId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", estudiantes.GeneroId);
            ViewBag.GrupoUsuarioId = new SelectList(db.Grupos, "Id", "Codigo", estudiantes.GrupoUsuarioId);
            ViewBag.InstitucionId = new SelectList(db.Instituciones, "Id", "CodigoDane", estudiantes.InstitucionId);
            ViewBag.ParentescoAcudienteId = new SelectList(db.Parentescos, "Id", "Codigo", estudiantes.ParentescoAcudienteId);
            ViewBag.PoblacionVictimaId = new SelectList(db.PoblacionVictimaConflictos, "Id", "Codigo", estudiantes.PoblacionVictimaId);
            ViewBag.ResguardoId = new SelectList(db.Resguardos, "Id", "Codigo", estudiantes.ResguardoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", estudiantes.SedeId);
            ViewBag.SisbenId = new SelectList(db.Sisbenes, "Id", "Codigo", estudiantes.SisbenId);
            ViewBag.DiscapacidadId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", estudiantes.DiscapacidadId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", estudiantes.TipoIdentificacionId);
            return View(estudiantes);
        }

        // POST: Estudiantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,CodigoMEN,TipoIdentificacionId,NumeroDocumento,DepartamentoExpedicionId,MunicipioExpedicionId,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,FechaNacimiento,DepartamentoNacimientoId,MunicipioNacimientoId,GeneroId,FactorRhId,Email,Fotografia,Direccion,DepartamentoResidenciaId,MunicipioResidenciaId,ZonaResidenciaId,Localidad,Barrio,EstratoId,Telefono,Celular,SisbenId,NumeroSisben,EpsId,ArsId,PoblacionVictimaId,DepartamentoExpulsorId,MunicipioExpulsorId,FechaExpulsion,CertificadoExpulsion,FechaCertificadoExpulsion,DiscapacidadId,CapacidadExcepcionalId,EtniaId,ResguardoId,ProvieneSectorPrivado,ProvieneOtroMunicipio,InstitucionBienestar,TipoIdentificacionMadreId,NumeroDocumentoMadre,DepartamentoExpedicionMadreId,MunicipioExpedicionMadreId,EstudiantePrimerApellidoMadre,SegundoApellidoMadre,PrimerNombreMadre,EstudianteSegundoNombreMadre,EmailMadre,DireccionMadre,DepartamentoResidenciaMadreId,MunicipioResidenciaMadreId,ZonaResidenciaMadreId,BarrioMadre,LocalidadMadre,TelefonoMadre,CelularMadre,OcupacionMadre,EmpresaMadre,TelefonoEmpresaMadre,TipoIdentificacionPadreId,NumeroDocumentoPadre,DepartamentoExpedicionPadreId,MunicipioExpedicionPadreId,PrimerApellidoPadre,SegundoApellidoPadre,PrimerNombrePadre,SegundoNombrePadre,EmailPadre,DireccionPadre,DepartamentoResidenciaPadreId,MunicipioResidenciaPadreId,ZonaResicenciaPadreId,BarrioPadre,Localidadpadre,TelefonoPadre,CelularPadre,OcupacionPadre,EmpresaPadre,TelefonoEmpresaPadre,TipoIdentificacionAcudienteId,NumeroDocumentoAcudiente,DepartamentoExpedicionAcudienteId,MunicipioExpedicionAcudiente,PrimerApellidoAcudiente,SegundoApellidoAcudiente,PrimerNombreAcudiente,SegundoNombreAcudiente,EmailAcudiente,DireccionAcudiente,DepartamentoResidenciaAcudienteId,MunicipioResidenciaAcudienteId,ZonaResidenciaAcudienteId,BarrioAcudiente,LocalidadAcudiente,TelefonoAcudiente,CelularAcudiente,OcupacionAcudiente,EmpresaAcudiente,TelefonoEmpresaAcudiente,GeneroAcudienteId,ParentescoAcudienteId,ColegioUltimoCurso,DireccionColegioUltimoCurso,TelefonoColegioUltimoCurso,UltimoGrado,Anio,MotivoRetiroUltimo,Observaciones,UsuarioEstudiante,ClaveAcceso,GrupoUsuarioId,SedeId,InstitucionId,SeleccioneMadre,SeleccionePadre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Estudiantes estudiantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudiantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArsId = new SelectList(db.Ars, "Id", "Codigo", estudiantes.ArsId);
            ViewBag.CapacidadExcepcionalId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", estudiantes.CapacidadExcepcionalId);
            ViewBag.EpsId = new SelectList(db.Eps, "Id", "Codigo", estudiantes.EpsId);
            ViewBag.EstratoId = new SelectList(db.Estratos, "Id", "Codigo", estudiantes.EstratoId);
            ViewBag.EtniaId = new SelectList(db.Etnias, "Id", "Codigo", estudiantes.EtniaId);
            ViewBag.FactorRhId = new SelectList(db.FactorRhs, "Id", "Codigo", estudiantes.FactorRhId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", estudiantes.GeneroId);
            ViewBag.GrupoUsuarioId = new SelectList(db.Grupos, "Id", "Codigo", estudiantes.GrupoUsuarioId);
            ViewBag.InstitucionId = new SelectList(db.Instituciones, "Id", "CodigoDane", estudiantes.InstitucionId);
            ViewBag.ParentescoAcudienteId = new SelectList(db.Parentescos, "Id", "Codigo", estudiantes.ParentescoAcudienteId);
            ViewBag.PoblacionVictimaId = new SelectList(db.PoblacionVictimaConflictos, "Id", "Codigo", estudiantes.PoblacionVictimaId);
            ViewBag.ResguardoId = new SelectList(db.Resguardos, "Id", "Codigo", estudiantes.ResguardoId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", estudiantes.SedeId);
            ViewBag.SisbenId = new SelectList(db.Sisbenes, "Id", "Codigo", estudiantes.SisbenId);
            ViewBag.DiscapacidadId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", estudiantes.DiscapacidadId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Codigo", estudiantes.TipoIdentificacionId);
            return View(estudiantes);
        }

        // GET: Estudiantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiantes estudiantes = db.Estudiantes.Find(id);
            if (estudiantes == null)
            {
                return HttpNotFound();
            }
            return View(estudiantes);
        }

        // POST: Estudiantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Estudiantes estudiantes = db.Estudiantes.Find(id);
            db.Estudiantes.Remove(estudiantes);
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
