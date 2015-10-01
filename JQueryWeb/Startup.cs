using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQueryWeb.Startup))]
namespace JQueryWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
