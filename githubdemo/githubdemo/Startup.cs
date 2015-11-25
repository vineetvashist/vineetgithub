using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubdemo.Startup))]
namespace githubdemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
