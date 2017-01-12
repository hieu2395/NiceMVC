using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAimar.Startup))]
namespace WebAimar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
