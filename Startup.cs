using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruits_Web_Game.Startup))]
namespace Fruits_Web_Game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
