using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moboer.Web.Startup))]
namespace moboer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
