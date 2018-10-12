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
    public class SituacionAcademicasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SituacionAcademicas
        public ActionResult Index()
        {
            return View(db.SituacionAcademicas.ToList());
        }

        // GET: SituacionAcademicas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacionAcademicas situacionAcademicas = db.SituacionAcademicas.Find(id);
            if (situacionAcademicas == null)
            {
                return HttpNotFound();
            }
            return View(situacionAcademicas);
        }

        // GET: SituacionAcademicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SituacionAcademicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] SituacionAcademicas situacionAcademicas)
        {
            if (ModelState.IsValid)
            {
                db.SituacionAcademicas.Add(situacionAcademicas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(situacionAcademicas);
        }

        // GET: SituacionAcademicas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacionAcademicas situacionAcademicas = db.SituacionAcademicas.Find(id);
            if (situacionAcademicas == null)
            {
                return HttpNotFound();
            }
            return View(situacionAcademicas);
        }

        // POST: SituacionAcademicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] SituacionAcademicas situacionAcademicas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(situacionAcademicas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(situacionAcademicas);
        }

        // GET: SituacionAcademicas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacionAcademicas situacionAcademicas = db.SituacionAcademicas.Find(id);
            if (situacionAcademicas == null)
            {
                return HttpNotFound();
            }
            return View(situacionAcademicas);
        }

        // POST: SituacionAcademicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SituacionAcademicas situacionAcademicas = db.SituacionAcademicas.Find(id);
            db.SituacionAcademicas.Remove(situacionAcademicas);
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