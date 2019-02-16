using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheCollectorsCoLIVE.Startup))]
namespace TheCollectorsCoLIVE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
