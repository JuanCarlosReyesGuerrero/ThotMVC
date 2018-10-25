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
    public class RegimenCostosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RegimenCostos
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

            var regimenCostos = from s in db.RegimenCostos
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                regimenCostos = regimenCostos.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    regimenCostos = regimenCostos.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    regimenCostos = regimenCostos.OrderBy(s => s.Codigo);
                    break;
                default:  // Name ascending 
                    regimenCostos = regimenCostos.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(regimenCostos.ToPagedList(pageNumber, pageSize));
        }

        // GET: RegimenCostos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // GET: RegimenCostos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegimenCostos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] RegimenCostos regimenCostos)
        {
            if (ModelState.IsValid)
            {
                db.RegimenCostos.Add(regimenCostos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regimenCostos);
        }

        // GET: RegimenCostos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // POST: RegimenCostos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] RegimenCostos regimenCostos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regimenCostos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regimenCostos);
        }

        // GET: RegimenCostos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            if (regimenCostos == null)
            {
                return HttpNotFound();
            }
            return View(regimenCostos);
        }

        // POST: RegimenCostos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            RegimenCostos regimenCostos = db.RegimenCostos.Find(id);
            db.RegimenCostos.Remove(regimenCostos);
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
