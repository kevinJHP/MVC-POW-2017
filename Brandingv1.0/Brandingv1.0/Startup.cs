using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brandingv1._0.Startup))]
namespace Brandingv1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
