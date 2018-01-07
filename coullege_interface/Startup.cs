using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coullege_interface.Startup))]
namespace coullege_interface
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
