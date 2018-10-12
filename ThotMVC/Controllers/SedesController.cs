using PagedList;
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
        //public ActionResult Index()
        //{
        //    var sedes = db.Sedes.Include(s => s.Departamentos).Include(s => s.Especialidades).Include(s => s.Municipios).Include(s => s.Zonas);
        //    return View(sedes.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.YYYSortParm = sortOrder == "Departamentos" ? "departamentos_desc" : "Departamentos";
            ViewBag.YYYSortParm = sortOrder == "Especialidades" ? "especialidades_desc" : "Especialidades";
            ViewBag.YYYSortParm = sortOrder == "Municipios" ? "municipios_desc" : "Municipios";
            ViewBag.YYYSortParm = sortOrder == "Zonas" ? "zonas_desc" : "Zonas";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var sedes = from s in db.Sedes.Include(s => s.Departamentos).Include(s => s.Especialidades).Include(s => s.Municipios).Include(s => s.Zonas)
                        select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                sedes = sedes.Where(s => s.Nombre.Contains(searchString)
                                       || s.Departamentos.Nombre.Contains(searchString)
                                       || s.Especialidades.Nombre.Contains(searchString)
                                       || s.Municipios.Nombre.Contains(searchString)
                                       || s.Zonas.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    sedes = sedes.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    sedes = sedes.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    sedes = sedes.OrderByDescending(s => s.Codigo);
                    break;
                case "Departamentos":
                    sedes = sedes.OrderBy(s => s.Departamentos.Nombre);
                    break;
                case "departamentos_desc":
                    sedes = sedes.OrderByDescending(s => s.Departamentos.Nombre);
                    break;
                case "Especialidades":
                    sedes = sedes.OrderBy(s => s.Especialidades.Nombre);
                    break;
                case "especialidades_desc":
                    sedes = sedes.OrderByDescending(s => s.Especialidades.Nombre);
                    break;
                case "Municipios":
                    sedes = sedes.OrderBy(s => s.Municipios.Nombre);
                    break;
                case "municipios_desc":
                    sedes = sedes.OrderByDescending(s => s.Municipios.Nombre);
                    break;
                case "Zonas":
                    sedes = sedes.OrderBy(s => s.Zonas.Nombre);
                    break;
                case "zonas_desc":
                    sedes = sedes.OrderByDescending(s => s.Zonas.Nombre);
                    break;
                default:  // Name ascending 
                    sedes = sedes.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(sedes.ToPagedList(pageNumber, pageSize));
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
