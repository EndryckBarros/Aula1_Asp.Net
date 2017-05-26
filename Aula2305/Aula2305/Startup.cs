using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula2305.Startup))]
namespace Aula2305
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
