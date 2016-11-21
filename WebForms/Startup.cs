using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebForms.Startup))]
namespace WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
