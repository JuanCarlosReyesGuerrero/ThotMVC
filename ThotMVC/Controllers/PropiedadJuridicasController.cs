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
    public class PropiedadJuridicasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PropiedadJuridicas
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

            var PropiedadJuridicas = from s in db.PropiedadJuridicas
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                PropiedadJuridicas = PropiedadJuridicas.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    PropiedadJuridicas = PropiedadJuridicas.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    PropiedadJuridicas = PropiedadJuridicas.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    PropiedadJuridicas = PropiedadJuridicas.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(PropiedadJuridicas.ToPagedList(pageNumber, pageSize));
        }

        // GET: PropiedadJuridicas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropiedadJuridicas propiedadJuridicas = db.PropiedadJuridicas.Find(id);
            if (propiedadJuridicas == null)
            {
                return HttpNotFound();
            }
            return View(propiedadJuridicas);
        }

        // GET: PropiedadJuridicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropiedadJuridicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] PropiedadJuridicas propiedadJuridicas)
        {
            if (ModelState.IsValid)
            {
                db.PropiedadJuridicas.Add(propiedadJuridicas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propiedadJuridicas);
        }

        // GET: PropiedadJuridicas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropiedadJuridicas propiedadJuridicas = db.PropiedadJuridicas.Find(id);
            if (propiedadJuridicas == null)
            {
                return HttpNotFound();
            }
            return View(propiedadJuridicas);
        }

        // POST: PropiedadJuridicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] PropiedadJuridicas propiedadJuridicas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propiedadJuridicas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propiedadJuridicas);
        }

        // GET: PropiedadJuridicas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropiedadJuridicas propiedadJuridicas = db.PropiedadJuridicas.Find(id);
            if (propiedadJuridicas == null)
            {
                return HttpNotFound();
            }
            return View(propiedadJuridicas);
        }

        // POST: PropiedadJuridicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PropiedadJuridicas propiedadJuridicas = db.PropiedadJuridicas.Find(id);
            db.PropiedadJuridicas.Remove(propiedadJuridicas);
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
