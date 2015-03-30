using Luis.MasteringExtJs.WebApi;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(Startup))]

namespace Luis.MasteringExtJs.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
