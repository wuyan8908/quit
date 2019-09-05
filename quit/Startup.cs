using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quit.Startup))]
namespace quit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
