using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enterprise_System.Startup))]
namespace Enterprise_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
