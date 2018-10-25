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
    public class CapacidadExcepcionalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CapacidadExcepcionales
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

            var capacidadExcepcionales = from s in db.CapacidadExcepcionales
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                capacidadExcepcionales = capacidadExcepcionales.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    capacidadExcepcionales = capacidadExcepcionales.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    capacidadExcepcionales = capacidadExcepcionales.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    capacidadExcepcionales = capacidadExcepcionales.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(capacidadExcepcionales.ToPagedList(pageNumber, pageSize));
        }

        // GET: CapacidadExcepcionales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapacidadExcepcionales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] CapacidadExcepcionales capacidadExcepcionales)
        {
            if (ModelState.IsValid)
            {
                db.CapacidadExcepcionales.Add(capacidadExcepcionales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // POST: CapacidadExcepcionales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] CapacidadExcepcionales capacidadExcepcionales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capacidadExcepcionales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capacidadExcepcionales);
        }

        // GET: CapacidadExcepcionales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            if (capacidadExcepcionales == null)
            {
                return HttpNotFound();
            }
            return View(capacidadExcepcionales);
        }

        // POST: CapacidadExcepcionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CapacidadExcepcionales capacidadExcepcionales = db.CapacidadExcepcionales.Find(id);
            db.CapacidadExcepcionales.Remove(capacidadExcepcionales);
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
