using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreleasedZone.Startup))]
namespace PreleasedZone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
