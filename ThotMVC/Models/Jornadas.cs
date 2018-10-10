using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Jornadas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código de la jornada")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre de la jornada")]
        public string Nombre { get; set; }

        [Display(Name = "Sede")]
        [Required(ErrorMessage = "Seleccione la sede")]
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

        public virtual Sedes Sedes { get; set; }
    }
}