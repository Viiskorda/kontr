using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kolmas.Startup))]
namespace Kolmas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
