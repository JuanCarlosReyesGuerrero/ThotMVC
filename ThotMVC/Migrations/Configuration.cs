namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThotMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThotMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            //Para produccion quitar
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ThotMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.AporteParafiscales.AddOrUpdate(x => x.Id,
                new AporteParafiscales() { Codigo = 1, Nombre = "Pago EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AporteParafiscales() { Codigo = 2, Nombre = "Pago Pensión", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AporteParafiscales() { Codigo = 3, Nombre = "Pago ARP", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AporteParafiscales() { Codigo = 4, Nombre = "Pago Cesantías", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            
            context.Ars.AddOrUpdate(x => x.Id,
                new Ars() { Codigo = "ESS190", Nombre = "ASOCIACION DE AUTORIDADES TRADICIONALES EMMANUEL E.PS.. INDIGENA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS184", Nombre = "ASOCIACION DE CABILDOS DEL RESGUARDO  INDIGENA ZENU DE SAN ANDRES DE SOTAVENTO CORDOVA Y SUCRE - MANEXKA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS177", Nombre = "ASOCIACION DE CABILDOS INDIGENAS DEL CESAR Y GUAJIRA   DUSAKAWI EPSI", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS076", Nombre = "ASOCIACION MUTUAL BARRIOS UNIDOS DE QUIBDO", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS062", Nombre = "ASOCIACION MUTUAL LA ESPERANZA ASMET SALUD", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS061", Nombre = "ASOCIACION MUTUAL LA SUIZA DE AMERICA ESS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS207", Nombre = "ASOCIACION MUTUAL SER EMPRESA SOLIDARIA  DE SALUD ESS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS118", Nombre = "ASOCIACION SOLIDARIA DE SALUD DE NARIÑO ESS EMSSANAR ESS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS182", Nombre = "ASOCIACION  INDIGENA DEL CAUCA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF017", Nombre = "CAJA DE COMPENSACION FAMILIAR ASFAMILIAS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF018", Nombre = "CAJA DE COMPENSACION FAMILIAR CAFAM", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF001", Nombre = "CAJA DE COMPENSACION FAMILIAR COMFAMILIAR CAMACOL COMFAMILIAR CAMACOL", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF002", Nombre = "CAJA DE COMPENSACION FAMILIAR DE ANTIOQUIA  COMFAMA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF035", Nombre = "CAJA DE COMPENSACION FAMILIAR DE BARRANCABERMEJA CAFABA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF040", Nombre = "CAJA DE COMPENSACION FAMILIAR DE CARTAGO COMFACARTAGO", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF015", Nombre = "CAJA DE COMPENSACION FAMILIAR DE CORDOBA COMFACOR", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF054", Nombre = "CAJA DE COMPENSACION FAMILIAR DE FENALCO COMFENALCO  - CUNDINAMARCA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF037", Nombre = "CAJA DE COMPENSACION FAMILIAR DE FENALCO DE TOLIMA COMFENALCO", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "CCF029", Nombre = "CAJA DE COMPENSACION FAMILIAR DE RISARALDA COMFAMILIAR RISARALDA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "UT001", Nombre = "CAJASALUD  ARS  UT", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "UT002", Nombre = "COMFAMILIARES EN SALUD UT", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "UT004", Nombre = "CONVENIO CAMACOL - COMFAMA UT", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "UT003", Nombre = "CONVENIO COMFENALCO UT", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS133", Nombre = "COOPERATIVA DE SALUD COMUARIA COMPARTA ARS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS024", Nombre = "COOPERATIVA DE SALUD  Y DESARROLLO INTEGRAL  DE LA  ZONA SUR ORIENTAL DE CARTAGENA LTDA COOSALUD ESS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS208", Nombre = "EMPRESA ANS WAYUU", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS002", Nombre = "EMPRESA MUTUAL PARA EL DESARROLLO INTEGRAL DE  LA SALUD DE ARBOLETES ESS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS091", Nombre = "ENTIDAD COOPERATIVA SOLIDARIA DE SALUD ECOOPSOS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS164", Nombre = "ENTIDAD PROMOTORA DE SALUD PIJAOS SALUD EPSI", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS115", Nombre = "ENTIDAD PROMOTORA DE SALUD MALLAMAS EPS-I", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Ars() { Codigo = "ESS170", Nombre = "GUAITARA ENTIDAD PROMOTORA DE SALUD INDIGENA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.AsociacionPrivadas.AddOrUpdate(x => x.Id,
                new AsociacionPrivadas() { Codigo = "1", Nombre = "CONACED NACIONAL", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AsociacionPrivadas() { Codigo = "2", Nombre = "CONEP", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AsociacionPrivadas() { Codigo = "3", Nombre = "ANDERCOP", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AsociacionPrivadas() { Codigo = "4", Nombre = "ASOCOLDEP", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AsociacionPrivadas() { Codigo = "5", Nombre = "ACOMIL", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new AsociacionPrivadas() { Codigo = "6", Nombre = "UNCOLI", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Calendarios.AddOrUpdate(x => x.Id,
                new Calendarios() { Codigo = "1", Nombre = "Calendario A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Calendarios() { Codigo = "2", Nombre = "Calendario B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.CapacidadExcepcionales.AddOrUpdate(x => x.Id,
                new CapacidadExcepcionales() { Codigo = "1", Nombre = "Superdotado", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new CapacidadExcepcionales() { Codigo = "2", Nombre = "Con talento científico", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new CapacidadExcepcionales() { Codigo = "3", Nombre = "Con talento tecnológico", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new CapacidadExcepcionales() { Codigo = "4", Nombre = "Con talento subjetivo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new CapacidadExcepcionales() { Codigo = "9", Nombre = "No Aplica", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Cargos.AddOrUpdate(x => x.Id,
                new Cargos() { Codigo = "1", Nombre = "Docente", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Cargos() { Codigo = "2", Nombre = "Directivo Docente", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Cargos() { Codigo = "3", Nombre = "Administrativo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.ClasesFuncionarios.AddOrUpdate(x => x.Id,
                new ClasesFuncionarios() { Codigo = "0", Nombre = "Sin Docente Oficial", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "1", Nombre = "Rectores", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "10", Nombre = "Profesionales de apoyo en el aula a alumnos con discapacidades ((intérpretes, tiflólogos, etc.)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "11", Nombre = "Profesionales en el área de la salud (Médicos, odontólogos, terapeutas, enfermeros, etc)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "12", Nombre = "Consejeros y orientadores", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "13", Nombre = "Director Rural", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "2", Nombre = "Coordinadores", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "3", Nombre = "Supervisores de Educación", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "4", Nombre = "Directores de Núcleo de Desarrollo Educativo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "5", Nombre = "Docentes", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "6", Nombre = "Docentes en Comisión", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "7", Nombre = "Docentes de educación especial", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "8", Nombre = "Etnoeducadores", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new ClasesFuncionarios() { Codigo = "9", Nombre = "Administrativos", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Eps.AddOrUpdate(x => x.Id,
                new Eps() { Codigo = "EPS003", Nombre = " CAFESALUD EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS009", Nombre = " CAJA DE COMPENSACION FAMILIAR COMFENALCO ANTIOQUIA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS001", Nombre = " COLMEDICA ENTIDAD PROMOTORA DE SALUD S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS012", Nombre = " COMFENALCO VALLE EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS010", Nombre = " COMPAÑIA SURAMERICANA DE SERVICIOS DE SALUD S.A. SUSALUD", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS016", Nombre = " COOMEVA EPS S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS023", Nombre = " CRUZBLANCA S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS017", Nombre = " E.P.S. FAMISANAR LTDA. CAFAM COLSUBSIDIO", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS005", Nombre = " E.P.S. SANITAS S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EAS016", Nombre = " EMPRESAS PUBLICAS DE MEDELLIN SERVICIOS MEDICOS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EAS027", Nombre = " FONDO DE PASIVO SOCIAL DE FERROCARRILES NACIONALES DE COLOMBIA", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS014", Nombre = " HUMANA VIVIR S.A. EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS006", Nombre = " INSTITUTO DE SEGUROS SOCIALES", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS035", Nombre = " REDSALUD ATENCION HUMANA EPS S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS015", Nombre = " SALUD COLPATRIA S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS002", Nombre = " SALUD TOTAL S.A. EPS ARS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS034", Nombre = " SALUDCOLOMBIA EPS S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS013", Nombre = " SALUDCOOP EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS033", Nombre = " SALUDVIDA S.A. EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS018", Nombre = " SERVICIO OCCIDENTAL DE SALUD S.A. S.O.S.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS026", Nombre = " SOLIDARIA DE SALUD SOLSALUD S.A.", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS008", Nombre = "COMPENSAR ENTIDAD PROMOTORA DE SALUD", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "MIN001", Nombre = "FONDO DE SOLIDARIDAD Y GARANTIA-FOSYGA-MINISTERIO DE SALDUD", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Eps() { Codigo = "EPS037", Nombre = "Nueva Promotora de Salud - Nueva EPS", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Escalafones.AddOrUpdate(x => x.Id,
                new Escalafones() { Codigo = "1", Nombre = "SE Sin escalafón", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "10", Nombre = "01", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "11", Nombre = "02", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "12", Nombre = "03", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "13", Nombre = "04", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "14", Nombre = "05", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "15", Nombre = "06", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "16", Nombre = "07", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "17", Nombre = "08", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "18", Nombre = "09", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "19", Nombre = "10", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "2", Nombre = "BC Bachiller", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "20", Nombre = "11", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "21", Nombre = "12", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "22", Nombre = "13", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "23", Nombre = "14", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "24", Nombre = "1A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "25", Nombre = "1B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "26", Nombre = "1C", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "27", Nombre = "1D", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "28", Nombre = "2A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "29", Nombre = "2B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "3", Nombre = "PT Profesional técnico o tecnológico", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "30", Nombre = "2C", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "31", Nombre = "2D", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "32", Nombre = "3A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "33", Nombre = "3B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "34", Nombre = "3C", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "35", Nombre = "3D", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "4", Nombre = "PU Profesional universitario", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "5", Nombre = "IA Instructor II-A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "6", Nombre = "IB Instructor III-B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "7", Nombre = "IC Instructor IV-C", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "8", Nombre = "A", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Escalafones() { Codigo = "9", Nombre = "B", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );


            context.Especialidades.AddOrUpdate(x => x.Id,
                new Especialidades() { Codigo = "0", Nombre = "No aplica", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "5", Nombre = "Académico", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "6", Nombre = "Industrial", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "7", Nombre = "Otro", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "8", Nombre = "Comercial", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "9", Nombre = "Pedagógico", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "10", Nombre = "Agropecuario", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Especialidades() { Codigo = "16", Nombre = "Promoción Social", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
           );



           context.EstadoCiviles.AddOrUpdate(x => x.Id,
               new EstadoCiviles() { Codigo = "1", Nombre = "Soltero", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new EstadoCiviles() { Codigo = "2", Nombre = "Casado", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new EstadoCiviles() { Codigo = "3", Nombre = "Divorciado", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new EstadoCiviles() { Codigo = "4", Nombre = "Viudo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new EstadoCiviles() { Codigo = "5", Nombre = "Unión libre", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new EstadoCiviles() { Codigo = "6", Nombre = "Separado", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
           );



           context.Estratos.AddOrUpdate(x => x.Id,
               new Estratos() { Codigo = "1", Nombre = "1", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Estratos() { Codigo = "2", Nombre = "2", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Estratos() { Codigo = "3", Nombre = "3", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Estratos() { Codigo = "4", Nombre = "4", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Estratos() { Codigo = "5", Nombre = "5", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Estratos() { Codigo = "6", Nombre = "6", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Etnias.AddOrUpdate(x => x.Id,
               new Etnias() { Codigo = "00", Nombre = "No Aplica", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "01", Nombre = "Achagua", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "02", Nombre = "Amorúa", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "03", Nombre = "Andoque o Andoke", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "04", Nombre = "Arhuaco (IJKA)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "05", Nombre = "Awa (CUAIKER)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "06", Nombre = "Barea", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "07", Nombre = "Barazana", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "08", Nombre = "Barí (Motilón)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "09", Nombre = "Betoye", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "10", Nombre = "Bora", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "11", Nombre = "Cabiyari o Kawiyarí", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "12", Nombre = "Carapana", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "13", Nombre = "Carijona o Karijona", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "14", Nombre = "Chimila (ETTE E´ NEKA)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "15", Nombre = "Chiricoa", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "16", Nombre = "Cocama", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "17", Nombre = "Coconuco", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "18", Nombre = "Cofán o Kofán", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "19", Nombre = "Pijaos", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "20", Nombre = "Cubeo o Kubeo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "200", Nombre = "Negritudes", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "21", Nombre = "Cuiba o Kuiba", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "22", Nombre = "Curripaco o Kurripako", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "23", Nombre = "Desano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "24", Nombre = "Dujos", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "26", Nombre = "Embera Catio o Embera Katío", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "27", Nombre = "Embera Chami", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "28", Nombre = "Eperara Siapidara", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "29", Nombre = "Guambiano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "30", Nombre = "Guanaca", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "31", Nombre = "Guayabero", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "33", Nombre = "Hitnú", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "34", Nombre = "Inga", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "35", Nombre = "Kamsa o Kamëntsá", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "36", Nombre = "Kogui", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "37", Nombre = "Koreguaje o Coreguaje", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "38", Nombre = "Letuama", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "39", Nombre = "Macaguaje o Makaguaje", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "40", Nombre = "Nukak (Makú)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "400", Nombre = "Rom", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "41", Nombre = "Macuna o Makuna (Sara)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "42", Nombre = "Masiguare", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "43", Nombre = "Matapí", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "44", Nombre = "Miraña", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "45", Nombre = "Muinane", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "46", Nombre = "Muisca", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "47", Nombre = "Nonuya", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "48", Nombre = "Ocaina", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "49", Nombre = "Nasa (Paéz)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "50", Nombre = "Pastos", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "51", Nombre = "Piapoco (Dzase)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "52", Nombre = "Piaroa", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "53", Nombre = "Piratapuyo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "54", Nombre = "Pisamira", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "55", Nombre = "Puinave", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "56", Nombre = "Sáliba", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "57", Nombre = "Sikuani", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "58", Nombre = "Siona", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "59", Nombre = "Siriano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "60", Nombre = "Siripu o Tsiripu (Mariposo)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "61", Nombre = "Taiwano (Tajuano)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "62", Nombre = "TanimuKa", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "63", Nombre = "Tariano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "64", Nombre = "Tatuyo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "65", Nombre = "Tikuna", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "66", Nombre = "Totoró", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "67", Nombre = "Tucano (Desea) o Tukano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "68", Nombre = "Tule (Kuna)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "69", Nombre = "Tuyuka (Dojkapuara)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "70", Nombre = "U´wa (Tunebo)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "71", Nombre = "Wanano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "72", Nombre = "Wayuu", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "73", Nombre = "Witoto", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "74", Nombre = "Wiwa (Arzario)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "75", Nombre = "Waunan (Wuanana)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "76", Nombre = "Yagua", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "77", Nombre = "Yanacona", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "78", Nombre = "Yauna", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "79", Nombre = "Yukuna", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "80", Nombre = "Yuko (Yukpa)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "81", Nombre = "Yurí (Carabayo)", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "82", Nombre = "Yuruti", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "83", Nombre = "Zenú", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Etnias() { Codigo = "84", Nombre = "Quillacingas", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );


            context.FactorRhs.AddOrUpdate(x => x.Id,
               new FactorRhs() { Codigo = "1", Nombre = "O-", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "2", Nombre = "O+", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "3", Nombre = "A−", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "4", Nombre = "A+", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "5", Nombre = "B-", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "6", Nombre = "B+", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "7", Nombre = "AB−", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new FactorRhs() { Codigo = "8", Nombre = "AB+", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

           
            context.LibretaMilitares.AddOrUpdate(x => x.Id,
                new LibretaMilitares() { Codigo = "1", Nombre = "Primera", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new LibretaMilitares() { Codigo = "2", Nombre = "Segunda", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );            

            context.Idiomas.AddOrUpdate(x => x.Id,     
               new Idiomas() { Codigo = "0", Nombre = "No Aplica", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "1", Nombre = "Inglés", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "10", Nombre = "Francés-Italiano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "11", Nombre = "Francés-Alemán", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "12", Nombre = "Italiano-Alemán", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "2", Nombre = "Francés", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "3", Nombre = "Italiano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "4", Nombre = "Alemán", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "5", Nombre = "Hebreo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "6", Nombre = "Inglés-Francés", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "7", Nombre = "Inglés-Italiano", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "8", Nombre = "Inglés-Alemán", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Idiomas() { Codigo = "9", Nombre = "Inglés-Hebreo", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );
            

            context.GeneroEstudiantes.AddOrUpdate(x => x.Id,     
               new GeneroEstudiantes() { Codigo = "1", Nombre = "Masculino", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new GeneroEstudiantes() { Codigo = "2", Nombre = "Femenino", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new GeneroEstudiantes() { Codigo = "3", Nombre = "Mixto", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Generos.AddOrUpdate(x => x.Id,
               new Generos() { Codigo = "1", Nombre = "Masculino", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Generos() { Codigo = "2", Nombre = "Femenino", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Generos() { Codigo = "3", Nombre = "Mixto", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );


            context.FuenteRecursos.AddOrUpdate(x => x.Id,
                new FuenteRecursos() { Codigo = "1", Nombre = "SGP", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new FuenteRecursos() { Codigo = "2", Nombre = "FNR", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new FuenteRecursos() { Codigo = "3", Nombre = "Recursos adicionales presupuesto nacional MEN", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new FuenteRecursos() { Codigo = "4", Nombre = "Otros Recursos de la Nación", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new FuenteRecursos() { Codigo = "5", Nombre = "Recursos Propios", Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );























            /*              
            context.EscalaNacionales.AddOrUpdate(x => x.Id,
                new EscalaNacionales() { Codigo = "1", Nombre = "Desempeño Bajo", CriterioEvalaluacion = "No alcanza todos los logros mínimos propuestos", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new EscalaNacionales() { Codigo = "2", Nombre = "Desempeño Básico", CriterioEvalaluacion = ".", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new EscalaNacionales() { Codigo = "3", Nombre = "Desempeño Alto", CriterioEvalaluacion = ".", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new EscalaNacionales() { Codigo = "4", Nombre = "Desempeño Superior", CriterioEvalaluacion = ".", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );
           
            context.Asignaturas.AddOrUpdate(x => x.Id,
                new Asignaturas() { Codigo = "BIOLO", Nombre = "CIENCIAS NATURALES (BIOLOGIA)", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Asignaturas() { Codigo = "FISI", Nombre = "CIENCIAS NATURALES (FISICA)", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

            context.Jornadas.AddOrUpdate(x => x.Id,           
               new Jornadas() { Codigo = "1", Nombre = "Completa", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Jornadas() { Codigo = "2", Nombre = "Mañana", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Jornadas() { Codigo = "3", Nombre = "Tarde", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Jornadas() { Codigo = "4", Nombre = "Nocturna", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Jornadas() { Codigo = "5", Nombre = "Fin de Semana", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

             context.Grupos.AddOrUpdate(x => x.Id,         
               new Grupos() { Codigo = "1", Nombre = "A", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grupos() { Codigo = "2", Nombre = "B", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grupos() { Codigo = "3", Nombre = "C", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );

             context.Grados.AddOrUpdate(x => x.Id,
               new Grados() { Codigo = "-2", Nombre = "Pre-Jardin", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "-1", Nombre = "Jardin", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "0", Nombre = "Transición", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "1", Nombre = "Primero", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "2", Nombre = "Segundo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "3", Nombre = "Tercero", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "4", Nombre = "Cuarto", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "5", Nombre = "Quinto", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "6", Nombre = "Sexto", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "7", Nombre = "Séptimo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "8", Nombre = "Octavo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "9", Nombre = "Noveno", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "10", Nombre = "Décimo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "11", Nombre = "Onceavo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
               new Grados() { Codigo = "12", Nombre = "Doceavo", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
            );

            */





        }
    }
}
