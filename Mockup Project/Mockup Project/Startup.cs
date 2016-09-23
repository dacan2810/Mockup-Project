using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mockup_Project.Startup))]
namespace Mockup_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
