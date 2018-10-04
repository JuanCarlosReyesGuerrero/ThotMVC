using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThotMVC.Models
{
    public class Headquarters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 HeadquartersId { get; set; }

        [Display(Name = "Código")]
        public Int64 Codigo { get; set; }

        [Display(Name = "Código Dane nuevo")]
        [Required(ErrorMessage = "Digite el código Dane nuevo")]
        public String CodigoDaneNuevo { get; set; }

        [Display(Name = "Código Dane antiguo")]
        [Required(ErrorMessage = "Digite el código Dane antiguo")]
        public String CodigoDaneAntiguo { get; set; }

        [Display(Name = "Código consecutivo")]
        [Required(ErrorMessage = "Digite el código consecutivo")]
        public String CodigoConsecutivo { get; set; }

        [Display(Name = "Nombre Sede")]
        [Required(ErrorMessage = "Digite el nombre de la sede")]
        public String Nombre { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Seleccionar un departamento")]
        [ForeignKey("Department")]
        public Int64 DepartmentId { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Seleccionar un municipio")]
        [ForeignKey("Municipality")]
        public Int64 MunicipalityId { get; set; }

        [Display(Name = "Zona")]
        [Required(ErrorMessage = "Seleccionar una zona")]
        [ForeignKey("Zona")]
        public Int64 ZonaId { get; set; }

        [Display(Name = "Barrio")]
        public String Barrio { get; set; }

        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }

        [Display(Name = "Fax")]
        public String Fax { get; set; }

        [Display(Name = "Correo Electrónico")]
        public String Email { get; set; }

        [Display(Name = "Novedad")]
        public String Novedad { get; set; }

        [Display(Name = "Jornada Completa")]
        public Boolean JornadaCompleta { get; set; }

        [Display(Name = "Jornada Mañana")]
        public Boolean JornadaManana { get; set; }

        [Display(Name = "Jornada Tarde")]
        public Boolean JornadaTarde { get; set; }

        [Display(Name = "Jornada Noche")]
        public Boolean JornadaNoche { get; set; }

        [Display(Name = "Jornada Fin de Semana")]
        public Boolean JornadaFinSemana { get; set; }

        [Display(Name = "Especialidad")]
        [Required(ErrorMessage = "Seleccionar una especialidad")]
        [ForeignKey("Especialidad")]
        public Int64 EspecialidadId { get; set; }

        [Display(Name = "Fecha Creación")]
        [Required(ErrorMessage = "Seleccionar la fecha de creación")]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Nombre del director")]
        public String Director { get; set; }

        [Display(Name = "Nombre de la secretaria")]
        public String Secretaria { get; set; }

        [Display(Name = "Escala valoración nacional")]
        public Boolean EscalaValoracionNacional { get; set; }

        [Display(Name = "Rango numérico")]
        public Boolean RangoNumerico { get; set; }

        [Display(Name = "Número inicial")]
        public Int32 NumeroInicial { get; set; }

        [Display(Name = "Número final")]
        public Int32 NumeroFinal { get; set; }

        [Display(Name = "Valoración letras")]
        public Boolean ValoracionLetras { get; set; }

        [Display(Name = "Juicios")]
        public Boolean Juicios { get; set; }

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

        public virtual Department Department { get; set; }
        public virtual Municipality Municipality { get; set; }
        public virtual Zona Zona { get; set; }
        public virtual Especialidad Especialidad { get; set; }
    }
}