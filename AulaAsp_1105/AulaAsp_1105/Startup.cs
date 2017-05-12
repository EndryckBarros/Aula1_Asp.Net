using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AulaAsp_1105.Startup))]
namespace AulaAsp_1105
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
