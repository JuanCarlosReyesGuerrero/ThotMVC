using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Profesores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        [Column(Order = 0)]
        public Int64 Id { get; set; }

        [Display(Name = "Código *")]
        [Required(ErrorMessage = "Digite el código del profesor")]
        public string Codigo { get; set; }        

        [Display(Name = "Tipo Identificacion *")]
        [Required(ErrorMessage = "Seleccionar un tipo de identificación")]
        [ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionId { get; set; }

        [Display(Name = "Numero de documento *")]
        [Required(ErrorMessage = "Digite el número del documento")]
        public string NumeroDocumento { get; set; }

        [Display(Name = "Primer Apellido *")]
        [Required(ErrorMessage = "Digite el primer apellido")]
        //[StringLength(3, ErrorMessage = "El primer apellido no puede contener menos de 3 caracteres.")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        //[Required(ErrorMessage = "Digite el segundo apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Primer Nombre *")]
        [Required(ErrorMessage = "Digite el primer nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        //[Required(ErrorMessage = "Digite el segundo nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Direccion *")]
        [Required(ErrorMessage = "Digite la dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono *")]
        [Required(ErrorMessage = "Digite el teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Profesion *")]
        [Required(ErrorMessage = "Seleccionar una profesión")]
        [ForeignKey("Profesiones")]
        public Int64 ProfesionId { get; set; }

        [Display(Name = "Escalafon *")]
        [Required(ErrorMessage = "Seleccionar una Escalafon")]
        [ForeignKey("Escalafones")]
        public Int64 EscalafonId { get; set; }

        [Display(Name = "Sede *")]
        [Required(ErrorMessage = "Seleccionar una sede")]
        [ForeignKey("Sedes")]
        public Int64 SedeId { get; set; }

        [Display(Name = "Genero *")]
        [Required(ErrorMessage = "Seleccionar un género")]
        [ForeignKey("Generos")]
        public Int64? GeneroId { get; set; }

        [Display(Name = "Fecha nacimiento *")]
        [Required(ErrorMessage = "Digite la fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Lugar de nacimiento *")]
        [Required(ErrorMessage = "Digite el lugar de nacimiento")]
        public string LugarNacimiento { get; set; }

        [Display(Name = "Estado civil *")]
        [Required(ErrorMessage = "Seleccionar un estado civil")]
        [ForeignKey("EstadoCiviles")]
        public Int64? EstadoCivilId { get; set; }

        [Display(Name = "Número de hijos *")]
        [Required(ErrorMessage = "Digite el número de hijos")]
        public string NumeroHijos { get; set; }

        [Display(Name = "Fecha vinculación *")]
        [Required(ErrorMessage = "Digite la fecha de vinculación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaVinculacion { get; set; }

        [Display(Name = "Fecha retiro")]
        //[Required(ErrorMessage = "Digite la fecha de retiro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRetiro { get; set; }

        //hacr una mascara para la libreta
        [Display(Name = "Libreta militar (número - distrito - clase)")]
        //[Required(ErrorMessage = "Digite la libreta militar")]
        public string LibretaMilitar { get; set; }

        [Display(Name = "Resolución de nombramiento")]
        //[Required(ErrorMessage = "Digite la resolución de nombramiento")]
        public string ResolucionNombramiento { get; set; }

        [Display(Name = "Foto")]
        //[Required(ErrorMessage = "Subir la foto")]
        public string FotoPerfil { get; set; }

        //[Column(Order = 23)]
        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        //[Column(Order = 24)]
        public Int64? UsuarioRegistra { get; set; }

        //[Column(Order = 25)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }

        //[Column(Order = 26)]
        public Int64? UsuarioModifica { get; set; }

        //[Column(Order = 27)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaModifica { get; set; }

        [Display(Name = "Nombre completo")]
        public string nombreCompletoProfesor
        {
            get
            {
                return PrimerApellido + " " + SegundoApellido + " " + PrimerNombre + " " + SegundoNombre;
            }
        }

        public virtual TipoIdentificaciones TipoIdentificaciones { get; set; }
        public virtual Profesiones Profesiones { get; set; }
        public virtual Escalafones Escalafones { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual Generos Generos { get; set; }
        public virtual EstadoCiviles EstadoCiviles { get; set; }
    }
}