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
    public class SisbenesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sisbenes
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

            var Sisbenes = from s in db.Sisbenes
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Sisbenes = Sisbenes.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Sisbenes = Sisbenes.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    Sisbenes = Sisbenes.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    Sisbenes = Sisbenes.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(Sisbenes.ToPagedList(pageNumber, pageSize));
        }

        // GET: Sisbenes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sisbenes sisbenes = db.Sisbenes.Find(id);
            if (sisbenes == null)
            {
                return HttpNotFound();
            }
            return View(sisbenes);
        }

        // GET: Sisbenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sisbenes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Sisbenes sisbenes)
        {
            if (ModelState.IsValid)
            {
                db.Sisbenes.Add(sisbenes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sisbenes);
        }

        // GET: Sisbenes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sisbenes sisbenes = db.Sisbenes.Find(id);
            if (sisbenes == null)
            {
                return HttpNotFound();
            }
            return View(sisbenes);
        }

        // POST: Sisbenes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Sisbenes sisbenes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sisbenes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sisbenes);
        }

        // GET: Sisbenes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sisbenes sisbenes = db.Sisbenes.Find(id);
            if (sisbenes == null)
            {
                return HttpNotFound();
            }
            return View(sisbenes);
        }

        // POST: Sisbenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Sisbenes sisbenes = db.Sisbenes.Find(id);
            db.Sisbenes.Remove(sisbenes);
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
