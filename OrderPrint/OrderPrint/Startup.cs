using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderPrint.Startup))]
namespace OrderPrint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
