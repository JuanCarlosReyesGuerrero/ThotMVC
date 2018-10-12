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
    public class EtniasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Etnias
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

            var Etnias = from s in db.Etnias
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Etnias = Etnias.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Etnias = Etnias.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    Etnias = Etnias.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    Etnias = Etnias.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(Etnias.ToPagedList(pageNumber, pageSize));
        }

        // GET: Etnias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etnias etnias = db.Etnias.Find(id);
            if (etnias == null)
            {
                return HttpNotFound();
            }
            return View(etnias);
        }

        // GET: Etnias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Etnias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Etnias etnias)
        {
            if (ModelState.IsValid)
            {
                db.Etnias.Add(etnias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(etnias);
        }

        // GET: Etnias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etnias etnias = db.Etnias.Find(id);
            if (etnias == null)
            {
                return HttpNotFound();
            }
            return View(etnias);
        }

        // POST: Etnias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Etnias etnias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etnias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(etnias);
        }

        // GET: Etnias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etnias etnias = db.Etnias.Find(id);
            if (etnias == null)
            {
                return HttpNotFound();
            }
            return View(etnias);
        }

        // POST: Etnias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Etnias etnias = db.Etnias.Find(id);
            db.Etnias.Remove(etnias);
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
