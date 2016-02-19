using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplySite.Startup))]
namespace ApplySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
