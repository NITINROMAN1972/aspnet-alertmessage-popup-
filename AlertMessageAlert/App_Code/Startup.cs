using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlertMessageAlert.Startup))]
namespace AlertMessageAlert
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
