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
    public class EscalaNacionalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EscalaNacionales
        //public ActionResult Index()
        //{
        //    var escalaNacionales = db.EscalaNacionales.Include(e => e.Sedes);
        //    return View(escalaNacionales.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "codigo_desc" : "Codigo";
            ViewBag.YYYSortParm = sortOrder == "Sedes" ? "sedes_desc" : "Sedes";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var escalaNacionales = from s in db.EscalaNacionales.Include(m => m.Sedes)
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                escalaNacionales = escalaNacionales.Where(s => s.Nombre.Contains(searchString)
                                       || s.Sedes.Nombre.Contains(searchString)
                                       || s.Codigo.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "nombre_desc":
                    escalaNacionales = escalaNacionales.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    escalaNacionales = escalaNacionales.OrderBy(s => s.Codigo);
                    break;
                case "codigo_desc":
                    escalaNacionales = escalaNacionales.OrderByDescending(s => s.Codigo);
                    break;
                case "Sedes":
                    escalaNacionales = escalaNacionales.OrderBy(s => s.Sedes.Nombre);
                    break;
                case "sedes_desc":
                    escalaNacionales = escalaNacionales.OrderByDescending(s => s.Sedes.Nombre);
                    break;
                default:  // Name ascending 
                    escalaNacionales = escalaNacionales.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(escalaNacionales.ToPagedList(pageNumber, pageSize));
        }

        // GET: EscalaNacionales/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: EscalaNacionales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,CriterioEvalaluacion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EscalaNacionales escalaNacionales)
        {
            if (ModelState.IsValid)
            {
                db.EscalaNacionales.Add(escalaNacionales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // POST: EscalaNacionales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,CriterioEvalaluacion,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EscalaNacionales escalaNacionales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escalaNacionales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", escalaNacionales.SedeId);
            return View(escalaNacionales);
        }

        // GET: EscalaNacionales/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            if (escalaNacionales == null)
            {
                return HttpNotFound();
            }
            return View(escalaNacionales);
        }

        // POST: EscalaNacionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EscalaNacionales escalaNacionales = db.EscalaNacionales.Find(id);
            db.EscalaNacionales.Remove(escalaNacionales);
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
