using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dinerosol.Startup))]
namespace Dinerosol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
