using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPApplications.Startup))]
namespace ASPApplications
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
