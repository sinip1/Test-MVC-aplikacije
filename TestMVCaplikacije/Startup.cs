using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCaplikacije.Startup))]
namespace TestMVCaplikacije
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
