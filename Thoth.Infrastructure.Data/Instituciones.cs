//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thoth.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instituciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instituciones()
        {
            this.Estudiantes = new HashSet<Estudiantes>();
        }
    
        public long Id { get; set; }
        public string CodigoDane { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string NombreRector { get; set; }
        public long CalendarioId { get; set; }
        public long TipoSectorEducacionId { get; set; }
        public long PropiedadJuridicaId { get; set; }
        public int NumeroSedes { get; set; }
        public long NucleoId { get; set; }
        public long GeneroId { get; set; }
        public bool Subsidio { get; set; }
        public long DiscapacidadesId { get; set; }
        public long CapacidadesExcepcionalesId { get; set; }
        public long EtniasId { get; set; }
        public long ResguardosId { get; set; }
        public long NovedadId { get; set; }
        public long MetodologiaId { get; set; }
        public long PrestadorServicioId { get; set; }
        public string DecretoCreacion { get; set; }
        public string Director { get; set; }
        public string Secretaria { get; set; }
        public string Aprobacion { get; set; }
        public string Lema { get; set; }
        public string Escudo { get; set; }
        public long DepartamentoId { get; set; }
        public long MunicipioId { get; set; }
        public long ZonaId { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string SitioWeb { get; set; }
        public string Email { get; set; }
        public string NumeroLiciencia { get; set; }
        public long RegimenCostoId { get; set; }
        public long IdiomaId { get; set; }
        public long AsociacionId { get; set; }
        public long TarifaAnualId { get; set; }
        public bool Activo { get; set; }
        public Nullable<long> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<long> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual AsociacionPrivadas AsociacionPrivadas { get; set; }
        public virtual Calendarios Calendarios { get; set; }
        public virtual CapacidadExcepcionales CapacidadExcepcionales { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
        public virtual Etnias Etnias { get; set; }
        public virtual Generos Generos { get; set; }
        public virtual Idiomas Idiomas { get; set; }
        public virtual Metodologias Metodologias { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual Nucleos Nucleos { get; set; }
        public virtual Prestadores Prestadores { get; set; }
        public virtual PropiedadJuridicas PropiedadJuridicas { get; set; }
        public virtual RegimenCostos RegimenCostos { get; set; }
        public virtual Resguardos Resguardos { get; set; }
        public virtual TarifaAnuales TarifaAnuales { get; set; }
        public virtual TipoDiscapacidades TipoDiscapacidades { get; set; }
        public virtual TipoNovedades TipoNovedades { get; set; }
        public virtual TipoSectorEducaciones TipoSectorEducaciones { get; set; }
        public virtual Zonas Zonas { get; set; }
    }
}
