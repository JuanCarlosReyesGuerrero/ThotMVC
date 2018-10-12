using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Equivalencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código de la equivalencia")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre de la equivalencia")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Rango numerico")]
        [Required(ErrorMessage = "Digite el rango numerico")]
        public string EquivalenciaRangoNumerico { get; set; }

        [Display(Name = "Valor Letra")]
        [Required(ErrorMessage = "Seleccionar un valor de letras")]
        [ForeignKey("ValoracionLetras")]
        public Int64 ValoracionLetraId { get; set; }

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

        public virtual ValoracionLetras ValoracionLetras { get; set; }
        public virtual Sedes Sedes { get; set; }        
    }
}