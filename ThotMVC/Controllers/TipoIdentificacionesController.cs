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
    public class TipoIdentificacionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoIdentificaciones
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

            var TipoIdentificaciones = from s in db.TipoIdentificaciones
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                TipoIdentificaciones = TipoIdentificaciones.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    TipoIdentificaciones = TipoIdentificaciones.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    TipoIdentificaciones = TipoIdentificaciones.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    TipoIdentificaciones = TipoIdentificaciones.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(TipoIdentificaciones.ToPagedList(pageNumber, pageSize));
        }

        // GET: TipoIdentificaciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoIdentificaciones tipoIdentificaciones = db.TipoIdentificaciones.Find(id);
            if (tipoIdentificaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoIdentificaciones);
        }

        // GET: TipoIdentificaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoIdentificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoIdentificaciones tipoIdentificaciones)
        {
            if (ModelState.IsValid)
            {
                db.TipoIdentificaciones.Add(tipoIdentificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoIdentificaciones);
        }

        // GET: TipoIdentificaciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoIdentificaciones tipoIdentificaciones = db.TipoIdentificaciones.Find(id);
            if (tipoIdentificaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoIdentificaciones);
        }

        // POST: TipoIdentificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoIdentificaciones tipoIdentificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoIdentificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoIdentificaciones);
        }

        // GET: TipoIdentificaciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoIdentificaciones tipoIdentificaciones = db.TipoIdentificaciones.Find(id);
            if (tipoIdentificaciones == null)
            {
                return HttpNotFound();
            }
            return View(tipoIdentificaciones);
        }

        // POST: TipoIdentificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoIdentificaciones tipoIdentificaciones = db.TipoIdentificaciones.Find(id);
            db.TipoIdentificaciones.Remove(tipoIdentificaciones);
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
