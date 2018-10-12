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
    public class TipoAcademicosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoAcademicos
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

            var TipoAcademicos = from s in db.TipoAcademicos
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                TipoAcademicos = TipoAcademicos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    TipoAcademicos = TipoAcademicos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    TipoAcademicos = TipoAcademicos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    TipoAcademicos = TipoAcademicos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(TipoAcademicos.ToPagedList(pageNumber, pageSize));
        }

        // GET: TipoAcademicos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAcademicos tipoAcademicos = db.TipoAcademicos.Find(id);
            if (tipoAcademicos == null)
            {
                return HttpNotFound();
            }
            return View(tipoAcademicos);
        }

        // GET: TipoAcademicos/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: TipoAcademicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoAcademicos tipoAcademicos)
        {
            if (ModelState.IsValid)
            {
                db.TipoAcademicos.Add(tipoAcademicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", tipoAcademicos.SedeId);
            return View(tipoAcademicos);
        }

        // GET: TipoAcademicos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAcademicos tipoAcademicos = db.TipoAcademicos.Find(id);
            if (tipoAcademicos == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", tipoAcademicos.SedeId);
            return View(tipoAcademicos);
        }

        // POST: TipoAcademicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoAcademicos tipoAcademicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoAcademicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", tipoAcademicos.SedeId);
            return View(tipoAcademicos);
        }

        // GET: TipoAcademicos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAcademicos tipoAcademicos = db.TipoAcademicos.Find(id);
            if (tipoAcademicos == null)
            {
                return HttpNotFound();
            }
            return View(tipoAcademicos);
        }

        // POST: TipoAcademicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoAcademicos tipoAcademicos = db.TipoAcademicos.Find(id);
            db.TipoAcademicos.Remove(tipoAcademicos);
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
