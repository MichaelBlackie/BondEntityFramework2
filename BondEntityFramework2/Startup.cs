using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BondEntityFramework2.Startup))]
namespace BondEntityFramework2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
