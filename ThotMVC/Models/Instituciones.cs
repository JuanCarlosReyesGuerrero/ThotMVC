using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Instituciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 InstitucionId { get; set; }

        [Display(Name = "Código Dane")]
        [Required(ErrorMessage = "Digete el código Dane")]
        public String InstitucionCodigoDane { get; set; }

        [Display(Name = "Nombre Institución")]
        [Required(ErrorMessage = "Digite el nombre de la institución")]
        public String InstitucionNombre { get; set; }

        [Display(Name = "NIT")]
        [Required(ErrorMessage = "Digite el nit de la institución")]
        public String InstitucionNit { get; set; }

        [Display(Name = "Nombre del rector")]
        [Required(ErrorMessage = "Digite el nombre del rector")]
        public String InstitucionNombreRector { get; set; }

        [Display(Name = "Calendario")]
        [Required(ErrorMessage = "Seleccionar el calendario")]
        [ForeignKey("Calendarios")]
        public Int64 CalendarioId { get; set; }

        [Display(Name = "Sector educación")]
        [Required(ErrorMessage = "Seleccionar el sector de educación")]
        [ForeignKey("TipoSectorEducaciones")]
        public Int64 TipoSectorEducacionId { get; set; }

        [Display(Name = "Propiedad jurídica")]
        [Required(ErrorMessage = "Seleccionar la propiedad jurídica")]
        [ForeignKey("PropiedadJuridicas")]
        public Int64 PropiedadJuridicaId { get; set; }

        [Display(Name = "Número de sedes")]
        public Int32 InstitucionNumeroSedes { get; set; }

        [Display(Name = "Nucleo")]
        [Required(ErrorMessage = "Seleccionar el núcleo")]
        [ForeignKey("Nucleos")]
        public Int64 NucleoId { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "Seleccionar el género")]
        [ForeignKey("Generos")]
        public Int64 GeneroId { get; set; }

        [Display(Name = "Subsidio")]
        public Boolean InstitucionSubsidio { get; set; }

        [Display(Name = "Discapacidad")]
        [Required(ErrorMessage = "Seleccionar la discapacidad")]
        [ForeignKey("TipoDiscapacidades")]
        public Int64 DiscapacidadesId { get; set; }

        [Display(Name = "Capacidades excepcionales")]
        [Required(ErrorMessage = "Seleccionar la capacidad excepcional")]
        [ForeignKey("CapacidadExcepcionales")]
        public Int64 CapacidadesExcepcionalesId { get; set; }

        [Display(Name = "Etnias")]
        [Required(ErrorMessage = "Seleccionar la etnia")]
        [ForeignKey("Etnias")]
        public Int64 EtniasId { get; set; }

        [Display(Name = "Resguardo")]
        [Required(ErrorMessage = "Seleccionar el resguardo")]
        [ForeignKey("Resguardos")]
        public Int64 ResguardosId { get; set; }

        [Display(Name = "Tipo de novedad")]
        [Required(ErrorMessage = "Seleccionar el tipo de novedad")]
        [ForeignKey("TipoNovedades")]
        public Int64 NovedadId { get; set; }

        [Display(Name = "Metodología")]
        [Required(ErrorMessage = "Seleccionar la metodología")]
        [ForeignKey("Metodologias")]
        public Int64 MetodologiaId { get; set; }

        [Display(Name = "Prestador de servicio")]
        [Required(ErrorMessage = "Seleccionar el prestador de servicio")]
        [ForeignKey("Prestadores")]
        public Int64 PrestadorServicioId { get; set; }

        [Display(Name = "Decreto de creación")]
        public String InstitucionDecretoCreacion { get; set; }

        [Display(Name = "Nombre del director")]
        public String InstitucionDirector { get; set; }

        [Display(Name = "Nombre de la secretaria")]
        public String InstitucionSecretaria { get; set; }

        [Display(Name = "Aprobación")]
        public String InstitucionAprobacion { get; set; }

        [Display(Name = "Lema")]
        public String InstitucionLema { get; set; }

        [Display(Name = "Archivo imagen del escudo")]
        public String InstitucionEscudo { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Seleccionar un departamento")]
        [ForeignKey("Departamentos")]
        public Int64 DepartamentoId { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Seleccionar un municipio")]
        [ForeignKey("Municipios")]
        public Int64 MunicipioId { get; set; }

        [Display(Name = "Zona")]
        [Required(ErrorMessage = "Seleccionar una zona")]
        [ForeignKey("Zonas")]
        public Int64 ZonaId { get; set; }

        [Display(Name = "Barrio")]
        public String InstitucionBarrio { get; set; }

        [Display(Name = "Dirección")]
        public String InstitucionDireccion { get; set; }

        [Display(Name = "teléfono")]
        public String InstitucionTelefono { get; set; }

        [Display(Name = "Fax")]
        public String InstitucionFax { get; set; }

        [Display(Name = "Sitio Web")]
        public String InstitucionSitioWeb { get; set; }

        [Display(Name = "Correo electrónico")]
        public String InstitucionEmail { get; set; }

        [Display(Name = "Número de liciencia")]
        public String InstitucionNumeroLiciencia { get; set; }

        [Display(Name = "Régimen de costos")]
        [Required(ErrorMessage = "Seleccionar el régimen de costos")]
        [ForeignKey("RegimenCostos")]
        public Int64 RegimenCostoId { get; set; }

        [Display(Name = "Idioma")]
        [Required(ErrorMessage = "Seleccionar el idioma")]
        [ForeignKey("Idiomas")]
        public Int64 IdiomaId { get; set; }

        [Display(Name = "Asociación Privada")]
        [Required(ErrorMessage = "Seleccionar la asociación que pertenece")]
        [ForeignKey("AsociacionPrivadas")]
        public Int64 AsociacionId { get; set; }

        [Display(Name = "Tarifa anual")]
        [Required(ErrorMessage = "Seleccionar la tarifa anual")]
        [ForeignKey("TarifaAnuales")]
        public Int64 TarifaAnualId { get; set; }

        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        public Int64? UsuarioRegistra { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }

        public Int64? UsuarioModifica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaModifica { get; set; }

        public virtual Calendarios Calendarios { get; set; }
        public virtual TipoSectorEducaciones TipoSectorEducaciones { get; set; }
        public virtual PropiedadJuridicas PropiedadJuridicas { get; set; }
        public virtual Nucleos Nucleos { get; set; }
        public virtual Generos Generos { get; set; }
        public virtual TipoDiscapacidades TipoDiscapacidades { get; set; }
        public virtual CapacidadExcepcionales CapacidadExcepcionales { get; set; }
        public virtual Etnias Etnias { get; set; }
        public virtual Resguardos Resguardos { get; set; }
        public virtual TipoNovedades TipoNovedades { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual Zonas Zonas { get; set; }
        public virtual Metodologias Metodologias { get; set; }
        public virtual Prestadores Prestadores { get; set; }
        public virtual RegimenCostos RegimenCostos { get; set; }
        public virtual Idiomas Idiomas { get; set; }
        public virtual AsociacionPrivadas AsociacionPrivadas { get; set; }
        public virtual TarifaAnuales TarifaAnuales { get; set; }


        //public virtual Municipio Municipio { get; set; }
        //public virtual Departamento Departamento { get; set; }
        //public virtual Zona Zona { get; set; }
        //public virtual PropiedadJuridica PropiedadJuridica { get; set; }
        //public virtual Nucleo Nucleo { get; set; }
        //public virtual Genero Genero { get; set; }
        //public virtual CapacidadExcepcional CapacidadExcepcional { get; set; }
        //public virtual Etnia Etnia { get; set; }
        //public virtual Resguardo Resguardo { get; set; }
        //public virtual Metodologia Metodologia { get; set; }
        //public virtual RegimenCosto RegimenCosto { get; set; }
        //public virtual Idioma Idioma { get; set; }
        //public virtual TarifaAnual TarifaAnual { get; set; }
        //public virtual TipoDiscapacidad TipoDiscapacidad { get; set; }
        //public virtual Calendario Calendario { get; set; }
        //public virtual TipoSectorEducacion TipoSectorEducacion { get; set; }
        //public virtual TipoNovedad TipoNovedad { get; set; }
        //public virtual Prestador Prestador { get; set; }
        //public virtual AsociacionPrivada AsociacionPrivada { get; set; }        
    }
}