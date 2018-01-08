using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrionCeramica.Startup))]
namespace OrionCeramica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
