using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArmyViewer.Web.Startup))]
namespace ArmyViewer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
