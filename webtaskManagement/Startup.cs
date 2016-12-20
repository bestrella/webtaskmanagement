using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webtaskManagement.Startup))]
namespace webtaskManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
