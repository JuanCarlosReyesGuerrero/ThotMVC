using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Nucleos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código del núcleo")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre del núcleo")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Seleccionar un departamento")]
        [ForeignKey("Departamentos")]
        public Int64 DepartamentoId { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Seleccionar un municipio")]
        [ForeignKey("Municipios")]
        public Int64 MunicipioId { get; set; }

        [Display(Name = "Nombre Director")]
        [Required(ErrorMessage = "Digite el nombre del director")]
        public string NombreDirector { get; set; }

        [Display(Name = "Teléfono director")]
        public string TelefonoDirector { get; set; }

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

        public virtual Departamentos Departamentos { get; set; }
        public virtual Municipios Municipios { get; set; }        
    }
}