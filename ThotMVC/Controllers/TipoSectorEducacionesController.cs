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
    public class TipoSectorEducacionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoSectorEducaciones
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var TipoSectorEducaciones = from s in db.TipoSectorEducaciones
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                TipoSectorEducaciones = TipoSectorEducaciones.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    TipoSectorEducaciones = TipoSectorEducaciones.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    TipoSectorEducaciones = TipoSectorEducaciones.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    TipoSectorEducaciones = TipoSectorEducaciones.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(TipoSectorEducaciones.ToPagedList(pageNumber, pageSize));
        }

        // GET: TipoSectorEducaciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSectorEducaciones tipoSectorEducaciones = db.TipoSectorEducaciones.Find(id);
            if (tipoSectorEducaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoSectorEducaciones);
        }

        // GET: TipoSectorEducaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoSectorEducaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoSectorEducaciones tipoSectorEducaciones)
        {
            if (ModelState.IsValid)
            {
                db.TipoSectorEducaciones.Add(tipoSectorEducaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoSectorEducaciones);
        }

        // GET: TipoSectorEducaciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSectorEducaciones tipoSectorEducaciones = db.TipoSectorEducaciones.Find(id);
            if (tipoSectorEducaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoSectorEducaciones);
        }

        // POST: TipoSectorEducaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoSectorEducaciones tipoSectorEducaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoSectorEducaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoSectorEducaciones);
        }

        // GET: TipoSectorEducaciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSectorEducaciones tipoSectorEducaciones = db.TipoSectorEducaciones.Find(id);
            if (tipoSectorEducaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoSectorEducaciones);
        }

        // POST: TipoSectorEducaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoSectorEducaciones tipoSectorEducaciones = db.TipoSectorEducaciones.Find(id);
            db.TipoSectorEducaciones.Remove(tipoSectorEducaciones);
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
