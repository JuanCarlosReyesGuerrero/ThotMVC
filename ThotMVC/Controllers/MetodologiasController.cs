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
    public class MetodologiasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Metodologias
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

            var Metodologias = from s in db.Metodologias
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Metodologias = Metodologias.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Metodologias = Metodologias.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    Metodologias = Metodologias.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    Metodologias = Metodologias.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(Metodologias.ToPagedList(pageNumber, pageSize));
        }

        // GET: Metodologias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // GET: Metodologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metodologias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Metodologias metodologias)
        {
            if (ModelState.IsValid)
            {
                db.Metodologias.Add(metodologias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metodologias);
        }

        // GET: Metodologias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // POST: Metodologias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Metodologias metodologias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metodologias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metodologias);
        }

        // GET: Metodologias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metodologias metodologias = db.Metodologias.Find(id);
            if (metodologias == null)
            {
                return HttpNotFound();
            }
            return View(metodologias);
        }

        // POST: Metodologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Metodologias metodologias = db.Metodologias.Find(id);
            db.Metodologias.Remove(metodologias);
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
