using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerBouquet.Startup))]
namespace FlowerBouquet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
