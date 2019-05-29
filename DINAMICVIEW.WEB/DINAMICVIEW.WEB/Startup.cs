using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DINAMICVIEW.WEB.Startup))]
namespace DINAMICVIEW.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
