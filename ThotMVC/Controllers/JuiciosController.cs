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
    public class JuiciosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Juicios
        //public ActionResult Index()
        //{
        //    var juicios = db.Juicios.Include(j => j.Grados).Include(j => j.Grupos).Include(j => j.Jornadas).Include(j => j.Materias).Include(j => j.Periodos).Include(j => j.Sedes);
        //    return View(juicios.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.YYYSortParm = sortOrder == "Grados" ? "grados_desc" : "Grados";
            ViewBag.YYYSortParm = sortOrder == "Grupos" ? "grupos_desc" : "Grupos";
            ViewBag.YYYSortParm = sortOrder == "Jornadas" ? "jornadas_desc" : "Jornadas";
            ViewBag.YYYSortParm = sortOrder == "Materias" ? "materias_desc" : "Materias";
            ViewBag.YYYSortParm = sortOrder == "Periodos" ? "periodos_desc" : "Periodos";
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

            var juicios = from s in db.Juicios.Include(j => j.Grados).Include(j => j.Grupos).Include(j => j.Jornadas).Include(j => j.Materias).Include(j => j.Periodos).Include(j => j.Sedes)
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                juicios = juicios.Where(s => s.Nombre.Contains(searchString)
                                       || s.Grados.Nombre.Contains(searchString)
                                       || s.Grupos.Nombre.Contains(searchString)
                                       || s.Jornadas.Nombre.Contains(searchString)
                                       || s.Materias.Nombre.Contains(searchString)
                                       || s.Periodos.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    juicios = juicios.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    juicios = juicios.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    juicios = juicios.OrderByDescending(s => s.Codigo);
                    break;
                case "Grados":
                    juicios = juicios.OrderBy(s => s.Grados.Nombre);
                    break;
                case "grados_desc":
                    juicios = juicios.OrderByDescending(s => s.Grados.Nombre);
                    break;
                case "Grupos":
                    juicios = juicios.OrderBy(s => s.Grupos.Nombre);
                    break;
                case "grupos_desc":
                    juicios = juicios.OrderByDescending(s => s.Grupos.Nombre);
                    break;
                case "Jornadas":
                    juicios = juicios.OrderBy(s => s.Jornadas.Nombre);
                    break;
                case "jornadas_desc":
                    juicios = juicios.OrderByDescending(s => s.Jornadas.Nombre);
                    break;
                case "Materias":
                    juicios = juicios.OrderBy(s => s.Materias.Nombre);
                    break;
                case "materias_desc":
                    juicios = juicios.OrderByDescending(s => s.Materias.Nombre);
                    break;
                case "Periodos":
                    juicios = juicios.OrderBy(s => s.Periodos.Nombre);
                    break;
                case "periodos_desc":
                    juicios = juicios.OrderByDescending(s => s.Periodos.Nombre);
                    break;
                case "Sedes":
                    juicios = juicios.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    juicios = juicios.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    juicios = juicios.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(juicios.ToPagedList(pageNumber, pageSize));
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
