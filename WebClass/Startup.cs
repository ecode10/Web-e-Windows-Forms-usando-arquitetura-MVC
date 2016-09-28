using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebClass.Startup))]
namespace WebClass
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
