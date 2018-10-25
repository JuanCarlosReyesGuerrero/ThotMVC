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
            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Codigo");
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Codigo");
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Codigo");
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo");
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Codigo");
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Codigo");
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo");
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Codigo");
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Codigo");
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Codigo");
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Codigo");
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Codigo");
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Codigo");
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo");
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Codigo");
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Codigo");
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo");
            return View();
        }

        // POST: Instituciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CodigoDane,Nombre,Nit,NombreRector,CalendarioId,TipoSectorEducacionId,PropiedadJuridicaId,NumeroSedes,NucleoId,GeneroId,Subsidio,DiscapacidadesId,CapacidadesExcepcionalesId,EtniasId,ResguardosId,NovedadId,MetodologiaId,PrestadorServicioId,DecretoCreacion,Director,Secretaria,Aprobacion,Lema,Escudo,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,SitioWeb,Email,NumeroLiciencia,RegimenCostoId,IdiomaId,AsociacionId,TarifaAnualId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Instituciones instituciones)
        {
            if (ModelState.IsValid)
            {
                db.Instituciones.Add(instituciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Codigo", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Codigo", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Codigo", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Codigo", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Codigo", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Codigo", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Codigo", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Codigo", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Codigo", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Codigo", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Codigo", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Codigo", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Codigo", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", instituciones.ZonaId);
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
            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Codigo", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Codigo", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Codigo", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Codigo", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Codigo", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Codigo", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Codigo", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Codigo", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Codigo", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Codigo", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Codigo", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Codigo", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Codigo", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", instituciones.ZonaId);
            return View(instituciones);
        }

        // POST: Instituciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CodigoDane,Nombre,Nit,NombreRector,CalendarioId,TipoSectorEducacionId,PropiedadJuridicaId,NumeroSedes,NucleoId,GeneroId,Subsidio,DiscapacidadesId,CapacidadesExcepcionalesId,EtniasId,ResguardosId,NovedadId,MetodologiaId,PrestadorServicioId,DecretoCreacion,Director,Secretaria,Aprobacion,Lema,Escudo,DepartamentoId,MunicipioId,ZonaId,Barrio,Direccion,Telefono,Fax,SitioWeb,Email,NumeroLiciencia,RegimenCostoId,IdiomaId,AsociacionId,TarifaAnualId,Activo,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica")] Instituciones instituciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instituciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AsociacionId = new SelectList(db.AsociacionPrivadas, "Id", "Codigo", instituciones.AsociacionId);
            ViewBag.CalendarioId = new SelectList(db.Calendarios, "Id", "Codigo", instituciones.CalendarioId);
            ViewBag.CapacidadesExcepcionalesId = new SelectList(db.CapacidadExcepcionales, "Id", "Codigo", instituciones.CapacidadesExcepcionalesId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", instituciones.DepartamentoId);
            ViewBag.EtniasId = new SelectList(db.Etnias, "Id", "Codigo", instituciones.EtniasId);
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Codigo", instituciones.GeneroId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "Id", "Codigo", instituciones.IdiomaId);
            ViewBag.MetodologiaId = new SelectList(db.Metodologias, "Id", "Codigo", instituciones.MetodologiaId);
            ViewBag.MunicipioId = new SelectList(db.Municipios, "Id", "Codigo", instituciones.MunicipioId);
            ViewBag.NucleoId = new SelectList(db.Nucleos, "Id", "Codigo", instituciones.NucleoId);
            ViewBag.PrestadorServicioId = new SelectList(db.Prestadores, "Id", "Codigo", instituciones.PrestadorServicioId);
            ViewBag.PropiedadJuridicaId = new SelectList(db.PropiedadJuridicas, "Id", "Codigo", instituciones.PropiedadJuridicaId);
            ViewBag.RegimenCostoId = new SelectList(db.RegimenCostos, "Id", "Codigo", instituciones.RegimenCostoId);
            ViewBag.ResguardosId = new SelectList(db.Resguardos, "Id", "Codigo", instituciones.ResguardosId);
            ViewBag.TarifaAnualId = new SelectList(db.TarifaAnuales, "Id", "Codigo", instituciones.TarifaAnualId);
            ViewBag.DiscapacidadesId = new SelectList(db.TipoDiscapacidades, "Id", "Codigo", instituciones.DiscapacidadesId);
            ViewBag.NovedadId = new SelectList(db.TipoNovedades, "Id", "Codigo", instituciones.NovedadId);
            ViewBag.TipoSectorEducacionId = new SelectList(db.TipoSectorEducaciones, "Id", "Codigo", instituciones.TipoSectorEducacionId);
            ViewBag.ZonaId = new SelectList(db.Zonas, "Id", "Codigo", instituciones.ZonaId);
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
