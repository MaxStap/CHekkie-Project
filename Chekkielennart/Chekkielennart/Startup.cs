using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chekkielennart.Startup))]
namespace Chekkielennart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
