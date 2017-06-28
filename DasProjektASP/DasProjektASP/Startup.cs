using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DasProjektASP.Startup))]
namespace DasProjektASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
