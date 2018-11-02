using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Matriculas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Estudiantes *")]
        [Required(ErrorMessage = "Seleccionar un estudiante")]
        [ForeignKey("Estudiantes")]
        public Int64 EstudianteId { get; set; }

        [Display(Name = "Edad al momento de la matrícula")]        
        public String EdadMatricula { get; set; }

        [Display(Name = "Número de matrícula *")]
        [Required(ErrorMessage = "Digite el número de la matrícula")]        
        public String NumeroMatricula { get; set; }

        [Display(Name = "Número de folio *")]
        [Required(ErrorMessage = "Digite el número del folio")]
        public String Numerofolio { get; set; }

        [Display(Name = "Fecha de la matrícula *")]
        [Required(ErrorMessage = "Digite la fecha de la matrícula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaMatricula { get; set; }

        [Display(Name = "Año matrícula *")]
        [Required(ErrorMessage = "Digite el año matrícula")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:MMM-yyyy}")]
        public DateTime AnioMatricula { get; set; }

        [Display(Name = "Grado *")]
        [Required(ErrorMessage = "Seleccionar un grado")]
        [ForeignKey("Grados")]
        public Int64 GradoId { get; set; }

        [Display(Name = "Grupo *")]
        [Required(ErrorMessage = "Seleccionar un grupo")]
        [ForeignKey("Grupos")]
        public Int64 GrupoId { get; set; }

        [Display(Name = "Jornada *")]
        [Required(ErrorMessage = "Seleccionar una jornada")]
        [ForeignKey("Jornadas")]
        public Int64 JornadaId { get; set; }

        [Display(Name = "Estado matricula *")]
        [Required(ErrorMessage = "Seleccionar un estado a la matrícula")]
        [ForeignKey("EstadoEstudiantes")]
        public Int64 EstadoMatricula { get; set; }

        [Display(Name = "Repitente *")]
        [Required(ErrorMessage = "Seleccionar si repite el año o no")]        
        public bool Repitente { get; set; }

        [Display(Name = "Tipo caracter, solo aplica para el nicel média (grado 10,11,12,13) *")]
        [Required(ErrorMessage = "Seleccionar tipo caracter")]
        [ForeignKey("TipoCaracteres")]
        public Int64 TipoCaracterId { get; set; }

        [Display(Name = "Sede *")]
        [Required(ErrorMessage = "Seleccionar sede")]
        [ForeignKey("Sedes")]
        public Int64 SedeId { get; set; }

        [Display(Name = "Observaciones")]
        public bool Observaciones { get; set; }

        public virtual Estudiantes Estudiantes { get; set; }
        public virtual Grados Grados { get; set; }
        public virtual Grupos Grupos { get; set; }
        public virtual Jornadas Jornadas { get; set; }
        public virtual TipoCaracteres TipoCaracteres { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual EstadoEstudiantes EstadoEstudiantes { get; set; }
    }
}