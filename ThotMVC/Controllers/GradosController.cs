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
    public class GradosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Grados
        //public ActionResult Index()
        //{
        //    var grados = db.Grados.Include(g => g.Sedes);
        //    return View(grados.ToList());
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

            var grados = from s in db.Grados.Include(m => m.SedeId)
                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                grados = grados.Where(s => s.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    grados = grados.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    grados = grados.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    grados = grados.OrderByDescending(s => s.Codigo);
                    break;
                case "Sedes":
                    grados = grados.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    grados = grados.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    grados = grados.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(grados.ToPagedList(pageNumber, pageSize));
        }

        // GET: Grados/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grados grados = db.Grados.Find(id);
            if (grados == null)
            {
                return HttpNotFound();
            }
            return View(grados);
        }

        // GET: Grados/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Grados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Grados grados)
        {
            if (ModelState.IsValid)
            {
                db.Grados.Add(grados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", grados.SedeId);
            return View(grados);
        }

        // GET: Grados/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grados grados = db.Grados.Find(id);
            if (grados == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", grados.SedeId);
            return View(grados);
        }

        // POST: Grados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Grados grados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", grados.SedeId);
            return View(grados);
        }

        // GET: Grados/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grados grados = db.Grados.Find(id);
            if (grados == null)
            {
                return HttpNotFound();
            }
            return View(grados);
        }

        // POST: Grados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Grados grados = db.Grados.Find(id);
            db.Grados.Remove(grados);
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
