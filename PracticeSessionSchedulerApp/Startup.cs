using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeSessionSchedulerApp.Startup))]
namespace PracticeSessionSchedulerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
