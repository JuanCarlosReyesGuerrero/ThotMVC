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
    public class PrestadoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prestadores
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

            var prestadores = from s in db.Prestadores
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                prestadores = prestadores.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    prestadores = prestadores.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    prestadores = prestadores.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    prestadores = prestadores.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(prestadores.ToPagedList(pageNumber, pageSize));
        }

        // GET: Prestadores/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestadores prestadores = db.Prestadores.Find(id);
            if (prestadores == null)
            {
                return HttpNotFound();
            }
            return View(prestadores);
        }

        // GET: Prestadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prestadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Prestadores prestadores)
        {
            if (ModelState.IsValid)
            {
                db.Prestadores.Add(prestadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestadores);
        }

        // GET: Prestadores/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestadores prestadores = db.Prestadores.Find(id);
            if (prestadores == null)
            {
                return HttpNotFound();
            }
            return View(prestadores);
        }

        // POST: Prestadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Prestadores prestadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestadores);
        }

        // GET: Prestadores/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestadores prestadores = db.Prestadores.Find(id);
            if (prestadores == null)
            {
                return HttpNotFound();
            }
            return View(prestadores);
        }

        // POST: Prestadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Prestadores prestadores = db.Prestadores.Find(id);
            db.Prestadores.Remove(prestadores);
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
