using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterAndLogin.Startup))]
namespace RegisterAndLogin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
