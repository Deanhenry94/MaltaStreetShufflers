using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaltaStreetShufflers.MVC.Startup))]
namespace MaltaStreetShufflers.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
