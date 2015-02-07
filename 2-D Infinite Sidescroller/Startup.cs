using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_D_Infinite_Sidescroller.Startup))]
namespace _2_D_Infinite_Sidescroller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
