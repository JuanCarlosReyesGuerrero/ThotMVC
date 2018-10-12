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
    public class ParentescosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Parentescos
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

            var Parentescos = from s in db.Parentescos
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Parentescos = Parentescos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Parentescos = Parentescos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    Parentescos = Parentescos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    Parentescos = Parentescos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(Parentescos.ToPagedList(pageNumber, pageSize));
        }

        // GET: Parentescos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentescos parentescos = db.Parentescos.Find(id);
            if (parentescos == null)
            {
                return HttpNotFound();
            }
            return View(parentescos);
        }

        // GET: Parentescos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parentescos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Parentescos parentescos)
        {
            if (ModelState.IsValid)
            {
                db.Parentescos.Add(parentescos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentescos);
        }

        // GET: Parentescos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentescos parentescos = db.Parentescos.Find(id);
            if (parentescos == null)
            {
                return HttpNotFound();
            }
            return View(parentescos);
        }

        // POST: Parentescos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Parentescos parentescos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentescos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentescos);
        }

        // GET: Parentescos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentescos parentescos = db.Parentescos.Find(id);
            if (parentescos == null)
            {
                return HttpNotFound();
            }
            return View(parentescos);
        }

        // POST: Parentescos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Parentescos parentescos = db.Parentescos.Find(id);
            db.Parentescos.Remove(parentescos);
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
