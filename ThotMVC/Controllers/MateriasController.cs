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
    public class MateriasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Materias
        //public ActionResult Index()
        //{
        //    var materias = db.Materias.Include(m => m.Clasificaciones).Include(m => m.Grados).Include(m => m.Grupos).Include(m => m.Jornadas).Include(m => m.Profesores).Include(m => m.Sedes);
        //    return View(materias.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.YYYSortParm = sortOrder == "Clasificaciones" ? "clasificaciones_desc" : "Clasificaciones";
            ViewBag.YYYSortParm = sortOrder == "Grados" ? "grados_desc" : "Grados";
            ViewBag.YYYSortParm = sortOrder == "Grupos" ? "grupos_desc" : "Grupos";
            ViewBag.YYYSortParm = sortOrder == "Jornadas" ? "jornadas_desc" : "Jornadas";
            //profesores
            ViewBag.YYYSortParm = sortOrder == "Sedes" ? "sedes_desc" : "Sedes";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var materias = from s in db.Materias.Include(m => m.Clasificaciones).Include(m => m.Grados).Include(m => m.Grupos).Include(m => m.Jornadas).Include(m => m.Profesores).Include(m => m.Sedes)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                materias = materias.Where(s => s.Nombre.Contains(searchString)
                                       || s.Clasificaciones.Nombre.Contains(searchString)
                                       || s.Grados.Nombre.Contains(searchString)
                                       || s.Grupos.Nombre.Contains(searchString)
                                       || s.Jornadas.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    materias = materias.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    materias = materias.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    materias = materias.OrderByDescending(s => s.Codigo);
                    break;
                case "Clasificaciones":
                    materias = materias.OrderBy(s => s.Clasificaciones.Nombre);
                    break;
                case "clasificaciones_desc":
                    materias = materias.OrderByDescending(s => s.Clasificaciones.Nombre);
                    break;
                case "Grupos":
                    materias = materias.OrderBy(s => s.Grupos.Nombre);
                    break;
                case "grupos_desc":
                    materias = materias.OrderByDescending(s => s.Grupos.Nombre);
                    break;
                case "Jornadas":
                    materias = materias.OrderBy(s => s.Jornadas.Nombre);
                    break;
                case "jornadas_desc":
                    materias = materias.OrderByDescending(s => s.Jornadas.Nombre);
                    break;
                case "Grados":
                    materias = materias.OrderBy(s => s.Grados.Nombre);
                    break;
                case "grados_desc":
                    materias = materias.OrderByDescending(s => s.Grados.Nombre);
                    break;
                case "Sedes":
                    materias = materias.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    materias = materias.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    materias = materias.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(materias.ToPagedList(pageNumber, pageSize));
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
