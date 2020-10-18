using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_adp1.Startup))]
namespace proyecto_adp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
