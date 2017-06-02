using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoWeb0106.Startup))]
namespace ProjetoWeb0106
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
