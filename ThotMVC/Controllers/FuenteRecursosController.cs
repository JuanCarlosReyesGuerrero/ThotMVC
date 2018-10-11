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
    public class FuenteRecursosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FuenteRecursos
        public ActionResult Index()
        {
            return View(db.FuenteRecursos.ToList());
        }

        // GET: FuenteRecursos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuenteRecursos fuenteRecursos = db.FuenteRecursos.Find(id);
            if (fuenteRecursos == null)
            {
                return HttpNotFound();
            }
            return View(fuenteRecursos);
        }

        // GET: FuenteRecursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuenteRecursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FuenteRecursos fuenteRecursos)
        {
            if (ModelState.IsValid)
            {
                db.FuenteRecursos.Add(fuenteRecursos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuenteRecursos);
        }

        // GET: FuenteRecursos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuenteRecursos fuenteRecursos = db.FuenteRecursos.Find(id);
            if (fuenteRecursos == null)
            {
                return HttpNotFound();
            }
            return View(fuenteRecursos);
        }

        // POST: FuenteRecursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] FuenteRecursos fuenteRecursos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuenteRecursos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuenteRecursos);
        }

        // GET: FuenteRecursos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuenteRecursos fuenteRecursos = db.FuenteRecursos.Find(id);
            if (fuenteRecursos == null)
            {
                return HttpNotFound();
            }
            return View(fuenteRecursos);
        }

        // POST: FuenteRecursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FuenteRecursos fuenteRecursos = db.FuenteRecursos.Find(id);
            db.FuenteRecursos.Remove(fuenteRecursos);
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
