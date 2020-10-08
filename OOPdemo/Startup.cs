using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OOPdemo.Startup))]
namespace OOPdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
