using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentSia.Startup))]
namespace CentSia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
