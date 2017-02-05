using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contactWeb.Startup))]
namespace contactWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
