using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula2505.Startup))]
namespace Aula2505
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
