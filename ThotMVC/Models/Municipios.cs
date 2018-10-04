using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Municipios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 MunicipioId { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código del municipio")]
        public string MunicipioCodigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre del municipio")]
        public string MunicipioNombre { get; set; }

        [Display(Name = "Código unificado")]
        [Required(ErrorMessage = "Digite el nombre del código unificado")]
        public string MunicipioCodigoUnificado { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Seleccionar un departamento")]
        [ForeignKey("Departamento")]
        public Int64 DepartamentoId { get; set; }
        public string DepartamentoCodigo { get; set; }

        [Display(Name = "Estado")]
        public bool MunicipioActivo { get; set; }

        public Int64? MunicipioUsuarioRegistra { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? MunicipioFechaRegistro { get; set; }

        public Int64? MunicipioUsuarioModifica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? MunicipioFechaModifica { get; set; }

        public virtual Departamentos Departamento { get; set; }
    }
}