using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EpioneMVC.Startup))]
namespace EpioneMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
