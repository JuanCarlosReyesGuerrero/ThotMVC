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
    public class PeriodosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Periodos
        //public ActionResult Index()
        //{
        //    var periodos = db.Periodos.Include(p => p.Sedes);
        //    return View(periodos.ToList());
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

            var periodos = from s in db.Periodos.Include(m => m.Sedes)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                periodos = periodos.Where(s => s.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    periodos = periodos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    periodos = periodos.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    periodos = periodos.OrderByDescending(s => s.Codigo);
                    break;
                case "Sedes":
                    periodos = periodos.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    periodos = periodos.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    periodos = periodos.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(periodos.ToPagedList(pageNumber, pageSize));
        }

        // GET: Periodos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodos periodos = db.Periodos.Find(id);
            if (periodos == null)
            {
                return HttpNotFound();
            }
            return View(periodos);
        }

        // GET: Periodos/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Periodos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Periodos periodos)
        {
            if (ModelState.IsValid)
            {
                db.Periodos.Add(periodos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", periodos.SedeId);
            return View(periodos);
        }

        // GET: Periodos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodos periodos = db.Periodos.Find(id);
            if (periodos == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", periodos.SedeId);
            return View(periodos);
        }

        // POST: Periodos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Periodos periodos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(periodos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", periodos.SedeId);
            return View(periodos);
        }

        // GET: Periodos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodos periodos = db.Periodos.Find(id);
            if (periodos == null)
            {
                return HttpNotFound();
            }
            return View(periodos);
        }

        // POST: Periodos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Periodos periodos = db.Periodos.Find(id);
            db.Periodos.Remove(periodos);
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
