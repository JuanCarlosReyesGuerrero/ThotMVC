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
    public class NucleosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Nucleos
        //public ActionResult Index()
        //{
        //    var nucleos = db.Nucleos.Include(n => n.Departamentos).Include(n => n.Municipios);
        //    return View(nucleos.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.DepartamentosSortParm = sortOrder == "Departamentos" ? "departamentos_desc" : "Departamentos";
            ViewBag.MunicipiosSortParm = sortOrder == "Municipios" ? "municipios_desc" : "Municipios";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var nucleos = from s in db.Nucleos.Include(n => n.Departamentos).Include(n => n.Municipios)
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                nucleos = nucleos.Where(s => s.Nombre.Contains(searchString)
                                       || s.Departamentos.Nombre.Contains(searchString)
                                       || s.Municipios.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    nucleos = nucleos.OrderByDescending(s => s.Nombre);
                    break;
                case "Departamentos":
                    nucleos = nucleos.OrderBy(s => s.Departamentos.Nombre);
                    break;
                case "departamentos_desc":
                    nucleos = nucleos.OrderByDescending(s => s.Departamentos.Nombre);
                    break;
                case "Municipios":
                    nucleos = nucleos.OrderBy(s => s.Municipios.Nombre);
                    break;
                case "municipios_desc":
                    nucleos = nucleos.OrderByDescending(s => s.Municipios.Nombre);
                    break;
                default:  // Name ascending 
                    nucleos = nucleos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(nucleos.ToPagedList(pageNumber, pageSize));
        }

        // GET: Nucleos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            return View(nucleos);
        }

        // GET: Nucleos/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo");
            return View();
        }

        // POST: Nucleos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Direccion,Telefono,DepartamentoId,MunicipioId,NombreDirector,TelefonoDirector,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Nucleos nucleos)
        {
            if (ModelState.IsValid)
            {
                db.Nucleos.Add(nucleos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // GET: Nucleos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // POST: Nucleos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Direccion,Telefono,DepartamentoId,MunicipioId,NombreDirector,TelefonoDirector,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Nucleos nucleos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nucleos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // GET: Nucleos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            return View(nucleos);
        }

        // POST: Nucleos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Nucleos nucleos = db.Nucleos.Find(id);
            db.Nucleos.Remove(nucleos);
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
