using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Materias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código de la materia")]
        public Int64 Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre de la materia")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Intensidad horaria")]
        [Required(ErrorMessage = "Digite la intensidad horaria")]
        public int IntensidadHoraria { get; set; }

        [Display(Name = "Orden")]
        [Required(ErrorMessage = "Digite el órden")]
        public int Orden { get; set; }

        [Display(Name = "Clasificacion")]
        [Required(ErrorMessage = "Seleccionar una clasificacion")]
        [ForeignKey("Clasificaciones")]
        public Int64 ClasificacionId { get; set; }

        [Display(Name = "Profesor")]
        [Required(ErrorMessage = "Seleccionar un Profesor")]
        [ForeignKey("Profesores")]
        public Int64 ProfesorId { get; set; }

        [Display(Name = "Grado")]
        [Required(ErrorMessage = "Seleccionar un grado")]
        [ForeignKey("Grados")]
        public Int64 GradoId { get; set; }

        [Display(Name = "Grupo")]
        [Required(ErrorMessage = "Seleccionar un grupo")]
        [ForeignKey("Grupos")]
        public Int64 GrupoId { get; set; }

        [Display(Name = "Jornada")]
        [Required(ErrorMessage = "Seleccionar un jornada")]
        [ForeignKey("Jornadas")]
        public Int64 JornadaId { get; set; }

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

        public virtual Clasificaciones Clasificaciones { get; set; }
        public virtual Profesores Profesores { get; set; }
        public virtual Grados Grados { get; set; }
        public virtual Grupos Grupos { get; set; }
        public virtual Jornadas Jornadas { get; set; }
        public virtual Sedes Sedes { get; set; }        
    }
}