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
    public class EstratosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Estratos
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

            var estratos = from s in db.Estratos
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                estratos = estratos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    estratos = estratos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    estratos = estratos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    estratos = estratos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(estratos.ToPagedList(pageNumber, pageSize));
        }

        // GET: Estratos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estratos estratos = db.Estratos.Find(id);
            if (estratos == null)
            {
                return HttpNotFound();
            }
            return View(estratos);
        }

        // GET: Estratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Estratos estratos)
        {
            if (ModelState.IsValid)
            {
                db.Estratos.Add(estratos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estratos);
        }

        // GET: Estratos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estratos estratos = db.Estratos.Find(id);
            if (estratos == null)
            {
                return HttpNotFound();
            }
            return View(estratos);
        }

        // POST: Estratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Estratos estratos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estratos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estratos);
        }

        // GET: Estratos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estratos estratos = db.Estratos.Find(id);
            if (estratos == null)
            {
                return HttpNotFound();
            }
            return View(estratos);
        }

        // POST: Estratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Estratos estratos = db.Estratos.Find(id);
            db.Estratos.Remove(estratos);
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
