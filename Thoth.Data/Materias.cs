//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thoth.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Materias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materias()
        {
            this.Juicios = new HashSet<Juicios>();
        }
    
        public long Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IntensidadHoraria { get; set; }
        public int Orden { get; set; }
        public long ClasificacionId { get; set; }
        public long ProfesorId { get; set; }
        public long GradoId { get; set; }
        public long GrupoId { get; set; }
        public long JornadaId { get; set; }
        public long SedeId { get; set; }
        public bool Activo { get; set; }
        public Nullable<long> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<long> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Clasificaciones Clasificaciones { get; set; }
        public virtual Grados Grados { get; set; }
        public virtual Grupos Grupos { get; set; }
        public virtual Jornadas Jornadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Juicios> Juicios { get; set; }
        public virtual Profesores Profesores { get; set; }
        public virtual Sedes Sedes { get; set; }
    }
}
