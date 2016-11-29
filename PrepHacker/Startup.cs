using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrepHacker.Startup))]
namespace PrepHacker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
