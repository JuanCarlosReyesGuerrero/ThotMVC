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
    public class ClasificacionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clasificaciones
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

            var clasificaciones = from s in db.Clasificaciones
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                clasificaciones = clasificaciones.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    clasificaciones = clasificaciones.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    clasificaciones = clasificaciones.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    clasificaciones = clasificaciones.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(clasificaciones.ToPagedList(pageNumber, pageSize));
        }

        // GET: Clasificaciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificaciones clasificaciones = db.Clasificaciones.Find(id);
            if (clasificaciones == null)
            {
                return HttpNotFound();
            }
            return View(clasificaciones);
        }

        // GET: Clasificaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clasificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Clasificaciones clasificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Clasificaciones.Add(clasificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasificaciones);
        }

        // GET: Clasificaciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificaciones clasificaciones = db.Clasificaciones.Find(id);
            if (clasificaciones == null)
            {
                return HttpNotFound();
            }
            return View(clasificaciones);
        }

        // POST: Clasificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Clasificaciones clasificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasificaciones);
        }

        // GET: Clasificaciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificaciones clasificaciones = db.Clasificaciones.Find(id);
            if (clasificaciones == null)
            {
                return HttpNotFound();
            }
            return View(clasificaciones);
        }

        // POST: Clasificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Clasificaciones clasificaciones = db.Clasificaciones.Find(id);
            db.Clasificaciones.Remove(clasificaciones);
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
