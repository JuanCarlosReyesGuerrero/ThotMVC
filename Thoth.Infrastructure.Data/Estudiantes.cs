//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thoth.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiantes()
        {
            this.Matriculas = new HashSet<Matriculas>();
        }
    
        public long Id { get; set; }
        public long Codigo { get; set; }
        public string CodigoMEN { get; set; }
        public long TipoIdentificacionId { get; set; }
        public string NumeroDocumento { get; set; }
        public long DepartamentoExpedicionId { get; set; }
        public long MunicipioExpedicionId { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public long DepartamentoNacimientoId { get; set; }
        public long MunicipioNacimientoId { get; set; }
        public long GeneroId { get; set; }
        public long FactorRhId { get; set; }
        public string Email { get; set; }
        public string Fotografia { get; set; }
        public string Direccion { get; set; }
        public long DepartamentoResidenciaId { get; set; }
        public long MunicipioResidenciaId { get; set; }
        public long ZonaResidenciaId { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public long EstratoId { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public long SisbenId { get; set; }
        public string NumeroSisben { get; set; }
        public long EpsId { get; set; }
        public long ArsId { get; set; }
        public long PoblacionVictimaId { get; set; }
        public long DepartamentoExpulsorId { get; set; }
        public long MunicipioExpulsorId { get; set; }
        public Nullable<System.DateTime> FechaExpulsion { get; set; }
        public string CertificadoExpulsion { get; set; }
        public Nullable<System.DateTime> FechaCertificadoExpulsion { get; set; }
        public long DiscapacidadId { get; set; }
        public long CapacidadExcepcionalId { get; set; }
        public long EtniaId { get; set; }
        public long ResguardoId { get; set; }
        public bool ProvieneSectorPrivado { get; set; }
        public bool ProvieneOtroMunicipio { get; set; }
        public string InstitucionBienestar { get; set; }
        public long TipoIdentificacionMadreId { get; set; }
        public string NumeroDocumentoMadre { get; set; }
        public long DepartamentoExpedicionMadreId { get; set; }
        public long MunicipioExpedicionMadreId { get; set; }
        public string EstudiantePrimerApellidoMadre { get; set; }
        public string SegundoApellidoMadre { get; set; }
        public string PrimerNombreMadre { get; set; }
        public string EstudianteSegundoNombreMadre { get; set; }
        public string EmailMadre { get; set; }
        public string DireccionMadre { get; set; }
        public long DepartamentoResidenciaMadreId { get; set; }
        public long MunicipioResidenciaMadreId { get; set; }
        public long ZonaResidenciaMadreId { get; set; }
        public string BarrioMadre { get; set; }
        public string LocalidadMadre { get; set; }
        public string TelefonoMadre { get; set; }
        public string CelularMadre { get; set; }
        public string OcupacionMadre { get; set; }
        public string EmpresaMadre { get; set; }
        public string TelefonoEmpresaMadre { get; set; }
        public long TipoIdentificacionPadreId { get; set; }
        public string NumeroDocumentoPadre { get; set; }
        public long DepartamentoExpedicionPadreId { get; set; }
        public long MunicipioExpedicionPadreId { get; set; }
        public string PrimerApellidoPadre { get; set; }
        public string SegundoApellidoPadre { get; set; }
        public string PrimerNombrePadre { get; set; }
        public string SegundoNombrePadre { get; set; }
        public string EmailPadre { get; set; }
        public string DireccionPadre { get; set; }
        public long DepartamentoResidenciaPadreId { get; set; }
        public long MunicipioResidenciaPadreId { get; set; }
        public long ZonaResicenciaPadreId { get; set; }
        public string BarrioPadre { get; set; }
        public string Localidadpadre { get; set; }
        public string TelefonoPadre { get; set; }
        public string CelularPadre { get; set; }
        public string OcupacionPadre { get; set; }
        public string EmpresaPadre { get; set; }
        public string TelefonoEmpresaPadre { get; set; }
        public long TipoIdentificacionAcudienteId { get; set; }
        public string NumeroDocumentoAcudiente { get; set; }
        public long DepartamentoExpedicionAcudienteId { get; set; }
        public long MunicipioExpedicionAcudiente { get; set; }
        public string PrimerApellidoAcudiente { get; set; }
        public string SegundoApellidoAcudiente { get; set; }
        public string PrimerNombreAcudiente { get; set; }
        public string SegundoNombreAcudiente { get; set; }
        public string EmailAcudiente { get; set; }
        public string DireccionAcudiente { get; set; }
        public long DepartamentoResidenciaAcudienteId { get; set; }
        public long MunicipioResidenciaAcudienteId { get; set; }
        public long ZonaResidenciaAcudienteId { get; set; }
        public string BarrioAcudiente { get; set; }
        public string LocalidadAcudiente { get; set; }
        public string TelefonoAcudiente { get; set; }
        public string CelularAcudiente { get; set; }
        public string OcupacionAcudiente { get; set; }
        public string EmpresaAcudiente { get; set; }
        public string TelefonoEmpresaAcudiente { get; set; }
        public long GeneroAcudienteId { get; set; }
        public long ParentescoAcudienteId { get; set; }
        public string ColegioUltimoCurso { get; set; }
        public string DireccionColegioUltimoCurso { get; set; }
        public string TelefonoColegioUltimoCurso { get; set; }
        public string UltimoGrado { get; set; }
        public string Anio { get; set; }
        public string MotivoRetiroUltimo { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioEstudiante { get; set; }
        public string ClaveAcceso { get; set; }
        public long GrupoUsuarioId { get; set; }
        public long SedeId { get; set; }
        public long InstitucionId { get; set; }
        public bool SeleccioneMadre { get; set; }
        public bool SeleccionePadre { get; set; }
        public bool Activo { get; set; }
        public Nullable<long> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<long> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<long> Departamentos_Id { get; set; }
        public Nullable<long> Municipios_Id { get; set; }
        public Nullable<long> Zonas_Id { get; set; }
    
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matriculas> Matriculas { get; set; }
    }
}
