using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThotMVC.Models;
using System.IO;

namespace ThotMVC.Controllers
{
    public class InstitucionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Instituciones
        //public ActionResult Index()
        //{
        //    var instituciones = db.Instituciones.Include(i => i.AsociacionPrivadas).Include(i => i.Calendarios).Include(i => i.CapacidadExcepcionales).Include(i => i.Departamentos).Include(i => i.Etnias).Include(i => i.Generos).Include(i => i.Idiomas).Include(i => i.Metodologias).Include(i => i.Municipios).Include(i => i.Nucleos).Include(i => i.Prestadores).Include(i => i.PropiedadJuridicas).Include(i => i.RegimenCostos).Include(i => i.Resguardos).Include(i => i.TarifaAnuales).Include(i => i.TipoDiscapacidades).Include(i => i.TipoNovedades).Include(i => i.TipoSectorEducaciones).Include(i => i.Zonas);
        //    return View(instituciones.ToList());
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //ViewBag.CurrentSort = sortOrder;
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            //if (searchString != null)
            //{
            //    page = 1;
            //}
            //else
            //{
            //    searchString = currentFilter;
            //}

            //ViewBag.CurrentFilter = searchString;

            //var instituciones = db.Instituciones.Include(i => i.AsociacionPrivadas).Include(i => i.Calendarios).Include(i => i.CapacidadExcepcionales).Include(i => i.Departamentos).Include(i => i.Etnias).Include(i => i.Generos).Include(i => i.Idiomas).Include(i => i.Metodologias).Include(i => i.Municipios).Include(i => i.Nucleos).Include(i => i.Prestadores).Include(i => i.PropiedadJuridicas).Include(i => i.RegimenCostos).Include(i => i.Resguardos).Include(i => i.TarifaAnuales).Include(i => i.TipoDiscapacidades).Include(i => i.TipoNovedades).Include(i => i.TipoSectorEducaciones).Include(i => i.Zonas);

            //int pageSize = 10;
            //int pageNumber = (page ?? 1);
            //return View(instituciones.ToPagedList(pageNumber, pageSize));





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

            var instituciones = from s in db.Instituciones.Include(i => i.AsociacionPrivadas).Include(i => i.Calendarios).Include(i => i.CapacidadExcepcionales).Include(i => i.Departamentos).Include(i => i.Etnias).Include(i => i.Generos).Include(i => i.Idiomas).Include(i => i.Metodologias).Include(i => i.Municipios).Include(i => i.Nucleos).Include(i => i.Prestadores).Include(i => i.PropiedadJuridicas).Include(i => i.RegimenCostos).Include(i => i.Resguardos).Include(i => i.TarifaAnuales).Include(i => i.TipoDiscapacidades).Include(i => i.TipoNovedades).Include(i => i.TipoSectorEducaciones).Include(i => i.Zonas)
                                select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                instituciones = instituciones.Where(s => s.Nombre.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    instituciones = instituciones.OrderByDescending(s => s.Nombre);
                    break;
                case "Codigo":
                    instituciones = instituciones.OrderBy(s => s.CodigoDane);
                    break;
                default:  // Name ascending 
                    instituciones = instituciones.OrderBy(s => s.Nombre);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(instituciones.ToPagedList(pageNumber, pageSize));



        }

        // GET: Instituciones/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituciones instituciones = db.Instituciones.Find(id);
            if (instituciones == null)
            {
                return HttpNotFound();
            }
            return View(instituciones);
        }

        // GET: Instituciones/Create
        public ActionResult Create()
        {
            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Nombre");
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Nombre");
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Nombre");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre");
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Nombre");
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre");
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Nombre");
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Nombre");
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Nombre");
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Nombre");
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Nombre");
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Nombre");
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Nombre");
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Nombre");
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Nombre");
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Nombre");
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Nombre");
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Nombre");
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Nombre");
            return View();
        }

        // POST: Instituciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CodigoDane,Nombre,Nit,NombreRector,CalendarioId,TipoSectorEducacionId,PropiedadJuridicaId,NumeroSedes,NucleoId,GeneroId,Subsidio,DiscapacidadesId,CapacidadesExcepcionalesId,EtniasId,ResguardosId,NovedadId,MetodologiaId,PrestadorServicioId,DecretoCreacion,Director,Secretaria,Aprobacion,Lema,Escudo,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,SitioWeb,Email,NumeroLiciencia,RegimenCostoId,IdiomaId,AsociacionId,TarifaAnualId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Instituciones instituciones, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)
            {
                //Sube las imagenes y las guarda en disco
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    var nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(uploadFile.FileName);
                    string pathArchivo = Server.MapPath("~/images/");
                    instituciones.Escudo = nombreArchivo;
                    uploadFile.SaveAs(Path.Combine(pathArchivo, nombreArchivo));
                }

                db.Instituciones.Add(instituciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Nombre", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Nombre", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Nombre", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Nombre", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Nombre", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Nombre", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Nombre", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Nombre", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Nombre", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Nombre", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Nombre", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Nombre", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Nombre", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Nombre", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Nombre", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Nombre", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Nombre", instituciones.ZonaId);
            return View(instituciones);
        }

        // GET: Instituciones/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituciones instituciones = db.Instituciones.Find(id);
            if (instituciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Nombre", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Nombre", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Nombre", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Nombre", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Nombre", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Nombre", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Nombre", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Nombre", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Nombre", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Nombre", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Nombre", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Nombre", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Nombre", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Nombre", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Nombre", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Nombre", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Nombre", instituciones.ZonaId);
            return View(instituciones);
        }

        // POST: Instituciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CodigoDane,Nombre,Nit,NombreRector,CalendarioId,TipoSectorEducacionId,PropiedadJuridicaId,NumeroSedes,NucleoId,GeneroId,Subsidio,DiscapacidadesId,CapacidadesExcepcionalesId,EtniasId,ResguardosId,NovedadId,MetodologiaId,PrestadorServicioId,DecretoCreacion,Director,Secretaria,Aprobacion,Lema,Escudo,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,SitioWeb,Email,NumeroLiciencia,RegimenCostoId,IdiomaId,AsociacionId,TarifaAnualId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Instituciones instituciones, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)
            {
                //Sube las imagenes y las guarda en disco
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    var nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(uploadFile.FileName);                    
                    string pathArchivo = Server.MapPath("~/images/");
                    instituciones.Escudo = nombreArchivo;
                    uploadFile.SaveAs(Path.Combine(pathArchivo, nombreArchivo));
                }

                db.Entry(instituciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "CodNombreigo", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Nombre", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Nombre", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Nombre", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Nombre", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nombre", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Nombre", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Nombre", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Nombre", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Nombre", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Nombre", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Nombre", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Nombre", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Nombre", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Nombre", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Nombre", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Nombre", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Nombre", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Nombre", instituciones.ZonaId);
            return View(instituciones);
        }

        // GET: Instituciones/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituciones instituciones = db.Instituciones.Find(id);
            if (instituciones == null)
            {
                return HttpNotFound();
            }
            return View(instituciones);
        }

        // POST: Instituciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Instituciones instituciones = db.Instituciones.Find(id);
            db.Instituciones.Remove(instituciones);
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
