using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WepApiUmea01.Startup))]
namespace WepApiUmea01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
