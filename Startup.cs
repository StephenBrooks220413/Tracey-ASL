using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tracey_ASL.Startup))]
namespace Tracey_ASL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
