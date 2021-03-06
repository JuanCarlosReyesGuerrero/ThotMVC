﻿using PagedList;
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
    public class LibretaMilitaresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LibretaMilitares
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

            var libretaMilitares = from s in db.LibretaMilitares
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                libretaMilitares = libretaMilitares.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    libretaMilitares = libretaMilitares.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    libretaMilitares = libretaMilitares.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    libretaMilitares = libretaMilitares.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(libretaMilitares.ToPagedList(pageNumber, pageSize));
        }

        // GET: LibretaMilitares/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibretaMilitares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] LibretaMilitares libretaMilitares)
        {
            if (ModelState.IsValid)
            {
                db.LibretaMilitares.Add(libretaMilitares);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // POST: LibretaMilitares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] LibretaMilitares libretaMilitares)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libretaMilitares).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libretaMilitares);
        }

        // GET: LibretaMilitares/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            if (libretaMilitares == null)
            {
                return HttpNotFound();
            }
            return View(libretaMilitares);
        }

        // POST: LibretaMilitares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            LibretaMilitares libretaMilitares = db.LibretaMilitares.Find(id);
            db.LibretaMilitares.Remove(libretaMilitares);
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
