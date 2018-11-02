using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
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
        //public ActionResult Index()
        //{
        //    var profesores = db.Profesores.Include(p => p.Escalafones).Include(p => p.EstadoCiviles).Include(p => p.Generos).Include(p => p.Profesiones).Include(p => p.Sedes).Include(p => p.TipoIdentificaciones);
        //    return View(profesores.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.SedesSortParm = sortOrder == "Sedes" ? "sedes_desc" : "Sedes";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var profesores = from s in db.Profesores.Include(p => p.Escalafones).Include(p => p.EstadoCiviles).Include(p => p.Generos).Include(p => p.Profesiones).Include(p => p.Sedes).Include(p => p.TipoIdentificaciones)
            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                profesores = profesores.Where(s => s.PrimerNombre.Contains(searchString)                                       
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    profesores = profesores.OrderByDescending(s => s.PrimerNombre);
                    break;
                case "Codigo":
                    profesores = profesores.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    profesores = profesores.OrderByDescending(s => s.Codigo);
                    break;               
                case "Sedes":
                    profesores = profesores.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    profesores = profesores.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    profesores = profesores.OrderBy(s => s.PrimerNombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(profesores.ToPagedList(pageNumber, pageSize));
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
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Nombre");
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCiviles, "Id", "Nombre");
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre");
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Nombre");
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre");
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Nombre");
            return View();
        }

        // POST: Profesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,TipoIdentificacionId,NumeroDocumento,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,Direccion,Telefono,ProfesionId,EscalafonId,SedeId,GeneroId,FechaNacimiento,LugarNacimiento,EstadoCivilId,NumeroHijos,FechaVinculacion,FechaRetiro,LibretaMilitar,ResolucionNombramiento,FotoPerfil,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesores profesores, HttpPostedFileBase uploadFile)
        {
            ////Dectecta el error del modelState
            //var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
            // .Select(x => new { x.Key, x.Value.Errors })
            // .ToArray();

            if (ModelState.IsValid)
            {
                //Sube las imagenes y las guarda en disco
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    var nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(uploadFile.FileName);
                    string pathArchivo = Server.MapPath("~/images/");
                    profesores.FotoPerfil = nombreArchivo;
                    uploadFile.SaveAs(Path.Combine(pathArchivo, nombreArchivo));
                }

                db.Profesores.Add(profesores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Nombre", profesores.EscalafonId);
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCiviles, "Id", "Nombre", profesores.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", profesores.GeneroId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Nombre", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Nombre", profesores.TipoIdentificacionId);
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
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Nombre", profesores.EscalafonId);
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCiviles, "Id", "Nombre", profesores.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", profesores.GeneroId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Nombre", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Nombre", profesores.TipoIdentificacionId);
            return View(profesores);
        }

        // POST: Profesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,TipoIdentificacionId,NumeroDocumento,PrimerApellido,SegundoApellido,PrimerNombre,SegundoNombre,Direccion,Telefono,ProfesionId,EscalafonId,SedeId,GeneroId,FechaNacimiento,LugarNacimiento,EstadoCivilId,NumeroHijos,FechaVinculacion,FechaRetiro,LibretaMilitar,ResolucionNombramiento,FotoPerfil,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesores profesores, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)
            {
                //Sube las imagenes y las guarda en disco
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    var nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(uploadFile.FileName);
                    string pathArchivo = Server.MapPath("~/images/");
                    profesores.FotoPerfil = nombreArchivo;
                    uploadFile.SaveAs(Path.Combine(pathArchivo, nombreArchivo));
                }

                db.Entry(profesores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EscalafonId = new SelectList(db.Escalafones, "Id", "Nombre", profesores.EscalafonId);
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCiviles, "Id", "Nombre", profesores.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", profesores.GeneroId);
            ViewBag.ProfesionId = new SelectList(db.Profesiones, "Id", "Nombre", profesores.ProfesionId);
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Nombre", profesores.SedeId);
            ViewBag.TipoIdentificacionId = new SelectList(db.TipoIdentificaciones, "Id", "Nombre", profesores.TipoIdentificacionId);
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
