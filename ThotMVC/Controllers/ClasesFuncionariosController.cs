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
    public class ClasesFuncionariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClasesFuncionarios
        public ActionResult Index()
        {
            return View(db.ClasesFuncionarios.ToList());
        }

        // GET: ClasesFuncionarios/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasesFuncionarios clasesFuncionarios = db.ClasesFuncionarios.Find(id);
            if (clasesFuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(clasesFuncionarios);
        }

        // GET: ClasesFuncionarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClasesFuncionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] ClasesFuncionarios clasesFuncionarios)
        {
            if (ModelState.IsValid)
            {
                db.ClasesFuncionarios.Add(clasesFuncionarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasesFuncionarios);
        }

        // GET: ClasesFuncionarios/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasesFuncionarios clasesFuncionarios = db.ClasesFuncionarios.Find(id);
            if (clasesFuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(clasesFuncionarios);
        }

        // POST: ClasesFuncionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] ClasesFuncionarios clasesFuncionarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasesFuncionarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasesFuncionarios);
        }

        // GET: ClasesFuncionarios/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasesFuncionarios clasesFuncionarios = db.ClasesFuncionarios.Find(id);
            if (clasesFuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(clasesFuncionarios);
        }

        // POST: ClasesFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ClasesFuncionarios clasesFuncionarios = db.ClasesFuncionarios.Find(id);
            db.ClasesFuncionarios.Remove(clasesFuncionarios);
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