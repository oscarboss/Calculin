using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calculin003.Startup))]
namespace Calculin003
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
