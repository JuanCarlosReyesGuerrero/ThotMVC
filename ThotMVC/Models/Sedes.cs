using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Sedes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

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
        [ForeignKey("Departamentos")]
        public Int64 DepartamentoId { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Seleccionar un municipio")]
        [ForeignKey("Municipios")]
        public Int64 MunicipioId { get; set; }

        [Display(Name = "Zona")]
        [Required(ErrorMessage = "Seleccionar una zona")]
        [ForeignKey("Zonas")]
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
        [ForeignKey("Especialidades")]
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
        public virtual Zonas Zonas { get; set; }
        public virtual Especialidades Especialidades { get; set; }
    }
}