using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticaMVC.Startup))]
namespace PracticaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
