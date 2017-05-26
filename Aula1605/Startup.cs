using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula1605.Startup))]
namespace Aula1605
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
