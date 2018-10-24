using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ThotMVC.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}


        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<AsociacionPrivadas> AsociacionPrivadas { get; set; }
        public DbSet<Calendarios> Calendarios { get; set; }
        public DbSet<CapacidadExcepcionales> CapacidadExcepcionales { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Escalafones> Escalafones { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<Estratos> Estratos { get; set; }
        public DbSet<Etnias> Etnias { get; set; }
        public DbSet<FuenteRecursos> FuenteRecursos { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Idiomas> Idiomas { get; set; }
        public DbSet<Instituciones> Instituciones { get; set; }
        public DbSet<Jornadas> Jornadas { get; set; }
        public DbSet<Metodologias> Metodologias { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
        public DbSet<Nucleos> Nucleos { get; set; }
        public DbSet<PoblacionVictimaConflictos> PoblacionVictimaConflictos { get; set; }
        public DbSet<Prestadores> Prestadores { get; set; }
        public DbSet<Profesiones> Profesiones { get; set; }
        public DbSet<PropiedadJuridicas> PropiedadJuridicas { get; set; }
        public DbSet<RegimenCostos> RegimenCostos { get; set; }
        public DbSet<Resguardos> Resguardos { get; set; }
        public DbSet<Sedes> Sedes { get; set; }
        public DbSet<Sisbenes> Sisbenes { get; set; }
        public DbSet<SituacionAcademicas> SituacionAcademicas { get; set; }
        public DbSet<TarifaAnuales> TarifaAnuales { get; set; }
        public DbSet<TipoCaracteres> TipoCaracteres { get; set; }
        public DbSet<TipoCondiciones> TipoCondiciones { get; set; }
        public DbSet<TipoDiscapacidades> TipoDiscapacidades { get; set; }
        public DbSet<TipoIdentificaciones> TipoIdentificaciones { get; set; }
        public DbSet<TipoNovedades> TipoNovedades { get; set; }
        public DbSet<TipoRespuestas> TipoRespuestas { get; set; }
        public DbSet<TipoSectorEducaciones> TipoSectorEducaciones { get; set; }
        public DbSet<Zonas> Zonas { get; set; }

        public DbSet<AporteParafiscales> AporteParafiscales { get; set; }
        public DbSet<Ars> Ars { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<ClasesFuncionarios> ClasesFuncionarios { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Eps> Eps { get; set; }
        public DbSet<Equivalencias> Equivalencias { get; set; }
        public DbSet<EscalaNacionales> EscalaNacionales { get; set; }
        public DbSet<EstadoCiviles> EstadoCiviles { get; set; }

        public DbSet<Grados> Grados { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<ValoracionLetras> ValoracionLetras { get; set; }

        public DbSet<FactorRhs> FactorRhs { get; set; }
        public DbSet<GeneroEstudiantes> GeneroEstudiantes { get; set; }
        public DbSet<Juicios> Juicios { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<NivelEducativos> NivelEducativos { get; set; }
        public DbSet<NivelEducativoDocentes> NivelEducativoDocentes { get; set; }
        public DbSet<Parentescos> Parentescos { get; set; }
        public DbSet<Periodos> Periodos { get; set; }
        public DbSet<TipoAcademicos> TipoAcademicos { get; set; }
        public DbSet<TipoDevengos> TipoDevengos { get; set; }
        public DbSet<TipoVinculaciones> TipoVinculaciones { get; set; }

        public DbSet<LibretaMilitares> LibretaMilitares { get; set; }

        public DbSet<Clasificaciones> Clasificaciones { get; set; }

        public DbSet<Estudiantes> Estudiantes { get; set; }
    }
}