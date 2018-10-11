﻿using System;
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
    public class EstadoCivilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EstadoCiviles
        public ActionResult Index()
        {
            return View(db.EstadoCiviles.ToList());
        }

        // GET: EstadoCiviles/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoCiviles estadoCiviles = db.EstadoCiviles.Find(id);
            if (estadoCiviles == null)
            {
                return HttpNotFound();
            }
            return View(estadoCiviles);
        }

        // GET: EstadoCiviles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoCiviles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EstadoCiviles estadoCiviles)
        {
            if (ModelState.IsValid)
            {
                db.EstadoCiviles.Add(estadoCiviles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoCiviles);
        }

        // GET: EstadoCiviles/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoCiviles estadoCiviles = db.EstadoCiviles.Find(id);
            if (estadoCiviles == null)
            {
                return HttpNotFound();
            }
            return View(estadoCiviles);
        }

        // POST: EstadoCiviles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] EstadoCiviles estadoCiviles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoCiviles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoCiviles);
        }

        // GET: EstadoCiviles/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoCiviles estadoCiviles = db.EstadoCiviles.Find(id);
            if (estadoCiviles == null)
            {
                return HttpNotFound();
            }
            return View(estadoCiviles);
        }

        // POST: EstadoCiviles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EstadoCiviles estadoCiviles = db.EstadoCiviles.Find(id);
            db.EstadoCiviles.Remove(estadoCiviles);
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
