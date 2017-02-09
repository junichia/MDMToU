using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MDMToU.Startup))]
namespace MDMToU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
