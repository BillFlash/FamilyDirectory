using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyDirectory.web.Startup))]
namespace FamilyDirectory.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
