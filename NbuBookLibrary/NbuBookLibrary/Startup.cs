using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NbuBookLibrary.Startup))]
namespace NbuBookLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
