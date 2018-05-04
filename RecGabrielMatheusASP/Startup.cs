using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecGabrielMatheusASP.Startup))]
namespace RecGabrielMatheusASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
