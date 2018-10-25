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
    public class TipoRespuestasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoRespuestas
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

            var tipoRespuestas = from s in db.TipoRespuestas
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                tipoRespuestas = tipoRespuestas.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    tipoRespuestas = tipoRespuestas.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    tipoRespuestas = tipoRespuestas.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    tipoRespuestas = tipoRespuestas.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(tipoRespuestas.ToPagedList(pageNumber, pageSize));
        }

        // GET: TipoRespuestas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoRespuestas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoRespuestas tipoRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.TipoRespuestas.Add(tipoRespuestas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // POST: TipoRespuestas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoRespuestas tipoRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoRespuestas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoRespuestas);
        }

        // GET: TipoRespuestas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            if (tipoRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(tipoRespuestas);
        }

        // POST: TipoRespuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoRespuestas tipoRespuestas = db.TipoRespuestas.Find(id);
            db.TipoRespuestas.Remove(tipoRespuestas);
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
