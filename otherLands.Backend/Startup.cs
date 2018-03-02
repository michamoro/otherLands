using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(otherLands.Backend.Startup))]
namespace otherLands.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
