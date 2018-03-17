using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mohamedweb.Startup))]
namespace mohamedweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
