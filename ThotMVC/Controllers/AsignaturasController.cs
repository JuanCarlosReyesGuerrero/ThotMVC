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
    public class AsignaturasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Asignaturas
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

            var asignaturas = from s in db.Asignaturas
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                asignaturas = asignaturas.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    asignaturas = asignaturas.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    asignaturas = asignaturas.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    asignaturas = asignaturas.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(asignaturas.ToPagedList(pageNumber, pageSize));
        }

        // GET: Asignaturas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignaturas asignaturas = db.Asignaturas.Find(id);
            if (asignaturas == null)
            {
                return HttpNotFound();
            }
            return View(asignaturas);
        }

        // GET: Asignaturas/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: Asignaturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Asignaturas asignaturas)
        {
            if (ModelState.IsValid)
            {
                db.Asignaturas.Add(asignaturas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", asignaturas.SedeId);
            return View(asignaturas);
        }

        // GET: Asignaturas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignaturas asignaturas = db.Asignaturas.Find(id);
            if (asignaturas == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", asignaturas.SedeId);
            return View(asignaturas);
        }

        // POST: Asignaturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Asignaturas asignaturas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignaturas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", asignaturas.SedeId);
            return View(asignaturas);
        }

        // GET: Asignaturas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignaturas asignaturas = db.Asignaturas.Find(id);
            if (asignaturas == null)
            {
                return HttpNotFound();
            }
            return View(asignaturas);
        }

        // POST: Asignaturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Asignaturas asignaturas = db.Asignaturas.Find(id);
            db.Asignaturas.Remove(asignaturas);
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
