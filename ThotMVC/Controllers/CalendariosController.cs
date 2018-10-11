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
    public class CalendariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Calendarios
        public ActionResult Index()
        {
            return View(db.Calendarios.ToList());
        }

        // GET: Calendarios/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendarios calendarios = db.Calendarios.Find(id);
            if (calendarios == null)
            {
                return HttpNotFound();
            }
            return View(calendarios);
        }

        // GET: Calendarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calendarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Calendarios calendarios)
        {
            if (ModelState.IsValid)
            {
                db.Calendarios.Add(calendarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calendarios);
        }

        // GET: Calendarios/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendarios calendarios = db.Calendarios.Find(id);
            if (calendarios == null)
            {
                return HttpNotFound();
            }
            return View(calendarios);
        }

        // POST: Calendarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Calendarios calendarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calendarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calendarios);
        }

        // GET: Calendarios/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendarios calendarios = db.Calendarios.Find(id);
            if (calendarios == null)
            {
                return HttpNotFound();
            }
            return View(calendarios);
        }

        // POST: Calendarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Calendarios calendarios = db.Calendarios.Find(id);
            db.Calendarios.Remove(calendarios);
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