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
    public class EquivalenciasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Equivalencias
        //public ActionResult Index()
        //{
        //    var equivalencias = db.Equivalencias.Include(e => e.Sedes).Include(e => e.ValoracionLetras);
        //    return View(equivalencias.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
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

            var equivalencias = from s in db.Equivalencias.Include(m => m.Sedes)
                                select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                equivalencias = equivalencias.Where(s => s.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    equivalencias = equivalencias.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    equivalencias = equivalencias.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    equivalencias = equivalencias.OrderByDescending(s => s.Codigo);
                    break;
                case "Sedes":
                    equivalencias = equivalencias.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    equivalencias = equivalencias.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    equivalencias = equivalencias.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(equivalencias.ToPagedList(pageNumber, pageSize));
        }

        // GET: Equivalencias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            return View(equivalencias);
        }

        // GET: Equivalencias/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo");
            return View();
        }

        // POST: Equivalencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,EquivalenciaRangoNumerico,ValoracionLetraId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Equivalencias equivalencias)
        {
            if (ModelState.IsValid)
            {
                db.Equivalencias.Add(equivalencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // GET: Equivalencias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // POST: Equivalencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,EquivalenciaRangoNumerico,ValoracionLetraId,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Equivalencias equivalencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equivalencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", equivalencias.SedeId);
            ViewBag.ValoracionLetraId = new SelectList(db.ValoracionLetras, "Id", "Codigo", equivalencias.ValoracionLetraId);
            return View(equivalencias);
        }

        // GET: Equivalencias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            if (equivalencias == null)
            {
                return HttpNotFound();
            }
            return View(equivalencias);
        }

        // POST: Equivalencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Equivalencias equivalencias = db.Equivalencias.Find(id);
            db.Equivalencias.Remove(equivalencias);
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
