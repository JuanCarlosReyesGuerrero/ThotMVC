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
    public class ProfesionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Profesiones
        public ActionResult Index()
        {
            return View(db.Profesiones.ToList());
        }

        // GET: Profesiones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesiones profesiones = db.Profesiones.Find(id);
            if (profesiones == null)
            {
                return HttpNotFound();
            }
            return View(profesiones);
        }

        // GET: Profesiones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesiones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesiones profesiones)
        {
            if (ModelState.IsValid)
            {
                db.Profesiones.Add(profesiones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profesiones);
        }

        // GET: Profesiones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesiones profesiones = db.Profesiones.Find(id);
            if (profesiones == null)
            {
                return HttpNotFound();
            }
            return View(profesiones);
        }

        // POST: Profesiones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Profesiones profesiones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesiones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profesiones);
        }

        // GET: Profesiones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesiones profesiones = db.Profesiones.Find(id);
            if (profesiones == null)
            {
                return HttpNotFound();
            }
            return View(profesiones);
        }

        // POST: Profesiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Profesiones profesiones = db.Profesiones.Find(id);
            db.Profesiones.Remove(profesiones);
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