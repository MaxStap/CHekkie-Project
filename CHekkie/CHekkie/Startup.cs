using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHekkie.Startup))]
namespace CHekkie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
