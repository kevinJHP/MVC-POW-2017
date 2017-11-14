using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20171112.Startup))]
namespace _20171112
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
