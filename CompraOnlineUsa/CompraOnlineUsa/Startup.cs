using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompraOnlineUsa.Startup))]
namespace CompraOnlineUsa
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
