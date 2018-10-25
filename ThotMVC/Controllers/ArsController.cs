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
    public class ArsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ars
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

            var ars = from s in db.Ars
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                ars = ars.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    ars = ars.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    ars = ars.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    ars = ars.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(ars.ToPagedList(pageNumber, pageSize));
        }

        // GET: Ars/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // GET: Ars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Ars ars)
        {
            if (ModelState.IsValid)
            {
                db.Ars.Add(ars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ars);
        }

        // GET: Ars/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // POST: Ars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Ars ars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ars);
        }

        // GET: Ars/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ars ars = db.Ars.Find(id);
            if (ars == null)
            {
                return HttpNotFound();
            }
            return View(ars);
        }

        // POST: Ars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Ars ars = db.Ars.Find(id);
            db.Ars.Remove(ars);
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
