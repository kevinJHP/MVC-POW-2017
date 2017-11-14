using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNFV.VENTAS.Startup))]
namespace UNFV.VENTAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
