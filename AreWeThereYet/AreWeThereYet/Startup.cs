using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AreWeThereYet.Startup))]
namespace AreWeThereYet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
