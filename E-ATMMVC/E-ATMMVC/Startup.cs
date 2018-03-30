using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_ATMMVC.Startup))]
namespace E_ATMMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
