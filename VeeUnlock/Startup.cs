using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeeUnlock.Startup))]
namespace VeeUnlock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
