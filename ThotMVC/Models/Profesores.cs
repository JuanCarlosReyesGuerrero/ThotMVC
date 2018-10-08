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
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código del profesor")]
        public Int64 Codigo { get; set; }        

        [Display(Name = "Tipo Identificacion")]
        [Required(ErrorMessage = "Seleccionar un tipo de identificación")]
        [ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionId { get; set; }

        [Display(Name = "Numero de documento")]
        [Required(ErrorMessage = "Digite el número del documento")]
        public string NumeroDocumento { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Digite el primer apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "Digite el segundo apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Digite el primer nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [Required(ErrorMessage = "Digite el segundo nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Digite la dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Digite el teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Profesion")]
        [Required(ErrorMessage = "Seleccionar una profesión")]
        [ForeignKey("Profesiones")]
        public Int64 ProfesionId { get; set; }

        [Display(Name = "Escalafon")]
        [Required(ErrorMessage = "Seleccionar una Escalafon")]
        [ForeignKey("Escalafones")]
        public Int64 EscalafonId { get; set; }

        [Display(Name = "Sede")]
        [Required(ErrorMessage = "Seleccionar una sede")]
        [ForeignKey("Sedes")]
        public Int64 SedeId { get; set; }        

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

        public virtual TipoIdentificaciones TipoIdentificaciones { get; set; }
        public virtual Profesiones Profesiones { get; set; }
        public virtual Escalafones Escalafones { get; set; }
        public virtual Sedes Sedes { get; set; }        
    }
}