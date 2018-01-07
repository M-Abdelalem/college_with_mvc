using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(college_inter.Startup))]
namespace college_inter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
