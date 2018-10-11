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
    public class NucleosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Nucleos
        public ActionResult Index()
        {
            var nucleos = db.Nucleos.Include(n => n.Departamentos).Include(n => n.Municipios);
            return View(nucleos.ToList());
        }

        // GET: Nucleos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            return View(nucleos);
        }

        // GET: Nucleos/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo");
            return View();
        }

        // POST: Nucleos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Direccion,Telefono,DepartamentoId,MunicipioId,NombreDirector,TelefonoDirector,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Nucleos nucleos)
        {
            if (ModelState.IsValid)
            {
                db.Nucleos.Add(nucleos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // GET: Nucleos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // POST: Nucleos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Direccion,Telefono,DepartamentoId,MunicipioId,NombreDirector,TelefonoDirector,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Nucleos nucleos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nucleos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", nucleos.DepartamentoId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", nucleos.MunicipioId);
            return View(nucleos);
        }

        // GET: Nucleos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nucleos nucleos = db.Nucleos.Find(id);
            if (nucleos == null)
            {
                return HttpNotFound();
            }
            return View(nucleos);
        }

        // POST: Nucleos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Nucleos nucleos = db.Nucleos.Find(id);
            db.Nucleos.Remove(nucleos);
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
