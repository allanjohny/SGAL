using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGAL.MVC.Startup))]
namespace SGAL.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
