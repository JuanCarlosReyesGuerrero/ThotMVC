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
    public class EpsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Eps
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

            var Eps = from s in db.Eps
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Eps = Eps.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Eps = Eps.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    Eps = Eps.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    Eps = Eps.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(Eps.ToPagedList(pageNumber, pageSize));
        }

        // GET: Eps/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eps eps = db.Eps.Find(id);
            if (eps == null)
            {
                return HttpNotFound();
            }
            return View(eps);
        }

        // GET: Eps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Eps eps)
        {
            if (ModelState.IsValid)
            {
                db.Eps.Add(eps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eps);
        }

        // GET: Eps/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eps eps = db.Eps.Find(id);
            if (eps == null)
            {
                return HttpNotFound();
            }
            return View(eps);
        }

        // POST: Eps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Eps eps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eps);
        }

        // GET: Eps/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eps eps = db.Eps.Find(id);
            if (eps == null)
            {
                return HttpNotFound();
            }
            return View(eps);
        }

        // POST: Eps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Eps eps = db.Eps.Find(id);
            db.Eps.Remove(eps);
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
