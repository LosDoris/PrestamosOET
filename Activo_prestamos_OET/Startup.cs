using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Activo_prestamos_OET.Startup))]
namespace Activo_prestamos_OET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
