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
    public class MunicipiosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Municipios
        //public ActionResult Index()
        //{
        //    var municipios = db.Municipios.Include(m => m.Departamentos);
        //    return View(municipios.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.DepartamentosSortParm = sortOrder == "Departamentos" ? "departamentos_desc" : "Departamentos";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var municipios = from s in db.Municipios.Include(m => m.Departamentos)
                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                municipios = municipios.Where(s => s.Nombre.Contains(searchString)
                                       || s.Departamentos.Nombre.Contains(searchString)
                                       || s.CodigoUnificado.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    municipios = municipios.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    municipios = municipios.OrderBy(s => s.CodigoUnificado);
                    break;
                case "codigo_desc":
                    municipios = municipios.OrderByDescending(s => s.CodigoUnificado);
                    break;
                case "Departamentos":
                    municipios = municipios.OrderBy(s => s.Departamentos.Nombre);
                    break;
                case "departamentos_desc":
                    municipios = municipios.OrderByDescending(s => s.Departamentos.Nombre);
                    break;
                default:  // Name ascending 
                    municipios = municipios.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(municipios.ToPagedList(pageNumber, pageSize));
        }

        // GET: Municipios/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipios municipios = db.Municipios.Find(id);
            if (municipios == null)
            {
                return HttpNotFound();
            }
            return View(municipios);
        }

        // GET: Municipios/Create
        public ActionResult Create()
        {
            //ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre");
            return View();
        }

        // POST: Municipios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,CodigoUnificado,DepartamentoId,DepartamentoCodigo,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Municipios municipios)
        {
            if (ModelState.IsValid)
            {
                db.Municipios.Add(municipios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", municipios.DepartamentoId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", municipios.DepartamentoId);
            return View(municipios);
        }

        // GET: Municipios/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipios municipios = db.Municipios.Find(id);
            if (municipios == null)
            {
                return HttpNotFound();
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", municipios.DepartamentoId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", municipios.DepartamentoId);
            return View(municipios);
        }

        // POST: Municipios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,CodigoUnificado,DepartamentoId,DepartamentoCodigo,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Municipios municipios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(municipios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", municipios.DepartamentoId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", municipios.DepartamentoId);
            return View(municipios);
        }

        // GET: Municipios/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Municipios municipios = db.Municipios.Find(id);
            if (municipios == null)
            {
                return HttpNotFound();
            }
            return View(municipios);
        }

        // POST: Municipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Municipios municipios = db.Municipios.Find(id);
            db.Municipios.Remove(municipios);
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
