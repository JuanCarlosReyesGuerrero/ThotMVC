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
    public class PoblacionVictimaConflictosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PoblacionVictimaConflictos
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

            var PoblacionVictimaConflictos = from s in db.PoblacionVictimaConflictos
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                PoblacionVictimaConflictos = PoblacionVictimaConflictos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    PoblacionVictimaConflictos = PoblacionVictimaConflictos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    PoblacionVictimaConflictos = PoblacionVictimaConflictos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    PoblacionVictimaConflictos = PoblacionVictimaConflictos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(PoblacionVictimaConflictos.ToPagedList(pageNumber, pageSize));
        }

        // GET: PoblacionVictimaConflictos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoblacionVictimaConflictos poblacionVictimaConflictos = db.PoblacionVictimaConflictos.Find(id);
            if (poblacionVictimaConflictos == null)
            {
                return HttpNotFound();
            }
            return View(poblacionVictimaConflictos);
        }

        // GET: PoblacionVictimaConflictos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoblacionVictimaConflictos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] PoblacionVictimaConflictos poblacionVictimaConflictos)
        {
            if (ModelState.IsValid)
            {
                db.PoblacionVictimaConflictos.Add(poblacionVictimaConflictos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poblacionVictimaConflictos);
        }

        // GET: PoblacionVictimaConflictos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoblacionVictimaConflictos poblacionVictimaConflictos = db.PoblacionVictimaConflictos.Find(id);
            if (poblacionVictimaConflictos == null)
            {
                return HttpNotFound();
            }
            return View(poblacionVictimaConflictos);
        }

        // POST: PoblacionVictimaConflictos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] PoblacionVictimaConflictos poblacionVictimaConflictos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(poblacionVictimaConflictos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(poblacionVictimaConflictos);
        }

        // GET: PoblacionVictimaConflictos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoblacionVictimaConflictos poblacionVictimaConflictos = db.PoblacionVictimaConflictos.Find(id);
            if (poblacionVictimaConflictos == null)
            {
                return HttpNotFound();
            }
            return View(poblacionVictimaConflictos);
        }

        // POST: PoblacionVictimaConflictos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PoblacionVictimaConflictos poblacionVictimaConflictos = db.PoblacionVictimaConflictos.Find(id);
            db.PoblacionVictimaConflictos.Remove(poblacionVictimaConflictos);
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
