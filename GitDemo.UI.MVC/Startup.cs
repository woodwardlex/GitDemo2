using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemo.UI.MVC.Startup))]
namespace GitDemo.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
