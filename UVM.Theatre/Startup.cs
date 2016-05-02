using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UVM.Theatre.Startup))]
namespace UVM.Theatre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
