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
            
            /*
            context.Asignaturas.AddOrUpdate(x => x.Id,
                new Asignaturas() { Codigo = "BIOLO", Nombre = "CIENCIAS NATURALES (BIOLOGIA)", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now },
                new Asignaturas() { Codigo = "FISI", Nombre = "CIENCIAS NATURALES (FISICA)", SedeId = 1, Activo = true, UsuarioRegistra = 1, FechaRegistro = DateTime.Now, UsuarioModifica = 1, FechaModifica = DateTime.Now }
            );
            */





        }
    }
}
