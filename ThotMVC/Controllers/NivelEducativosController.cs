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
    public class NivelEducativosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NivelEducativos
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

            var NivelEducativos = from s in db.NivelEducativos
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                NivelEducativos = NivelEducativos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    NivelEducativos = NivelEducativos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    NivelEducativos = NivelEducativos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    NivelEducativos = NivelEducativos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(NivelEducativos.ToPagedList(pageNumber, pageSize));
        }

        // GET: NivelEducativos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativos nivelEducativos = db.NivelEducativos.Find(id);
            if (nivelEducativos == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativos);
        }

        // GET: NivelEducativos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NivelEducativos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] NivelEducativos nivelEducativos)
        {
            if (ModelState.IsValid)
            {
                db.NivelEducativos.Add(nivelEducativos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nivelEducativos);
        }

        // GET: NivelEducativos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativos nivelEducativos = db.NivelEducativos.Find(id);
            if (nivelEducativos == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativos);
        }

        // POST: NivelEducativos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] NivelEducativos nivelEducativos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nivelEducativos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nivelEducativos);
        }

        // GET: NivelEducativos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEducativos nivelEducativos = db.NivelEducativos.Find(id);
            if (nivelEducativos == null)
            {
                return HttpNotFound();
            }
            return View(nivelEducativos);
        }

        // POST: NivelEducativos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            NivelEducativos nivelEducativos = db.NivelEducativos.Find(id);
            db.NivelEducativos.Remove(nivelEducativos);
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
