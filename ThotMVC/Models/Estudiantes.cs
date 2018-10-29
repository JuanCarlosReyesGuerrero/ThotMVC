using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Estudiantes
    {

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

        [Display(Name = "Tipo identificación")]
        [Required(ErrorMessage = "Seleccionar Tipo Identificacion")]
        [ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionId { get; set; }

        [Display(Name = "Numero Documento")]
        [Required(ErrorMessage = "Digite el número de documento")]
        public string NumeroDocumento { get; set; }

        [Display(Name = "Departamento Expedicion")]
        [Required(ErrorMessage = "Seleccionar Departamento Expedicion")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoExpedicionId { get; set; }

        [Display(Name = "Municipio Expedicion")]
        [Required(ErrorMessage = "Seleccionar Municipio Expedicion")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioExpedicionId { get; set; }

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

        [Display(Name = "Fecha nacimiento")]
        [Required(ErrorMessage = "Digite la fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Departamento Nacimiento")]
        [Required(ErrorMessage = "Seleccionar Departamento Nacimiento")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoNacimientoId { get; set; }

        [Display(Name = "Municipio Nacimiento")]
        [Required(ErrorMessage = "Seleccionar Municipio Nacimiento")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioNacimientoId { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Seleccionar Genero")]
        [ForeignKey("Generos")]
        public Int64 GeneroId { get; set; }

        [Display(Name = "Factor Rh")]
        [Required(ErrorMessage = "Seleccionar Factor Rh")]
        [ForeignKey("FactorRhs")]
        public Int64 FactorRhId { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Digite el Email")]
        public string Email { get; set; }

        [Display(Name = "Fotografia")]
        public string Fotografia { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Digite el Direccion")]
        public string Direccion { get; set; }

        [Display(Name = "Departamento Residencia")]
        [Required(ErrorMessage = "Seleccionar Departamento Residencia")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoResidenciaId { get; set; }

        [Display(Name = "Municipio Residencia")]
        [Required(ErrorMessage = "Seleccionar Municipio Residencia")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioResidenciaId { get; set; }

        [Display(Name = "Zona Residencia")]
        [Required(ErrorMessage = "Seleccionar Zona Residencia")]
        //[ForeignKey("Zonas")]
        public Int64 ZonaResidenciaId { get; set; }

        [Display(Name = "Localidad")]
        [Required(ErrorMessage = "Digite la localidad")]
        public string Localidad { get; set; }

        [Display(Name = "Barrio")]
        [Required(ErrorMessage = "Digite el Barrio")]
        public string Barrio { get; set; }

        [Display(Name = "Estrato")]
        [Required(ErrorMessage = "Seleccionar Estrato")]
        [ForeignKey("Estratos")]
        public Int64 EstratoId { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Digite el teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Digite el celular")]
        public string Celular { get; set; }

        [Display(Name = "Sisben")]
        [Required(ErrorMessage = "Seleccionar Sisben")]
        [ForeignKey("Sisbenes")]
        public Int64 SisbenId { get; set; }

        [Display(Name = "Numero Sisben")]
        [Required(ErrorMessage = "Digite el numero sisben")]
        public string NumeroSisben { get; set; }

        [Display(Name = "Eps")]
        [Required(ErrorMessage = "Seleccionar Eps")]
        [ForeignKey("Eps")]
        public Int64 EpsId { get; set; }

        [Display(Name = "Ars")]
        [Required(ErrorMessage = "Seleccionar ARS")]
        [ForeignKey("Ars")]
        public Int64 ArsId { get; set; }

        [Display(Name = "Poblacion Victima Conflictos")]
        [Required(ErrorMessage = "Seleccionar Poblacion Victima Conflictos")]
        [ForeignKey("PoblacionVictimaConflictos")]
        public Int64 PoblacionVictimaId { get; set; }

        [Display(Name = "Departamento Expulsor")]
        [Required(ErrorMessage = "Seleccionar Departamento Expulsor")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoExpulsorId { get; set; }

        [Display(Name = "Municipios Expulsor")]
        [Required(ErrorMessage = "Seleccionar Municipio  expulsor")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioExpulsorId { get; set; }

        [Display(Name = "Fecha expulsión")]
        public DateTime? FechaExpulsion { get; set; }

        [Display(Name = "Certificado Expulsion")]
        [Required(ErrorMessage = "Digite el certificado de expulsión")]
        public string CertificadoExpulsion { get; set; }

        [Display(Name = "Fecha Certificado Expulsión")]
        public DateTime? FechaCertificadoExpulsion { get; set; }

        [Display(Name = "Discapacidad")]
        [Required(ErrorMessage = "Seleccionar Discapacidad")]
        [ForeignKey("TipoDiscapacidades")]
        public Int64 DiscapacidadId { get; set; }

        [Display(Name = "Capacidad Excepcional")]
        [Required(ErrorMessage = "Seleccionar Capacidad Excepcional")]
        [ForeignKey("CapacidadExcepcionales")]
        public Int64 CapacidadExcepcionalId { get; set; }

        [Display(Name = "Etnia")]
        [Required(ErrorMessage = "Seleccionar Etnia")]
        [ForeignKey("Etnias")]
        public Int64 EtniaId { get; set; }

        [Display(Name = "Resguardo")]
        [Required(ErrorMessage = "Seleccionar Resguardo")]
        [ForeignKey("Resguardos")]
        public Int64 ResguardoId { get; set; }

        [Display(Name = "Proviene Sector Privado")]
        public bool ProvieneSectorPrivado { get; set; }

        [Display(Name = "Proviene Otro Municipio")]
        public bool ProvieneOtroMunicipio { get; set; }

        [Display(Name = "Institucion Bienestar")]
        [Required(ErrorMessage = "Digite el institución bienestar")]
        public string InstitucionBienestar { get; set; }

        [Display(Name = "Tipo Identificacion Madre")]
        [Required(ErrorMessage = "Seleccionar Tipo Identificacion Madre")]
        //[ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionMadreId { get; set; }

        [Display(Name = "Numero Documento Madre")]
        [Required(ErrorMessage = "Digite el numero documento madre")]
        public string NumeroDocumentoMadre { get; set; }

        [Display(Name = "Departamento Expedicion Madre")]
        [Required(ErrorMessage = "Seleccionar Departamento Expedicion Madre")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoExpedicionMadreId { get; set; }

        [Display(Name = "Municipio Expedicion Madre")]
        [Required(ErrorMessage = "Seleccionar Municipio Expedicion Madre")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioExpedicionMadreId { get; set; }

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

        [Display(Name = "Departamento Residencia Madre")]
        [Required(ErrorMessage = "Seleccionar Departamento Residencia Madre")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoResidenciaMadreId { get; set; }

        [Display(Name = "Municipio Residencia Madre")]
        [Required(ErrorMessage = "Seleccionar Municipio Residencia Madre")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioResidenciaMadreId { get; set; }

        [Display(Name = "Zona Residencia Madre")]
        [Required(ErrorMessage = "Seleccionar Zona Residencia Madred")]
        //[ForeignKey("Zonas")]
        public Int64 ZonaResidenciaMadreId { get; set; }

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

        [Display(Name = "Tipo Identificacion Padre")]
        [Required(ErrorMessage = "Seleccionar Tipo Identificacion Padre")]
        //[ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionPadreId { get; set; }

        [Display(Name = "Numero Documento Padre")]
        [Required(ErrorMessage = "Digite el Numero Documento Padre")]
        public string NumeroDocumentoPadre { get; set; }

        [Display(Name = "Departamento Expedicion Padre")]
        [Required(ErrorMessage = "Seleccionar Departamento Expedicion Padre")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoExpedicionPadreId { get; set; }

        [Display(Name = "Municipio Expedicion Padre")]
        [Required(ErrorMessage = "Seleccionar Municipio Expedicion Padre")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioExpedicionPadreId { get; set; }

        [Display(Name = "Primer Apellido Padre")]
        [Required(ErrorMessage = "Digite el Primer Apellido Padre")]
        public string PrimerApellidoPadre { get; set; }

        [Display(Name = "Segindo Apellido Padre")]
        [Required(ErrorMessage = "Digite el Segundo Apellido Padre")]
        public string SegundoApellidoPadre { get; set; }

        [Display(Name = "Primer Nombre Padre")]
        [Required(ErrorMessage = "Digite el Primer Nombre Padre")]
        public string PrimerNombrePadre { get; set; }

        [Display(Name = "Segundo Nombre Padre")]
        [Required(ErrorMessage = "Digite el Segundo Nombre Padre")]
        public string SegundoNombrePadre { get; set; }

        [Display(Name = "EmailPadre")]
        [Required(ErrorMessage = "Digite el EmailPadre")]
        public string EmailPadre { get; set; }

        [Display(Name = "DireccionPadre")]
        [Required(ErrorMessage = "Digite el DireccionPadre")]
        public string DireccionPadre { get; set; }

        [Display(Name = "Departamento Residencia Padre")]
        [Required(ErrorMessage = "Seleccionar Departamento Residencia Padre")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoResidenciaPadreId { get; set; }

        [Display(Name = "Municipio Residencia Padre")]
        [Required(ErrorMessage = "Seleccionar Municipio Residencia Padre")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioResidenciaPadreId { get; set; }

        [Display(Name = "Zona Resicencia Padre")]
        [Required(ErrorMessage = "Seleccionar Zona Resicencia Padre")]
        //[ForeignKey("Zonas")]
        public Int64 ZonaResicenciaPadreId { get; set; }

        [Display(Name = "BarrioPadre")]
        [Required(ErrorMessage = "Digite el BarrioPadre")]
        public string BarrioPadre { get; set; }

        [Display(Name = "Localidadpadre")]
        [Required(ErrorMessage = "Digite el Localidadpadre")]
        public string Localidadpadre { get; set; }

        [Display(Name = "TelefonoPadre")]
        [Required(ErrorMessage = "Digite el TelefonoPadre")]
        public string TelefonoPadre { get; set; }

        [Display(Name = "CelularPadre")]
        [Required(ErrorMessage = "Digite el CelularPadre")]
        public string CelularPadre { get; set; }

        [Display(Name = "OcupacionPadre")]
        [Required(ErrorMessage = "Digite el OcupacionPadre")]
        public string OcupacionPadre { get; set; }

        [Display(Name = "EmpresaPadre")]
        [Required(ErrorMessage = "Digite el EmpresaPadre")]
        public string EmpresaPadre { get; set; }

        [Display(Name = "TelefonoEmpresaPadre")]
        [Required(ErrorMessage = "Digite el TelefonoEmpresaPadre")]
        public string TelefonoEmpresaPadre { get; set; }

        [Display(Name = "Tipo Identificacion Acudiente")]
        [Required(ErrorMessage = "Seleccionar Tipo Identificacion Acudiente")]
        //[ForeignKey("TipoIdentificaciones")]
        public Int64 TipoIdentificacionAcudienteId { get; set; }

        [Display(Name = "NumeroDocumentoAcudiente")]
        [Required(ErrorMessage = "Digite el NumeroDocumentoAcudiente")]
        public string NumeroDocumentoAcudiente { get; set; }

        [Display(Name = "Departamento Expedicion Acudiente")]
        [Required(ErrorMessage = "Seleccionar Departamento Expedicion Acudiente")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoExpedicionAcudienteId { get; set; }

        [Display(Name = "Municipio Expedicion Acudiente")]
        [Required(ErrorMessage = "Seleccionar Municipio Expedicion Acudiente")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioExpedicionAcudiente { get; set; }

        [Display(Name = "PrimerApellidoAcudiente")]
        [Required(ErrorMessage = "Digite el PrimerApellidoAcudiente")]
        public string PrimerApellidoAcudiente { get; set; }

        [Display(Name = "SegundoApellidoAcudiente")]
        [Required(ErrorMessage = "Digite el SegundoApellidoAcudiente")]
        public string SegundoApellidoAcudiente { get; set; }

        [Display(Name = "PrimerNombreAcudiente")]
        [Required(ErrorMessage = "Digite el PrimerNombreAcudiente")]
        public string PrimerNombreAcudiente { get; set; }

        [Display(Name = "SegundoNombreAcudiente")]
        [Required(ErrorMessage = "Digite el SegundoNombreAcudiente")]
        public string SegundoNombreAcudiente { get; set; }

        [Display(Name = "EmailAcudiente")]
        [Required(ErrorMessage = "Digite el EmailAcudiente")]
        public string EmailAcudiente { get; set; }

        [Display(Name = "DireccionAcudiente")]
        [Required(ErrorMessage = "Digite el DireccionAcudiente")]
        public string DireccionAcudiente { get; set; }

        [Display(Name = "Departamento Residencia Acudiente")]
        [Required(ErrorMessage = "Seleccionar Departamento Residencia Acudiente")]
        //[ForeignKey("Departamentos")]
        public Int64 DepartamentoResidenciaAcudienteId { get; set; }

        [Display(Name = "Municipio Residencia Acudiente")]
        [Required(ErrorMessage = "Seleccionar Municipio Residencia Acudiente")]
        //[ForeignKey("Municipios")]
        public Int64 MunicipioResidenciaAcudienteId { get; set; }

        [Display(Name = "Zona Residencia Acudiente")]
        [Required(ErrorMessage = "Seleccionar Zona Residencia Acudiente")]
        //[ForeignKey("Zonas")]
        public Int64 ZonaResidenciaAcudienteId { get; set; }

        [Display(Name = "BarrioAcudiente")]
        [Required(ErrorMessage = "Digite el BarrioAcudiente")]
        public string BarrioAcudiente { get; set; }

        [Display(Name = "LocalidadAcudiente")]
        [Required(ErrorMessage = "Digite el LocalidadAcudiente")]
        public string LocalidadAcudiente { get; set; }

        [Display(Name = "TelefonoAcudiente")]
        [Required(ErrorMessage = "Digite el TelefonoAcudiente")]
        public string TelefonoAcudiente { get; set; }

        [Display(Name = "CelularAcudiente")]
        [Required(ErrorMessage = "Digite el CelularAcudiente")]
        public string CelularAcudiente { get; set; }

        [Display(Name = "OcupacionAcudiente")]
        [Required(ErrorMessage = "Digite el OcupacionAcudiente")]
        public string OcupacionAcudiente { get; set; }

        [Display(Name = "EmpresaAcudiente")]
        [Required(ErrorMessage = "Digite el EmpresaAcudiente")]
        public string EmpresaAcudiente { get; set; }

        [Display(Name = "TelefonoEmpresaAcudiente")]
        [Required(ErrorMessage = "Digite el TelefonoEmpresaAcudiente")]
        public string TelefonoEmpresaAcudiente { get; set; }

        [Display(Name = "Genero Acudiente")]
        [Required(ErrorMessage = "Seleccionar Genero Acudiente")]
        //[ForeignKey("Generos")]
        public Int64 GeneroAcudienteId { get; set; }

        [Display(Name = "Parentesco Acudiente")]
        [Required(ErrorMessage = "Seleccionar Parentesco Acudiente")]
        [ForeignKey("Parentescos")]
        public Int64 ParentescoAcudienteId { get; set; }

        [Display(Name = "ColegioUltimoCurso")]
        [Required(ErrorMessage = "Digite el ColegioUltimoCurso")]
        public string ColegioUltimoCurso { get; set; }

        [Display(Name = "DireccionColegioUltimoCurso")]
        [Required(ErrorMessage = "Digite el DireccionColegioUltimoCurso")]
        public string DireccionColegioUltimoCurso { get; set; }

        [Display(Name = "TelefonoColegioUltimoCurso")]
        [Required(ErrorMessage = "Digite el TelefonoColegioUltimoCurso")]
        public string TelefonoColegioUltimoCurso { get; set; }

        [Display(Name = "UltimoGrado")]
        [Required(ErrorMessage = "Digite el UltimoGrado")]
        public string UltimoGrado { get; set; }

        [Display(Name = "Anio")]
        [Required(ErrorMessage = "Digite el Anio")]
        public string Anio { get; set; }

        [Display(Name = "MotivoRetiroUltimo")]
        [Required(ErrorMessage = "Digite el MotivoRetiroUltimo")]
        public string MotivoRetiroUltimo { get; set; }

        [Display(Name = "Observaciones")]
        [Required(ErrorMessage = "Digite el Observaciones")]
        public string Observaciones { get; set; }

        [Display(Name = "UsuarioEstudiante")]
        [Required(ErrorMessage = "Digite el UsuarioEstudiante")]
        public string UsuarioEstudiante { get; set; }

        [Display(Name = "ClaveAcceso")]
        [Required(ErrorMessage = "Digite el ClaveAcceso")]
        public string ClaveAcceso { get; set; }

        [Display(Name = "Grupo")]
        [Required(ErrorMessage = "Seleccionar grupo")]
        [ForeignKey("Grupos")]
        public Int64 GrupoUsuarioId { get; set; }

        [Display(Name = "Sedes")]
        [Required(ErrorMessage = "Seleccionar sedes")]
        [ForeignKey("Sedes")]
        public Int64 SedeId { get; set; }

        [Display(Name = "Institución")]
        [Required(ErrorMessage = "Seleccionar institución")]
        [ForeignKey("Instituciones")]
        public Int64 InstitucionId { get; set; }

        [Display(Name = "SeleccioneMadre")]
        [Required(ErrorMessage = "Digite el SeleccioneMadre")]
        public bool SeleccioneMadre { get; set; }

        [Display(Name = "SeleccionePadre")]
        [Required(ErrorMessage = "Digite el SeleccionePadre")]
        public bool SeleccionePadre { get; set; }


        //[SeleccioneAcudiente] [bigint] NULL,

            
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

        public virtual Ars Ars { get; set; }
        public virtual CapacidadExcepcionales CapacidadExcepcionales { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        public virtual Eps Eps { get; set; }
        public virtual Estratos Estratos { get; set; }
        public virtual Etnias Etnias { get; set; }
        public virtual FactorRhs FactorRhs { get; set; }
        public virtual Generos Generos { get; set; }
        public virtual Grupos Grupos { get; set; }
        public virtual Instituciones Instituciones { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual Parentescos Parentescos { get; set; }
        public virtual PoblacionVictimaConflictos PoblacionVictimaConflictos { get; set; }
        public virtual Resguardos Resguardos { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual Sisbenes Sisbenes { get; set; }
        public virtual TipoDiscapacidades TipoDiscapacidades { get; set; }
        public virtual TipoIdentificaciones TipoIdentificaciones { get; set; }
        public virtual Zonas Zonas { get; set; }
    }
}