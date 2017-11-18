using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TZHWEB.Startup))]
namespace TZHWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
