using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineSalesInventoryMonitoringSystem.Startup))]
namespace OnlineSalesInventoryMonitoringSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
