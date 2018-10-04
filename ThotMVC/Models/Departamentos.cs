using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Departamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 DepartamentoId { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código del departamento")]
        public string DepartamentoCodigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre del departamento")]
        public string DepartamentoNombre { get; set; }

        [Display(Name = "Estado")]
        public bool DepartamentoActivo { get; set; }

        public Int64? DepartamentoUsuarioRegistra { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DepartamentoFechaRegistro { get; set; }

        public Int64? DepartamentoUsuarioModifica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DepartamentoFechaModifica { get; set; }
    }
}