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
    public class ValoracionLetrasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ValoracionLetras
        public ActionResult Index()
        {
            var valoracionLetras = db.ValoracionLetras.Include(v => v.Sedes);
            return View(valoracionLetras.ToList());
        }

        // GET: ValoracionLetras/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ValoracionLetras valoracionLetras = db.ValoracionLetras.Find(id);
            if (valoracionLetras == null)
            {
                return HttpNotFound();
            }
            return View(valoracionLetras);
        }

        // GET: ValoracionLetras/Create
        public ActionResult Create()
        {
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo");
            return View();
        }

        // POST: ValoracionLetras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Descripcion,ValorNumerico,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] ValoracionLetras valoracionLetras)
        {
            if (ModelState.IsValid)
            {
                db.ValoracionLetras.Add(valoracionLetras);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", valoracionLetras.SedeId);
            return View(valoracionLetras);
        }

        // GET: ValoracionLetras/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ValoracionLetras valoracionLetras = db.ValoracionLetras.Find(id);
            if (valoracionLetras == null)
            {
                return HttpNotFound();
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", valoracionLetras.SedeId);
            return View(valoracionLetras);
        }

        // POST: ValoracionLetras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Descripcion,ValorNumerico,SedeId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] ValoracionLetras valoracionLetras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valoracionLetras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SedeId = new SelectList(db.Sedes, "Id", "Codigo", valoracionLetras.SedeId);
            return View(valoracionLetras);
        }

        // GET: ValoracionLetras/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ValoracionLetras valoracionLetras = db.ValoracionLetras.Find(id);
            if (valoracionLetras == null)
            {
                return HttpNotFound();
            }
            return View(valoracionLetras);
        }

        // POST: ValoracionLetras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ValoracionLetras valoracionLetras = db.ValoracionLetras.Find(id);
            db.ValoracionLetras.Remove(valoracionLetras);
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
