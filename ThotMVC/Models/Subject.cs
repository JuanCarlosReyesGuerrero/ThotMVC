using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 SubjectId { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código de la asignatura")]
        [StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre de la asignatura")]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Sede")]
        [Required(ErrorMessage = "Seleccionar una sede")]
        [ForeignKey("Headquarters")]
        public Int64 HeadquartersId { get; set; }

        [Display(Name = "Estado")]
        public bool Status { get; set; }

        public Int64? UserRegister { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? RegistrationDate { get; set; }

        public Int64? UserModifies { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateModifies { get; set; }

        public virtual Headquarters Headquarters { get; set; }
    }
}