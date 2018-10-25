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
    public class FactorRhsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FactorRhs
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

            var factorRhs = from s in db.FactorRhs
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                factorRhs = factorRhs.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    factorRhs = factorRhs.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    factorRhs = factorRhs.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    factorRhs = factorRhs.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(factorRhs.ToPagedList(pageNumber, pageSize));
        }

        // GET: FactorRhs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // GET: FactorRhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FactorRhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FactorRhs factorRhs)
        {
            if (ModelState.IsValid)
            {
                db.FactorRhs.Add(factorRhs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(factorRhs);
        }

        // GET: FactorRhs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // POST: FactorRhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FactorRhs factorRhs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factorRhs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(factorRhs);
        }

        // GET: FactorRhs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            if (factorRhs == null)
            {
                return HttpNotFound();
            }
            return View(factorRhs);
        }

        // POST: FactorRhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FactorRhs factorRhs = db.FactorRhs.Find(id);
            db.FactorRhs.Remove(factorRhs);
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
