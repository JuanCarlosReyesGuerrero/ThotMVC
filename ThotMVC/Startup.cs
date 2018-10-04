using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThotMVC.Startup))]
namespace ThotMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
