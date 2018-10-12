using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Estudiantes
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código del estudiante")]
        public Int64 Codigo { get; set; }

       

        [Display(Name = "Codigo MEN")]
        [Required(ErrorMessage = "Digite el código MEN")]
        public string CodigoMEN { get; set; }


        [TipoIdentificacionId] [bigint] NULL,

	
             [Display(Name = "Numero Documento")]
        [Required(ErrorMessage = "Digite el número de documento")]
        public string NumeroDocumento { get; set; }

        [DepartamentoExpedicionId] [bigint] NULL,
	[MunicipioExpedicionId] [bigint] NULL,

	
             [Display(Name = "PrimerApellido")]
        [Required(ErrorMessage = "Digite el primer apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "Digite el segundo apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Digite el primer nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [Required(ErrorMessage = "Digite el segundo nombre")]
        public string SegundoNombre { get; set; }

        [EstudianteFechaNacimiento] [datetime] NULL,
	[DepartamentoNacimientoId] [bigint] NULL,
	[MunicipioNacimientoId] [bigint] NULL,
	[GeneroId] [bigint] NULL,
	[FactorRhId] [bigint] NULL,

	
             [Display(Name = "Email")]
        [Required(ErrorMessage = "Digite el Email")]
        public string Email { get; set; }

        [EstudianteFotografia] [image] NULL,

	
             [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Digite el Direccion")]
        public string Direccion { get; set; }

        [DepartamentoResidenciaId] [bigint] NULL,
	[MunicipioResidenciaId] [bigint] NULL,
	[ZonaResidenciaId] [bigint] NULL,

	
             [Display(Name = "Localidad")]
        [Required(ErrorMessage = "Digite la localidad")]
        public string Localidad { get; set; }

        [Display(Name = "Barrio")]
        [Required(ErrorMessage = "Digite el Barrio")]
        public string Barrio { get; set; }

        [EstratoId] [bigint] NULL,

	
             [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Digite el teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Digite el celular")]
        public string Celular { get; set; }

        [SisbenId] [bigint] NULL,

	
             [Display(Name = "Numero Sisben")]
        [Required(ErrorMessage = "Digite el numero sisben")]
        public string NumeroSisben { get; set; }

        [EpsId] [bigint] NULL,
	[ArsId] [bigint] NULL,
	[PoblacionVictimaId] [bigint] NULL,
	[DepartamentoExpulsorId] [bigint] NULL,
	[MunicipioExpulsorId] [bigint] NULL,
	[EstudianteFechaExpulsion] [datetime] NULL,

	
             [Display(Name = "Certificado Expulsion")]
        [Required(ErrorMessage = "Digite el certificado de expulsión")]
        public string CertificadoExpulsion { get; set; }

        [EstudianteFechaCertificadoExpulsion] [datetime] NULL,
	[DiscapacidadId] [bigint] NULL,
	[CapacidadExcepcionalId] [bigint] NULL,
	[EtniaId] [bigint] NULL,
	[ResguardoId] [bigint] NULL,
	[EstudianteProvieneSectorPrivado] [bit] NULL,
	[EstudianteProvieneOtroMunicipio] [bit] NULL,

	
             [Display(Name = "Institucion Bienestar")]
        [Required(ErrorMessage = "Digite el institución bienestar")]
        public string InstitucionBienestar { get; set; }

        [TipoIdentificacionMadreId] [bigint] NULL,


             [Display(Name = "Numero Documento Madre")]
        [Required(ErrorMessage = "Digite el numero documento madre")]
        public string NumeroDocumentoMadre { get; set; }

        [DepartamentoExpedicionMadreId] [bigint] NULL,
	[MunicipioExpedicionMadreId] [bigint] NULL,

	
             [Display(Name = "Primer Apellido Madre")]
        [Required(ErrorMessage = "Digite el primer apellido madre")]
        public string EstudiantePrimerApellidoMadre { get; set; }


        [Display(Name = " Segundo Apellido Madre")]
        [Required(ErrorMessage = "Digite el segundo apellido madre")]
        public string SegundoApellidoMadre { get; set; }


        [Display(Name = "Primer Nombre Madre")]
        [Required(ErrorMessage = "Digite el primer nombre madre")]
        public string PrimerNombreMadre { get; set; }


        [Display(Name = "Segundo Nombre Madre")]
        [Required(ErrorMessage = "Digite el segundo nombre madre")]
        public string EstudianteSegundoNombreMadre { get; set; }


        [Display(Name = "Email Madre")]
        [Required(ErrorMessage = "Digite el  email madre")]
        public string EmailMadre { get; set; }


        [Display(Name = "Direccion Madre")]
        [Required(ErrorMessage = "Digite el direccion madre")]
        public string DireccionMadre { get; set; }

        [DepartamentoResidenciaMadreId] [bigint] NULL,
	[MunicipioResidenciaMadreId] [bigint] NULL,
	[ZonaResidenciaMadreId] [bigint] NULL,

	
             [Display(Name = "Barrio Madre")]
        [Required(ErrorMessage = "Digite el barrio madre")]
        public string BarrioMadre { get; set; }


        [Display(Name = "Localidad Madre")]
        [Required(ErrorMessage = "Digite el  Localidad Madre")]
        public string LocalidadMadre { get; set; }


        [Display(Name = "Telefono Madre")]
        [Required(ErrorMessage = "Digite el Estudiante Telefono Madre")]
        public string TelefonoMadre { get; set; }


        [Display(Name = "Celular Madre")]
        [Required(ErrorMessage = "Digite el Celular Madre")]
        public string CelularMadre { get; set; }


        [Display(Name = "Ocupacion Madre")]
        [Required(ErrorMessage = "Digite el  Ocupacion Madre")]
        public string OcupacionMadre { get; set; }


        [Display(Name = "Empresa Madre")]
        [Required(ErrorMessage = "Digite el Estudiante Empresa Madre")]
        public string EmpresaMadre { get; set; }


        [Display(Name = "Telefono Empresa Madre")]
        [Required(ErrorMessage = "Digite el Telefono Empresa Madre")]
        public string TelefonoEmpresaMadre { get; set; }

        [TipoIdentificacionPadreId] [bigint] NULL,
	[EstudianteNumeroDocumentoPadre] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [DepartamentoExpedicionPadreId] [bigint] NULL,
	[MunicipioExpedicionPadreId] [bigint] NULL,
	[EstudiantePrimerApellidoPadre] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteSegindoApellidoPadre] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudiantePrimerNombrePadre] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteSegundoNombrePadre] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteEmailPadre] [nvarchar] (50) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteDireccionPadre] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [DepartamentoResidenciaPadreId] [bigint] NULL,
	[MunicipioResidenciaPadreId] [bigint] NULL,
	[ZonaResicenciaPadreId] [bigint] NULL,
	[EstudianteBarrioPadre] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteLocalidadpadre] [nvarchar] (100) NULL,
	[EstudianteTelefonoPadre] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteCelularPadre] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteOcupacionPadre] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteEmpresaPadre] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteTelefonoEmpresaPadre] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [TipoIdentificacionAcudienteId] [bigint] NULL,
	[EstudianteNumeroDocumentoAcudiente] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [DepartamentoExpedicionAcudienteId] [bigint] NULL,
	[MunicipioExpedicionAcudiente] [bigint] NULL,
	[EstudiantePrimerApellidoAcudiente] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteSegundoApellidoAcudiente] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudiantePrimerNombreAcudiente] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteSegundoNombreAcudiente] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteEmailAcudiente] [nvarchar] (50) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteDireccionAcudiente] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [DepartamentoResidenciaAcudienteId] [bigint] NULL,
	[MunicipioResidenciaAcudienteId] [bigint] NULL,
	[ZonaResidenciaAcudienteId] [bigint] NULL,
	[EstudianteBarrioAcudiente] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteLocalidadAcudiente] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteTelefonoAcudiente] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteCelularAcudiente] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteOcupacionAcudiente] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteEmpresaAcudiente] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteTelefonoEmpresaAcudiente] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [GeneroAcudienteId] [bigint] NULL,
	[ParentescoAcudienteId] [bigint] NULL,
	[EstudianteColegioUltimoCurso] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteDireccionColegioUltimoCurso] [nvarchar] (100) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteTelefonoColegioUltimoCurso] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteUltimoGrado] [nvarchar] (10) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteAnio] [nvarchar] (4) NULL,
	[EstudianteMotivoRetiroUltimo] [nvarchar] (255) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteObservaciones] [text] NULL,
	[EstudianteUsuarioEstudiante] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [EstudianteClaveAcceso] [nvarchar] (20) NULL,
             [Display(Name = "EstudianteCodigoMEN")]
        [Required(ErrorMessage = "Digite el EstudianteCodigoMEN")]
        public string EstudianteCodigoMEN { get; set; }

        [GrupoUsuarioId] [nvarchar] (2) NULL,
	[SedeId] [bigint] NULL,
	[InstitucionId] [bigint] NULL,
	[EstudianteSeleccioneMadre] [bit] NULL,
	[EstudianteSeleccionePadre] [bit] NULL,
	[EstudianteSeleccioneAcudiente] [int] NULL,
















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

        */
    }
}