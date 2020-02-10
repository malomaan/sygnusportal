using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SygnusportalWEB.Startup))]
namespace SygnusportalWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
