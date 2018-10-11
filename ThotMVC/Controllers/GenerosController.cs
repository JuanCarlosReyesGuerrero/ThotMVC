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
    public class GenerosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Generos
        public ActionResult Index()
        {
            return View(db.Generos.ToList());
        }

        // GET: Generos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generos generos = db.Generos.Find(id);
            if (generos == null)
            {
                return HttpNotFound();
            }
            return View(generos);
        }

        // GET: Generos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Generos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Generos generos)
        {
            if (ModelState.IsValid)
            {
                db.Generos.Add(generos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(generos);
        }

        // GET: Generos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generos generos = db.Generos.Find(id);
            if (generos == null)
            {
                return HttpNotFound();
            }
            return View(generos);
        }

        // POST: Generos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Generos generos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(generos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generos);
        }

        // GET: Generos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generos generos = db.Generos.Find(id);
            if (generos == null)
            {
                return HttpNotFound();
            }
            return View(generos);
        }

        // POST: Generos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Generos generos = db.Generos.Find(id);
            db.Generos.Remove(generos);
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
