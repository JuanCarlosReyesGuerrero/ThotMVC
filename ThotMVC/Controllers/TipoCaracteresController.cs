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
    public class TipoCaracteresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoCaracteres
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

            var TipoCaracteres = from s in db.TipoCaracteres
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                TipoCaracteres = TipoCaracteres.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    TipoCaracteres = TipoCaracteres.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    TipoCaracteres = TipoCaracteres.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    TipoCaracteres = TipoCaracteres.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(TipoCaracteres.ToPagedList(pageNumber, pageSize));
        }

        // GET: TipoCaracteres/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCaracteres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCaracteres tipoCaracteres)
        {
            if (ModelState.IsValid)
            {
                db.TipoCaracteres.Add(tipoCaracteres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // POST: TipoCaracteres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] TipoCaracteres tipoCaracteres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCaracteres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCaracteres);
        }

        // GET: TipoCaracteres/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            if (tipoCaracteres == null)
            {
                return HttpNotFound();
            }
            return View(tipoCaracteres);
        }

        // POST: TipoCaracteres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoCaracteres tipoCaracteres = db.TipoCaracteres.Find(id);
            db.TipoCaracteres.Remove(tipoCaracteres);
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
